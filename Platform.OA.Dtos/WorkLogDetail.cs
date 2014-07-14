using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// WorkLogDetail
    /// </summary>
	public class WorkLogDetailDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// WorkLogId
        /// </summary>
		public int WorkLogId { get; set; }
		
		/// <summary>
        /// LogTime
        /// </summary>
		public DateTime LogTime { get; set; }
		
		/// <summary>
        /// LogTimeDesc
        /// </summary>
		public string LogTimeDesc { get; set; }
		
		/// <summary>
        /// LogItem
        /// </summary>
		public string LogItem { get; set; }
		
		/// <summary>
        /// LogContent
        /// </summary>
		public string LogContent { get; set; }
		
		/// <summary>
        /// LogRemark
        /// </summary>
		public string LogRemark { get; set; }
		
		/// <summary>
        /// CreateByUserId
        /// </summary>
		public int CreateByUserId { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}