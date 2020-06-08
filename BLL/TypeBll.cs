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
        public int Remove(type t,out string error)
        {
            try
            {
                error = "删除成功";
                return dal.Remove(t);
            }
            catch (Exception)
            {
                error = "对应外键数据不能直接删除";
            }
            return 0;
        }
        public int Add(Model.type type)
        {
            return dal.Add(type);
        }
    }
}
