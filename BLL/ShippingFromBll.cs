using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class ShippingFromBll
    {
        ShippingFromDal dal = new ShippingFromDal();
        public List<ShippingFrom> SelectList() => dal.SelectList().ToList();
    }
}
