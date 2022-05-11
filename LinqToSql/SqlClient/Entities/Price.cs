using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Entities
{
    public class Price
    {
        public int ID;
        public int PriceValue;
        public string ShopTitle;
        public string ProductArticleNumber;

        public Price(int id, int priceValue, string shopTitle, string productArticleNumber) 
        {
            this.ID = id;
            this.PriceValue = priceValue;
            this.ShopTitle = shopTitle;
            this.ProductArticleNumber = productArticleNumber;
        }
    }
}
