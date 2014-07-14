using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OfficialSealApplication
    /// </summary>
	public class OfficialSealApplicationDto
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
        /// TypeList
        /// </summary>
		public string TypeList { get; set; }
		
		/// <summary>
        /// CompanyList
        /// </summary>
		public string CompanyList { get; set; }
		
		/// <summary>
        /// Remark
        /// </summary>
		public string Remark { get; set; }
		
		/// <summary>
        /// IsDelete
        /// </summary>
		public bool IsDelete { get; set; }
		
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