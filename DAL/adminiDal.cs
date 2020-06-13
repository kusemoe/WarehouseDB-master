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
        public admini AdminiLogin(admini admini, out string text)
        {
            text = "登录成功";
            var listByName = entities.admini.Where(ad => ad.adminiName == admini.adminiName).ToList();
            if (listByName.Count <= 0)
            {
                text = "用户名不存在";
                return null;
            }
            var listByPassWord = listByName.Where(ad => ad.adminiPassword == admini.adminiPassword).ToList();
            if (listByPassWord.Count <= 0)
            {
                text = "密码错误,请重新输入密码";
                return null;
            }
            return listByPassWord.FirstOrDefault();
        }
    }
}
