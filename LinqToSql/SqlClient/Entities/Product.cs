using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Entities
{
    public class Product
    {
        public int ID;
        public string Category;
        public string MadeInCountry;
        public string ProductArticleNumber;

        public Product(int id, string category, string madeInCountry, string productArticleNumber) 
        {
            this.ID = id;
            this.Category = category;
            this.MadeInCountry = madeInCountry;
            this.ProductArticleNumber = productArticleNumber;
        }
    }
}
