using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class ProductDal
    {
        WarehouseDBEntities entities = new WarehouseDBEntities();
        public List<product> SelectProduct()
        {
            return entities.product.ToList();
        }
    }
}
