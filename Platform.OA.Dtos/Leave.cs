using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// Leave
    /// </summary>
	public class LeaveDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// WorkToDoid
        /// </summary>
		public int WorkToDoid { get; set; }
		
		/// <summary>
        /// Types
        /// </summary>
		public int Types { get; set; }
		
		/// <summary>
        /// StartDate
        /// </summary>
		public DateTime StartDate { get; set; }
		
		/// <summary>
        /// EndDate
        /// </summary>
		public DateTime EndDate { get; set; }
		
		/// <summary>
        /// Times
        /// </summary>
		public decimal Times { get; set; }
		
		/// <summary>
        /// Note
        /// </summary>
		public string Note { get; set; }
		
		/// <summary>
        /// DaiLiRen
        /// </summary>
		public string DaiLiRen { get; set; }
		
		/// <summary>
        /// Jobs
        /// </summary>
		public string Jobs { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}