using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OfficeSuppliesRequisition
    /// </summary>
	public class OfficeSuppliesRequisitionDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// OutDate
        /// </summary>
		public DateTime OutDate { get; set; }
		
		/// <summary>
        /// OutStaffID
        /// </summary>
		public int OutStaffID { get; set; }
		
		/// <summary>
        /// OutStaffName
        /// </summary>
		public string OutStaffName { get; set; }
		
		/// <summary>
        /// Remark
        /// </summary>
		public string Remark { get; set; }
		
		/// <summary>
        /// StaffID
        /// </summary>
		public int StaffID { get; set; }
		
		/// <summary>
        /// StaffName
        /// </summary>
		public string StaffName { get; set; }
		
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
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}