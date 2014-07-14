using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OfficeSupplyInDetail
    /// </summary>
	public class OfficeSupplyInDetailDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// OfficeSupplyInID
        /// </summary>
		public int OfficeSupplyInID { get; set; }
		
		/// <summary>
        /// OfficeSupplyID
        /// </summary>
		public int OfficeSupplyID { get; set; }
		
		/// <summary>
        /// InDate
        /// </summary>
		public DateTime InDate { get; set; }
		
		/// <summary>
        /// Num
        /// </summary>
		public int Num { get; set; }
		
		/// <summary>
        /// Price
        /// </summary>
		public decimal Price { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}