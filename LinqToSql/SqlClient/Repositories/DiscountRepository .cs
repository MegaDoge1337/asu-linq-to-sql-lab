using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Repositories
{
    public class DiscountRepository
    {
        private SqlClient _client;
        private QueryBuilder _qb;
        private string _tableName;

        public DiscountRepository(SqlClient client) 
        {
            this._client = client;
            this._qb = new QueryBuilder();
            this._tableName = "Discounts";
        }

        public List<Entities.Discount> GetDiscounts() 
        {
            var discounts = new List<Entities.Discount>();

            var query = this._qb.BuildSelectAllQuery(this._tableName);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null) 
            {
                while (reader.Read())
                {
                    var discount = new Entities.Discount (
                        Convert.ToInt32(reader.GetValue(0)),
                        Convert.ToInt32(reader.GetValue(1)),
                        Convert.ToString(reader.GetValue(2)),
                        Convert.ToString(reader.GetValue(3))
                    );

                    discounts.Add(discount);
                }

                reader.Close();
            }

            return discounts;
        }

        public Entities.Discount GetDiscountById(int id)
        {
            Entities.Discount discount = null;

            var query = this._qb.BuildSelectByIdQuery(this._tableName, id);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null)
            {
                reader.Read();

                discount = new Entities.Discount (
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToInt32(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2)),
                    Convert.ToString(reader.GetValue(3))
                );

                reader.Close();
            }

            return discount;
        }

        public int AddDiscount(Entities.Discount discount)
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("discountvalue", discount.DiscountValue.ToString());
            fieldsAndValues.Add("customercode", discount.CustomerCode);
            fieldsAndValues.Add("shoptitle", discount.ShopTitle);

            var query = this._qb.BuildInsertQuery(this._tableName, fieldsAndValues);

            var execResult = this._client.ExecuteInsert(query);
            return execResult;
        }

        public int UpdateDiscount(Entities.Discount discount) 
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("discountvalue", discount.DiscountValue.ToString());
            fieldsAndValues.Add("customercode", discount.CustomerCode);
            fieldsAndValues.Add("shoptitle", discount.ShopTitle);

            var id = discount.ID;

            var query = this._qb.BuildUpdateByIdQuery(this._tableName, fieldsAndValues, id);
            var execResult = this._client.ExecuteUpdate(query);
            return execResult;
        }

        public int DeleteDiscount(int id) 
        {
            var query = this._qb.BuildDeleteByIdQuery(this._tableName, id);
            var execResult = this._client.ExecuteDelete(query);
            return execResult;
        }
    }
}
