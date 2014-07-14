using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// WorkToDo
    /// </summary>
	public class WorkToDoDto
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
        /// WorkFlowID
        /// </summary>
		public int WorkFlowID { get; set; }
		
		/// <summary>
        /// StaffID
        /// </summary>
		public int StaffID { get; set; }
		
		/// <summary>
        /// FuJianList
        /// </summary>
		public string FuJianList { get; set; }
		
		/// <summary>
        /// StateNow
        /// </summary>
		public int StateNow { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}