﻿using System;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_OrderForm
    {
        private DAL_OrderForm orderform;
        public BUS_OrderForm()
        {
            orderform = new DAL_OrderForm("", "", "", "", "");
        }
        public BUS_OrderForm(string id, string address, string statusPayment, string status, string delivery)
        {
            orderform = new DAL_OrderForm(id, address, statusPayment, status, delivery);
        }
        public void addQuery()
        {
            orderform.addQuery();
        }

        public DataTable selectQuery()
        {
            return orderform.selectQuery();
        }

        // select by OrderID
        public DataTable selectByOrderID(string orderID)
        {
            return orderform.selectByOrderID(orderID);
        }
        //Detail of Order
        public DataTable selectQueryID(string id)
        {
            return orderform.selectQueryID(id);
        }

        public DataTable selectQueryGoodsOut()
        {
            return orderform.selectQueryGoodsOut();
        }
    }
}
