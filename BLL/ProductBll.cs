using DAL;
using Model;
using System;
using System.Collections.Generic;
namespace BLL
{
    public class ProductBll
    {
        ProductDal dal = new ProductDal();
        public List<product> SelectProduct() => dal.SelectProduct();
        public int Remove(product t, out string error)
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
        public int Add(product product)
        {
            return dal.Add(product);
        }
    }
}
