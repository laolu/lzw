using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mvc.JQuery.Datatables
{
    static class TypeFilters
    {
        private static readonly Func<string, Type, object> ParseValue =
            (input, t) => t.IsEnum ? Enum.Parse(t, input) : Convert.ChangeType(input, t);

        internal static string FilterMethod(string q, List<object> parametersForLinqQuery, Type type)
        {


            Func<string, string, string> makeClause = (method, query) =>
            {
                parametersForLinqQuery.Add(ParseValue(query, type));
                var indexOfParameter = parametersForLinqQuery.Count - 1;
                return string.Format("{0}(@{1})", method, indexOfParameter);
            };
            if (q.StartsWith("^"))
            {
                if (q.EndsWith("$"))
                {
                    parametersForLinqQuery.Add(ParseValue(q.Substring(1, q.Length - 2), type));
                    var indexOfParameter = parametersForLinqQuery.Count - 1;
                    return string.Format("Equals((object)@{0})", indexOfParameter);
                }
                return makeClause("StartsWith", q.Substring(1));
            }
            else
            {
                if (q.EndsWith("$"))
                {
                    return makeClause("EndsWith", q.Substring(0, q.Length - 1));
                }
                return makeClause("Contains", q);
            }
        }
        public static string NumericFilter(string query, string columnname, ColInfo colInfo, List<object> parametersForLinqQuery)
        {
            if (query.StartsWith("^")) query = query.TrimStart('^');
            if (query.EndsWith("$")) query = query.TrimEnd('$');

            if (query == "~") return string.Empty;

            if (query.Contains("~"))
            {
                var parts = query.Split('~');
                var clause = null as string;
                try
                {
                    parametersForLinqQuery.Add(ChangeType(colInfo, parts[0]));
                    clause = string.Format("{0} >= @{1}", columnname, parametersForLinqQuery.Count - 1);
                }
                catch (FormatException)
                {
                }

                try
                {
                    parametersForLinqQuery.Add(ChangeType(colInfo, parts[1]));
                    if (clause != null) clause += " and ";
                    clause += string.Format("{0} <= @{1}", columnname, parametersForLinqQuery.Count - 1);
                }
                catch (FormatException)
                {
                }
                return clause ?? "true";

            }
            else
            {
                try
                {
                    parametersForLinqQuery.Add(ChangeType(colInfo, query));
                    return string.Format("{0} == @{1}", columnname, parametersForLinqQuery.Count - 1);
                }
                catch (FormatException)
                {
                }
                return null;
            }
        }

        private static object ChangeType(ColInfo colInfo, string query)
        {
            if (colInfo.Type.IsGenericType && colInfo.Type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                Type u = Nullable.GetUnderlyingType(colInfo.Type);
                return Convert.ChangeType(query, u);
            }
            else
            {
                return Convert.ChangeType(query, colInfo.Type);
            }
        }

        public static string DateTimeOffsetFilter(string query, string columnname, ColInfo colInfo, List<object> parametersForLinqQuery)
        {
            if (query == "~") return string.Empty;

            if (query.Contains("~"))
            {
                var parts = query.Split('~');
                DateTimeOffset start, end;
                DateTimeOffset.TryParse(parts[0] ?? "", out start);
                if (!DateTimeOffset.TryParse(parts[1] ?? "", out end))
                {
                    end = DateTimeOffset.MaxValue;
                }
                else
                {
                    end = end.Date.AddDays(1);
                }

                parametersForLinqQuery.Add(start);
                parametersForLinqQuery.Add(end.AddDays(1).AddSeconds(-1));
                return string.Format("{0} >= @{1} and {0} < @{2}", columnname, parametersForLinqQuery.Count - 2, parametersForLinqQuery.Count - 1);
            }
            else
            {
                return string.Format("{1}.ToLocalTime().ToString(\"g\").{0}", FilterMethod(query, parametersForLinqQuery, colInfo.Type), columnname);
            }
        }
        public static string DateTimeFilter(string query, string columnname, ColInfo colInfo, List<object> parametersForLinqQuery)
        {
            if (query == "~") return string.Empty;
            if (query.Contains("~"))
            {
                var parts = query.Split('~');
                DateTime start, end;
                DateTime.TryParse(parts[0] ?? "", out start);
                if (!DateTime.TryParse(parts[1] ?? "", out end))
                {
                    end = DateTime.MaxValue;
                }
                else
                {
                    end = end.Date.AddDays(1);
                }

                parametersForLinqQuery.Add(start);
                parametersForLinqQuery.Add(end);
                return string.Format("{0} >= @{1} and {0} < @{2}", columnname, parametersForLinqQuery.Count - 2, parametersForLinqQuery.Count - 1);
            }
            else
            {
                return string.Format("{1}.ToLocalTime().ToString(\"g\").{0}", FilterMethod(query, parametersForLinqQuery, colInfo.Type), columnname);
            }
        }
        public static string BoolFilter(string query, string columnname, ColInfo colInfo, List<object> parametersForLinqQuery)
        {
            if (query != null)
                query = query.TrimStart('^').TrimEnd('$');
            var lowerCaseQuery = query.ToLowerInvariant();
            if (lowerCaseQuery == "false" || lowerCaseQuery == "true")
            {
                if (query.ToLower() == "true") return columnname + " == true";
                return columnname + " == false";
            }
            if (colInfo.Type == typeof(bool?))
            {
                if (lowerCaseQuery == "null") return columnname + " == null";
            }
            return null;

        }

        public static string StringFilter(string q, string columnname, ColInfo columntype, List<object> parametersforlinqquery)
        {
            if (q == ".*") return "";
            if (q.StartsWith("^"))
            {
                if (q.EndsWith("$"))
                {
                    parametersforlinqquery.Add(q.Substring(1, q.Length - 2));
                    var parameterArg = "@" + (parametersforlinqquery.Count - 1);
                    return string.Format("{0} ==  {1}", columnname, parameterArg);

                }
                else
                {
                    parametersforlinqquery.Add(q.Substring(1));
                    var parameterArg = "@" + (parametersforlinqquery.Count - 1);
                    return string.Format("({0} != null && {0} != \"\" && ({0} ==  {1} || {0}.StartsWith({1})))", columnname, parameterArg);
                }
            }
            else
            {
                parametersforlinqquery.Add(q);
                var parameterArg = "@" + (parametersforlinqquery.Count - 1);
                //return string.Format("{0} ==  {1}", columnname, parameterArg);
                return
                    string.Format(
                        "({0} != null && {0} != \"\" && ({0} ==  {1} || {0}.StartsWith({1}) || {0}.Contains({1})))",
                        columnname, parameterArg);
            }
        }

        public static string EnumFilter(string q, string columnname, ColInfo colInfo, List<object> parametersForLinqQuery)
        {

            if (q.StartsWith("^")) q = q.Substring(1);
            if (q.EndsWith("$")) q = q.Substring(0, q.Length - 1);
            parametersForLinqQuery.Add(ParseValue(q, colInfo.Type));
            return columnname + " == @" + (parametersForLinqQuery.Count - 1);
        }
    }
}