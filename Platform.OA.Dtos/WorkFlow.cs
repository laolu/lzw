using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// WorkFlow
    /// </summary>
	public class WorkFlowDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// WorkFlowName
        /// </summary>
		public string WorkFlowName { get; set; }
		
		/// <summary>
        /// TableName
        /// </summary>
		public string TableName { get; set; }
		
		/// <summary>
        /// TableUrl
        /// </summary>
		public string TableUrl { get; set; }
		
		/// <summary>
        /// Note
        /// </summary>
		public string Note { get; set; }
		
		/// <summary>
        /// IsActive
        /// </summary>
		public bool IsActive { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}