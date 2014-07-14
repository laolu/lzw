using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// CheckContent
    /// </summary>
	public class CheckContentDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// WorkToDoID
        /// </summary>
		public int WorkToDoID { get; set; }
		
		/// <summary>
        /// StaffID
        /// </summary>
		public int StaffID { get; set; }
		
		/// <summary>
        /// Content
        /// </summary>
		public string Content { get; set; }
		
		/// <summary>
        /// CheckType
        /// </summary>
		public int CheckType { get; set; }
		
		/// <summary>
        /// NodeNumber
        /// </summary>
		public int NodeNumber { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}