using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class TypeBll
    {
        TypeDal dal = new TypeDal();
        public List<type> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(type t)
        {
            return dal.Remove(t);
        }
    }
}
