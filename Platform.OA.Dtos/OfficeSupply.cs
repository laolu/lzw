using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OfficeSupply
    /// </summary>
	public class OfficeSupplyDto
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
        /// Brand
        /// </summary>
		public string Brand { get; set; }
		
		/// <summary>
        /// OfficeSupplyType
        /// </summary>
		public string OfficeSupplyType { get; set; }
		
		/// <summary>
        /// Unit
        /// </summary>
		public string Unit { get; set; }
		
		/// <summary>
        /// Stock
        /// </summary>
		public int Stock { get; set; }
		
		/// <summary>
        /// Price
        /// </summary>
		public decimal Price { get; set; }
		
		/// <summary>
        /// IsActive
        /// </summary>
		public bool IsActive { get; set; }
		
		/// <summary>
        /// StaffID
        /// </summary>
		public int StaffID { get; set; }
		
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