using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PurchaseDal : DBHelper<Purchase>
    {
        public new int Add(Purchase purchase)
        {
            purchase.PurchaseTime = DateTime.Now;
            return base.Add(purchase);
        }

    }
}
