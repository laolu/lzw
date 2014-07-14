using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// WorkLog
    /// </summary>
	public class WorkLogDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// LogDate
        /// </summary>
		public DateTime LogDate { get; set; }
		
		/// <summary>
        /// Title
        /// </summary>
		public string Title { get; set; }
		
		/// <summary>
        /// Remark
        /// </summary>
		public string Remark { get; set; }
		
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