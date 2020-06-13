using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class DepotBll
    {
        DepotDal dal = new DepotDal();
        public List<depot> SelectList()
        {
            return dal.SelectList().ToList();
        }
        public int Remove(depot t)
        {
            return dal.Remove(t);
        }
        public int Add(depot depot)
        {
            return dal.Add(depot);
        }
        /// <summary>
        /// 更新仓库
        /// </summary>
        /// <param name="id">商品编号</param>
        /// <param name="num">库存数量</param>
        /// <param name="flag">进出库</param>
        /// <returns></returns>
        public int Update(int id, int num, bool flag)
        {
            var depot = dal.FindList(i => i.ProductId == id);
            //没有找到商品
            //就添加商品
            if (depot.Count() == 0)
            {
                return dal.Add(new depot
                {
                    ProductId = id,
                    stock = num
                });
            }
            else
            {
                _ = flag ? depot.First().stock += num : depot.First().stock -= num;
                if (depot.First().stock == 0)
                {
                    return dal.Remove(depot.First());
                }
                return dal.Update(depot.First());
            }
        }

    }
}
