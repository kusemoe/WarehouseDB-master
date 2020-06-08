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
        public int Remove(Order t)
        {
            return dal.Remove(t);
        }
        public int Add(Order order)
        {
            return dal.Add(order);
        }
    }
}
