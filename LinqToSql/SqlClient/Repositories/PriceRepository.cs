using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Repositories
{
    public class PriceRepository
    {
        private SqlClient _client;
        private QueryBuilder _qb;
        private string _tableName;

        public PriceRepository(SqlClient client) 
        {
            this._client = client;
            this._qb = new QueryBuilder();
            this._tableName = "Prices";
        }

        public List<Entities.Price> GetPrices() 
        {
            var prices = new List<Entities.Price>();

            var query = this._qb.BuildSelectAllQuery(this._tableName);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null) 
            {
                while (reader.Read())
                {
                    var price = new Entities.Price (
                        Convert.ToInt32(reader.GetValue(0)),
                        Convert.ToInt32(reader.GetValue(1)),
                        Convert.ToString(reader.GetValue(2)),
                        Convert.ToString(reader.GetValue(3))
                    );

                    prices.Add(price);
                }

                reader.Close();
            }

            return prices;
        }

        public Entities.Price GetPriceById(int id)
        {
            Entities.Price price = null;

            var query = this._qb.BuildSelectByIdQuery(this._tableName, id);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null)
            {
                reader.Read();

                price = new Entities.Price (
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToInt32(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2)),
                    Convert.ToString(reader.GetValue(3))
                );

                reader.Close();
            }

            return price;
        }

        public int AddPrice(Entities.Price price)
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("pricevalue", price.PriceValue.ToString());
            fieldsAndValues.Add("shoptitle", price.ShopTitle);
            fieldsAndValues.Add("productarticlenumber", price.ProductArticleNumber);

            var query = this._qb.BuildInsertQuery(this._tableName, fieldsAndValues);

            var execResult = this._client.ExecuteInsert(query);
            return execResult;
        }

        public int UpdatePrice(Entities.Price price) 
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("pricevalue", price.PriceValue.ToString());
            fieldsAndValues.Add("shoptitle", price.ShopTitle);
            fieldsAndValues.Add("productarticlenumber", price.ProductArticleNumber);

            var id = price.ID;

            var query = this._qb.BuildUpdateByIdQuery(this._tableName, fieldsAndValues, id);
            var execResult = this._client.ExecuteUpdate(query);
            return execResult;
        }

        public int DeletePrice(int id) 
        {
            var query = this._qb.BuildDeleteByIdQuery(this._tableName, id);
            var execResult = this._client.ExecuteDelete(query);
            return execResult;
        }
    }
}
