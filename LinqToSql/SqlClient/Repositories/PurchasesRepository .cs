using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Repositories
{
    public class PurchasesRepository
    {
        private SqlClient _client;
        private QueryBuilder _qb;
        private string _tableName;

        public PurchasesRepository(SqlClient client) 
        {
            this._client = client;
            this._qb = new QueryBuilder();
            this._tableName = "Purchases";
        }

        public List<Entities.Purchase> GetPurchases() 
        {
            var purchases = new List<Entities.Purchase>();

            var query = this._qb.BuildSelectAllQuery(this._tableName);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null) 
            {
                while (reader.Read())
                {
                    var purchase = new Entities.Purchase (
                        Convert.ToInt32(reader.GetValue(0)),
                        Convert.ToString(reader.GetValue(1)),
                        Convert.ToString(reader.GetValue(2)),
                        Convert.ToString(reader.GetValue(3))
                    );

                    purchases.Add(purchase);
                }

                reader.Close();
            }

            return purchases;
        }

        public Entities.Purchase GetPurchaseById(int id)
        {
            Entities.Purchase purchase = null;

            var query = this._qb.BuildSelectByIdQuery(this._tableName, id);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null)
            {
                reader.Read();

                purchase = new Entities.Purchase (
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToString(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2)),
                    Convert.ToString(reader.GetValue(3))
                );

                reader.Close();
            }

            return purchase;
        }

        public int AddPurchase(Entities.Purchase purchase)
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("customercode", purchase.CustomerCode);
            fieldsAndValues.Add("productarticlenumber", purchase.ProductArticleNumber);
            fieldsAndValues.Add("shoptitle", purchase.ShopTitle);

            var query = this._qb.BuildInsertQuery(this._tableName, fieldsAndValues);

            var execResult = this._client.ExecuteInsert(query);
            return execResult;
        }

        public int UpdatePurchase(Entities.Purchase purchase) 
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("customercode", purchase.CustomerCode);
            fieldsAndValues.Add("productarticlenumber", purchase.ProductArticleNumber);
            fieldsAndValues.Add("shoptitle", purchase.ShopTitle);

            var id = purchase.ID;

            var query = this._qb.BuildUpdateByIdQuery(this._tableName, fieldsAndValues, id);
            var execResult = this._client.ExecuteUpdate(query);
            return execResult;
        }

        public int DeletePurchase(int id) 
        {
            var query = this._qb.BuildDeleteByIdQuery(this._tableName, id);
            var execResult = this._client.ExecuteDelete(query);
            return execResult;
        }
    }
}
