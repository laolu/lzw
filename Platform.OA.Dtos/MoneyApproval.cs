using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Platform.OA.Dtos
{
	/// <summary>
    /// MoneyApproval
    /// </summary>
	public class MoneyApprovalDto
	{
		/// <summary>
        /// ID
        /// </summary>
		public int ID { get; set; }
		
		/// <summary>
        /// WorkToDoid
        /// </summary>
		public int WorkToDoid { get; set; }
		
		/// <summary>
        /// BranchID
        /// </summary>
		public int BranchID { get; set; }
		
		/// <summary>
        /// recCompany
        /// </summary>
		public string recCompany { get; set; }
		
		/// <summary>
        /// BankName
        /// </summary>
		public string BankName { get; set; }
		
		/// <summary>
        /// BankAccount
        /// </summary>
		public string BankAccount { get; set; }
		
		/// <summary>
        /// amount
        /// </summary>
		public decimal amount { get; set; }
		
		/// <summary>
        /// payType
        /// </summary>
		public string payType { get; set; }
		
		/// <summary>
        /// note
        /// </summary>
		public string note { get; set; }
		
		/// <summary>
        /// CreateTime
        /// </summary>
		public DateTime CreateTime { get; set; }
		
				
	}
}