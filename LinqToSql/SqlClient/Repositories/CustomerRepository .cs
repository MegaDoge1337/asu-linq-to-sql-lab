using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Repositories
{
    public class CustomerRepository
    {
        private SqlClient _client;
        private QueryBuilder _qb;
        private string _tableName;

        public CustomerRepository(SqlClient client) 
        {
            this._client = client;
            this._qb = new QueryBuilder();
            this._tableName = "Customers";
        }

        public List<Entities.Customer> GetCustomers() 
        {
            var customers = new List<Entities.Customer>();

            var query = this._qb.BuildSelectAllQuery(this._tableName);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null) 
            {
                while (reader.Read())
                {
                    var customer = new Entities.Customer (
                        Convert.ToInt32(reader.GetValue(0)),
                        Convert.ToString(reader.GetValue(1)),
                        Convert.ToString(reader.GetValue(2)),
                        Convert.ToInt32(reader.GetValue(3))
                    );

                    customers.Add(customer);
                }

                reader.Close();
            }

            return customers;
        }

        public Entities.Customer GetCustomerById(int id)
        {
            Entities.Customer customer = null;

            var query = this._qb.BuildSelectByIdQuery(this._tableName, id);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null)
            {
                reader.Read();

                customer = new Entities.Customer (
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToString(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2)),
                    Convert.ToInt32(reader.GetValue(3))
                );

                reader.Close();
            }

            return customer;
        }

        public int AddCustomer(Entities.Customer customer)
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("customercode", customer.CustomerCode);
            fieldsAndValues.Add("street", customer.Street);
            fieldsAndValues.Add("birthyear", customer.BirthYear.ToString());

            var query = this._qb.BuildInsertQuery(this._tableName, fieldsAndValues);

            var execResult = this._client.ExecuteInsert(query);
            return execResult;
        }

        public int UpdateCustomer(Entities.Customer customer) 
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("customercode", customer.CustomerCode);
            fieldsAndValues.Add("street", customer.Street);
            fieldsAndValues.Add("birthyear", customer.BirthYear.ToString());

            var id = customer.ID;

            var query = this._qb.BuildUpdateByIdQuery(this._tableName, fieldsAndValues, id);
            var execResult = this._client.ExecuteUpdate(query);
            return execResult;
        }

        public int DeleteCustomer(int id) 
        {
            var query = this._qb.BuildDeleteByIdQuery(this._tableName, id);
            var execResult = this._client.ExecuteDelete(query);
            return execResult;
        }
    }
}
