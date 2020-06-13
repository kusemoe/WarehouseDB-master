using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class BillBll
    {
        BillDal dal = new BillDal();
        public List<Bill> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(Bill t)
        {
            return dal.Remove(t);
        }
        public int Add(Bill bill)
        {
            return dal.Add(bill);
        }
        public List<GetTypeAndMoney> Select()
        {
            var linq = dal.SelectList()
                .GroupBy(i => i.product.type.typeName)
                .Select(i => new GetTypeAndMoney
                {
                    type = i.Key,
                    money = i.Sum(j => j.product.money * j.BillNum),
                });
            return linq.ToList();
        }
    }
}
