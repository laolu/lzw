using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// RepairSys
    /// </summary>
	public class RepairSysDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// RequirePeople
        /// </summary>
		public string RequirePeople { get; set; }
		
		/// <summary>
        /// BranchName
        /// </summary>
		public string BranchName { get; set; }
		
		/// <summary>
        /// RequireType
        /// </summary>
		public int RequireType { get; set; }
		
		/// <summary>
        /// RequireContent
        /// </summary>
		public string RequireContent { get; set; }
		
		/// <summary>
        /// priority
        /// </summary>
		public int priority { get; set; }
		
		/// <summary>
        /// StaffID
        /// </summary>
		public int StaffID { get; set; }
		
		/// <summary>
        /// DealDate
        /// </summary>
		public string DealDate { get; set; }
		
		/// <summary>
        /// note
        /// </summary>
		public string note { get; set; }
		
		/// <summary>
        /// Status
        /// </summary>
		public int Status { get; set; }
		
		/// <summary>
        /// attachment
        /// </summary>
		public string attachment { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}