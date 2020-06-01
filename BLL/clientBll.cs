using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class clientBll
    {
        clientDal dal = new clientDal();
        public List<client> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(client t)
        {
            return dal.Remove(t);
        }
    }
}
