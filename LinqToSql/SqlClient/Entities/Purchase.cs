using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Entities
{
    public class Purchase
    {
        public int ID;
        public string CustomerCode;
        public string ProductArticleNumber;
        public string ShopTitle;

        public Purchase(int id, string customerCode, string productArticleNumber, string ShopTitle) 
        {
            this.ID = id;
            this.CustomerCode = customerCode;
            this.ProductArticleNumber = productArticleNumber;
            this.ShopTitle = ShopTitle;
        }
    }
}
