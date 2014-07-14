using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// WorkFlowNodes
    /// </summary>
	public class WorkFlowNodesDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// Name
        /// </summary>
		public string Name { get; set; }
		
		/// <summary>
        /// NodeType
        /// </summary>
		public int NodeType { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}