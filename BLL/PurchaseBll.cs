using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class PurchaseBll
    {
        PurchaseDal dal = new PurchaseDal();
        public List<Purchase> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(Purchase t)
        {
            return dal.Remove(t);
        }
    }
}
