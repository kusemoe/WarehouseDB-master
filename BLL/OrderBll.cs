using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class OrderBll
    {
        OrderDal dal = new OrderDal();
        public List<Order> SelectList()
        {
            return dal.SelectList().ToList();
        }
    }
}
