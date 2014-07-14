using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// OilCard
    /// </summary>
	public class OilCardDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// CardNo
        /// </summary>
		public string CardNo { get; set; }
		
		/// <summary>
        /// CarNo
        /// </summary>
		public string CarNo { get; set; }
		
		/// <summary>
        /// CardType
        /// </summary>
		public int CardType { get; set; }
		
		/// <summary>
        /// Amount
        /// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
        /// Status
        /// </summary>
		public bool Status { get; set; }
		
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