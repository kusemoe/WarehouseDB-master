﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class ProductDal : DBHelper<product>
    {
        WarehouseDBEntities entities = new WarehouseDBEntities();

        public List<product> SelectProduct()
        {
            return base.SelectList().ToList();
        }
    }
}
