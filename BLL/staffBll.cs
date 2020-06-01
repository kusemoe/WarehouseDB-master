using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class staffBll
    {
        staffDal dal = new staffDal();
        public List<Model.staff> SelectList() => dal.SelectList().ToList();
        public int Remove(staff t)
        {
            return dal.Remove(t);
        }
    }
}
