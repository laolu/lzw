using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// TravelApplication
    /// </summary>
	public class TravelApplicationDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// Title
        /// </summary>
		public string Title { get; set; }
		
		/// <summary>
        /// TravelPath
        /// </summary>
		public string TravelPath { get; set; }
		
		/// <summary>
        /// TravelDate
        /// </summary>
		public DateTime TravelDate { get; set; }
		
		/// <summary>
        /// BackDate
        /// </summary>
		public DateTime BackDate { get; set; }
		
		/// <summary>
        /// TravelSumDay
        /// </summary>
		public double TravelSumDay { get; set; }
		
		/// <summary>
        /// PeopleTogether
        /// </summary>
		public string PeopleTogether { get; set; }
		
		/// <summary>
        /// TravelTool
        /// </summary>
		public string TravelTool { get; set; }
		
		/// <summary>
        /// TravelAdvance
        /// </summary>
		public decimal TravelAdvance { get; set; }
		
		/// <summary>
        /// IsHaveDriver
        /// </summary>
		public bool IsHaveDriver { get; set; }
		
		/// <summary>
        /// Remark
        /// </summary>
		public string Remark { get; set; }
		
		/// <summary>
        /// IsDelete
        /// </summary>
		public bool IsDelete { get; set; }
		
		/// <summary>
        /// StaffId
        /// </summary>
		public int StaffId { get; set; }
		
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