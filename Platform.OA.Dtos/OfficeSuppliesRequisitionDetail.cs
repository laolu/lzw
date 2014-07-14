using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OfficeSuppliesRequisitionDetail
    /// </summary>
	public class OfficeSuppliesRequisitionDetailDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// OfficeSuppliesRequisitionID
        /// </summary>
		public int OfficeSuppliesRequisitionID { get; set; }
		
		/// <summary>
        /// OfficeSupplyID
        /// </summary>
		public int OfficeSupplyID { get; set; }
		
		/// <summary>
        /// Num
        /// </summary>
		public int Num { get; set; }
		
		/// <summary>
        /// Price
        /// </summary>
		public decimal Price { get; set; }
		
		/// <summary>
        /// OutDate
        /// </summary>
		public DateTime OutDate { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}