using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class supplierBll
    {
        supplierDal dal = new supplierDal();
        public List<supplier> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(supplier t)
        {
            return dal.Remove(t);
        }
        public int Add(supplier supplier)
        {
            return dal.Add(supplier);
        }
    }
}
