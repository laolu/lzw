using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// WorkFlowEntry
    /// </summary>
	public class WorkFlowEntryDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// WorkFlowID
        /// </summary>
		public int WorkFlowID { get; set; }
		
		/// <summary>
        /// NoteSerils
        /// </summary>
		public int NoteSerils { get; set; }
		
		/// <summary>
        /// PositionID
        /// </summary>
		public int PositionID { get; set; }
		
		/// <summary>
        /// BranchID
        /// </summary>
		public int BranchID { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}