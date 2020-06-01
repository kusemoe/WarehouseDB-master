using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class departmentBll
    {
        departmentDal dal = new departmentDal();
        public List<department> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(department t)
        {
            return dal.Remove(t);
        }
    }
}
