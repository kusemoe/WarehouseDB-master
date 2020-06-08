using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class AdminiDal : DBHelper<admini> 
    {
        WarehouseDBEntities entities = new WarehouseDBEntities();

        public admini AdminiLogin(admini admini)
        {
            return entities.admini.Where(ad => ad.adminiName == admini.adminiName && ad.adminiPassword == admini.adminiPassword).FirstOrDefault();
        }
        
    }
}
