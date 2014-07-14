using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// Notice
    /// </summary>
	public class NoticeDto
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
        /// Content
        /// </summary>
		public string Content { get; set; }
		
		/// <summary>
        /// BranchId
        /// </summary>
		public int BranchId { get; set; }
		
		/// <summary>
        /// IsActive
        /// </summary>
		public bool IsActive { get; set; }
		
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