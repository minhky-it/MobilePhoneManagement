﻿using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Products
    {
        private DTO_Products products;
        public DAL_Products(string iD, string vendorID, string name, string quantity, string type, string price, string color)
        {
            products = new DTO_Products(iD, vendorID, name, quantity, type, price, color);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Product VALUES('" + products.ID1 + "','" + products.VendorID + "','" +  products.Name + "'," + products.Quantity + ",'" + products.Type + "'," + products.Price + ",'" + products.Color + "')";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Product";
            return Connection.selectQuery(s);
        }

        // Select by vendorID
        public DataTable selectVendorId(string id)
        {
            string sql = string.Format("SELECT * FROM Product WHERE vendorID = '{0}'", id);
            return Connection.selectQuery(sql);
        }

        // Select by OrderID
        public DataTable selectOrderId(string id)
        {
            string sql = string.Format("SELECT P.* FROM Product P INNER JOIN DetailOrderForm D ON P.productID = D.productID WHERE D.orderID = '{0}'", id);
            return Connection.selectQuery(sql);
        }
    }
}
