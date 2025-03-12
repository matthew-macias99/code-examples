using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public Movie Movie { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public bool ProcessPurchase()
        {
            return true;
        }
    }
}
