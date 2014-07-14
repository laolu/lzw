using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OfficeSupplyIn
    /// </summary>
	public class OfficeSupplyInDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// InDate
        /// </summary>
		public DateTime InDate { get; set; }
		
		/// <summary>
        /// SupplierName
        /// </summary>
		public string SupplierName { get; set; }
		
		/// <summary>
        /// Remark
        /// </summary>
		public string Remark { get; set; }
		
		/// <summary>
        /// TotalAmount
        /// </summary>
		public decimal TotalAmount { get; set; }
		
		/// <summary>
        /// Status
        /// </summary>
		public bool Status { get; set; }
		
		/// <summary>
        /// IsDelete
        /// </summary>
		public bool IsDelete { get; set; }
		
		/// <summary>
        /// StaffID
        /// </summary>
		public int StaffID { get; set; }
		
		/// <summary>
        /// StaffName
        /// </summary>
		public string StaffName { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}