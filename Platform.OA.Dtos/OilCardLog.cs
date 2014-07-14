using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OilCardLog
    /// </summary>
	public class OilCardLogDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// OilCardID
        /// </summary>
		public int OilCardID { get; set; }
		
		/// <summary>
        /// Amount
        /// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
        /// LogDate
        /// </summary>
		public DateTime LogDate { get; set; }
		
		/// <summary>
        /// Status
        /// </summary>
		public bool Status { get; set; }
		
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
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}