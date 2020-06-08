using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class AdminiBll
    {
        AdminiDal dal = new AdminiDal();
        public admini AdminiLogin(admini admini) => dal.AdminiLogin(admini);
        public List<admini> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(admini t)
        {
            return dal.Remove(t);
        }
        public int Add(admini d)
        {
            return dal.Add(d);
        }
    }
}
