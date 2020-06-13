using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShippingDal : DBHelper<Shipping>
    {
        public new int Add(Shipping shipping)
        {
            return base.Add(shipping);
        }
    }
}
