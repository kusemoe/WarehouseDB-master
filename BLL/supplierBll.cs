using DAL;
using Model;
using System;
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
        public int Remove(supplier t, out string error)
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
        public int Add(supplier supplier)
        {
            return dal.Add(supplier);
        }
    }
}
