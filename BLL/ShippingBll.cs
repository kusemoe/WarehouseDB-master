﻿using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ShippingBll
    {
        ShippingDal dal = new ShippingDal();
        public List<Shipping> SelectList()
        {
            return dal.SelectList().ToList();
        }
    }
}
