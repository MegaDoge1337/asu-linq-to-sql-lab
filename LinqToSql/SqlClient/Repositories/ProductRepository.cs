using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Repositories
{
    public class ProductRepository
    {
        private SqlClient _client;
        private QueryBuilder _qb;
        private string _tableName;

        public ProductRepository(SqlClient client) 
        {
            this._client = client;
            this._qb = new QueryBuilder();
            this._tableName = "Products";
        }

        public List<Entities.Product> GetProducts() 
        {
            var products = new List<Entities.Product>();

            var query = this._qb.BuildSelectAllQuery(this._tableName);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null) 
            {
                while (reader.Read())
                {
                    var product = new Entities.Product (
                        Convert.ToInt32(reader.GetValue(0)),
                        Convert.ToString(reader.GetValue(1)),
                        Convert.ToString(reader.GetValue(2)),
                        Convert.ToString(reader.GetValue(3))
                    );

                    products.Add(product);
                }

                reader.Close();
            }

            return products;
        }

        public Entities.Product GetProductById(int id)
        {
            Entities.Product product = null;

            var query = this._qb.BuildSelectByIdQuery(this._tableName, id);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null)
            {
                reader.Read();

                product = new Entities.Product (
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToString(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2)),
                    Convert.ToString(reader.GetValue(3))
                );

                reader.Close();
            }

            return product;
        }

        public int AddProduct(Entities.Product product)
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("category", product.Category);
            fieldsAndValues.Add("madeincountry", product.MadeInCountry);
            fieldsAndValues.Add("productarticlenumber", product.ProductArticleNumber);

            var query = this._qb.BuildInsertQuery(this._tableName, fieldsAndValues);

            var execResult = this._client.ExecuteInsert(query);
            return execResult;
        }

        public int UpdateProduct(Entities.Product product) 
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("category", product.Category);
            fieldsAndValues.Add("madeincountry", product.MadeInCountry);
            fieldsAndValues.Add("productarticlenumber", product.ProductArticleNumber);

            var id = product.ID;

            var query = this._qb.BuildUpdateByIdQuery(this._tableName, fieldsAndValues, id);
            var execResult = this._client.ExecuteUpdate(query);
            return execResult;
        }

        public int DeleteProduct(int id) 
        {
            var query = this._qb.BuildDeleteByIdQuery(this._tableName, id);
            var execResult = this._client.ExecuteDelete(query);
            return execResult;
        }
    }
}
