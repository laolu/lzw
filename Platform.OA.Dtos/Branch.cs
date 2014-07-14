using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// Branch
    /// </summary>
	public class BranchDto
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
        /// Desc
        /// </summary>
		public string Desc { get; set; }
		
		/// <summary>
        /// ParentId
        /// </summary>
		public int ParentId { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }	
	}
}