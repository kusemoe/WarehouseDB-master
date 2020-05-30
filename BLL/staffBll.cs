using DAL;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class staffBll
    {
        staffDal dal = new staffDal();
        public List<Model.staff> SelectList() => dal.SelectList().ToList();
    }
}
