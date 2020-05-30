using DAL;
using Model;
using System.Collections.Generic;
namespace BLL
{
    public class ProductBll
    {
        ProductDal dal = new ProductDal();
        public List<product> SelectProduct() => dal.SelectProduct();
    }
}
