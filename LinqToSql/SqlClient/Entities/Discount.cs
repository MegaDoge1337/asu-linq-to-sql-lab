using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Entities
{
    public class Discount
    {
        public int ID;
        public int DiscountValue;
        public string CustomerCode;
        public string ShopTitle;

        public Discount(int id, int discountValue, string customerCode, string shopTitle) 
        {
            this.ID = id;
            this.DiscountValue = discountValue;
            this.CustomerCode = customerCode;
            this.ShopTitle = shopTitle;
        }
    }
}
