using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.Models
{
    public class PaymentModel
    {
        [PrimaryKey, AutoIncrement]
        public int PaymentID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
       
    }
}
