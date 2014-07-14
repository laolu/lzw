using System;
using System.Collections.Generic;
using System.Linq;
using Mvc.JQuery.Datatables.DynamicLinq;

namespace Mvc.JQuery.Datatables
{
    public class DataTablesFilter
    {
        public IQueryable<T> FilterPagingSortingSearch<T>(DataTablesParam dtParameters, IQueryable<T> data, ColInfo[] columns)
        {
            if (!String.IsNullOrEmpty(dtParameters.sSearch))
            {
                var parts = new List<string>();
                var parameters = new List<object>();
                for (var i = 0; i < dtParameters.iColumns; i++)
                {
                    if (dtParameters.bSearchable[i])
                    {
                        try
                        {
                            parts.Add(GetFilterClause(dtParameters.sSearch, columns[i], parameters));
                        }
                        catch (Exception)
                        {
                            //if the clause doesn't work, skip it!
                        }
                    }
                }
                var values = parts.Where(p => p != null);
                data = data.Where(string.Join(" or ", values), parameters.ToArray());
            }
            for (int i = 0; i < dtParameters.sSearchColumns.Count; i++)
            {
                if (dtParameters.bSearchable[i])
                {
                    var searchColumn = dtParameters.sSearchColumns[i];
                    if (!string.IsNullOrWhiteSpace(searchColumn))
                    {
                        var parameters = new List<object>();
                        var filterClause = GetFilterClause(dtParameters.sSearchColumns[i], columns[i], parameters);
                        if (string.IsNullOrWhiteSpace(filterClause) == false)
                        {
                            data = data.Where(filterClause, parameters.ToArray());
                        }
                    }
                }
            }
            string sortString = "";
            for (int i = 0; i < dtParameters.iSortingCols; i++)
            {

                int columnNumber = dtParameters.iSortCol[i];
                string columnName = columns[columnNumber].Name;
                string sortDir = dtParameters.sSortDir[i];
                if (i != 0)
                    sortString += ", ";
                sortString += columnName + " " + sortDir;
            }
            if (string.IsNullOrWhiteSpace(sortString))
            {
                sortString = columns[0].Name;
            }
            data = data.OrderBy(sortString);


            return data;
        }

        public delegate string ReturnedFilteredQueryForType(
            string query, string columnName, ColInfo columnType, List<object> parametersForLinqQuery);


        private static readonly List<ReturnedFilteredQueryForType> Filters = new List<ReturnedFilteredQueryForType>()
        {
            Guard(IsBoolType, TypeFilters.BoolFilter),
            Guard(IsDateTimeType, TypeFilters.DateTimeFilter),
            Guard(IsDateTimeOffsetType, TypeFilters.DateTimeOffsetFilter),
            Guard(IsNumericType, TypeFilters.NumericFilter),
            Guard(IsEnumType, TypeFilters.EnumFilter),
            Guard(arg => arg.Type == typeof (string), TypeFilters.StringFilter),
        };


        public delegate string GuardedFilter(
            string query, string columnName, ColInfo columnType, List<object> parametersForLinqQuery);

        private static ReturnedFilteredQueryForType Guard(Func<ColInfo, bool> guard, GuardedFilter filter)
        {
            return (q, c, t, p) =>
            {
                if (!guard(t))
                {
                    return null;
                }
                return filter(q, c, t, p);
            };
        }

        public static void RegisterFilter<T>(GuardedFilter filter)
        {
            Filters.Add(Guard(arg => arg is T, filter));
        }

        private static string GetFilterClause(string query, ColInfo column, List<object> parametersForLinqQuery)
        {
            Func<string, string> filterClause = (queryPart) =>
                                                Filters.Select(
                                                    f => f(queryPart, column.Name, column, parametersForLinqQuery))
                                                       .FirstOrDefault(filterPart => filterPart != null) ?? "";

            var queryParts = query.Split('|').Select(filterClause).Where(fc => fc != "").ToArray();
            if (queryParts.Any())
            {
                return "(" + string.Join(") OR (", queryParts) + ")";
            }
            return null;
        }


        public static bool IsNumericType(ColInfo colInfo)
        {
            var type = colInfo.Type;
            return IsNumericType(type);
        }

        private static bool IsNumericType(Type type)
        {
            if (type == null || type.IsEnum)
            {
                return false;
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                case TypeCode.Object:
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof (Nullable<>))
                    {
                        return IsNumericType(Nullable.GetUnderlyingType(type));
                    }
                    return false;
            }
            return false;
        }

        public static bool IsEnumType(ColInfo colInfo)
        {
            return colInfo.Type.IsEnum;
        }

        public static bool IsBoolType(ColInfo colInfo)
        {
            return colInfo.Type == typeof(bool) || colInfo.Type == typeof(bool?);
        }
        public static bool IsDateTimeType(ColInfo colInfo)
        {
            return colInfo.Type == typeof(DateTime) || colInfo.Type == typeof(DateTime?);
        }
        public static bool IsDateTimeOffsetType(ColInfo colInfo)
        {
            return colInfo.Type == typeof(DateTimeOffset) || colInfo.Type == typeof(DateTimeOffset?);
        }

    }
}