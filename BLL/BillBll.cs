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
    }
}
