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
    }
}
