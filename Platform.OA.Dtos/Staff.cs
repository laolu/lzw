using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// Staff
    /// </summary>
	public class StaffDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// LoginName
        /// </summary>
		public string LoginName { get; set; }
		
		/// <summary>
        /// Name
        /// </summary>
		public string Name { get; set; }
		
		/// <summary>
        /// CoverPicture
        /// </summary>
		public string CoverPicture { get; set; }
		
		/// <summary>
        /// Gender
        /// </summary>
		public int Gender { get; set; }
		
		/// <summary>
        /// PositionID
        /// </summary>
		public int PositionID { get; set; }
		
		/// <summary>
        /// BirthDate
        /// </summary>
		public DateTime BirthDate { get; set; }
		
		/// <summary>
        /// Tel
        /// </summary>
		public string Tel { get; set; }
		
		/// <summary>
        /// Email
        /// </summary>
		public string Email { get; set; }
		
		/// <summary>
        /// Address
        /// </summary>
		public string Address { get; set; }
		
		/// <summary>
        /// BranchId
        /// </summary>
		public int BranchId { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}