using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient
{
    class QueryBuilder
    {
        public string BuildSelectAllQuery(string tableName) 
        {
            return string.Format("SELECT * FROM {0};", tableName);
        }

        public string BuildSelectByIdQuery(string tableName, int id) 
        {
            return string.Format("SELECT * FROM {0} WHERE id = {1};", tableName, id);
        }

        public string BuildInsertQuery(string tableName, Dictionary<string, string> fieldsAndValues) 
        {
            var firstQueryPart = "(";
            var secondQueryPart = "(";

            foreach (var pair in fieldsAndValues) 
            {
                firstQueryPart += string.Format("{0}, ", pair.Key);
                secondQueryPart += string.Format("'{0}', ", pair.Value);
            }

            firstQueryPart = firstQueryPart.Substring(0, firstQueryPart.Length - 2) + ")";
            secondQueryPart = secondQueryPart.Substring(0, secondQueryPart.Length - 2) + ")";

            return string.Format("INSERT INTO {0} {1} VALUES {2};", tableName, firstQueryPart, secondQueryPart);
        }

        public string BuildUpdateByIdQuery(string tableName, Dictionary<string, string> fieldsAndValues, int id) 
        {
            var query = string.Format("UPDATE {0} SET", tableName);

            foreach (var pair in fieldsAndValues) 
            {
                query += string.Format(" {0} = '{1}',", pair.Key, pair.Value);
            }

            query = query.Substring(0, query.Length - 1) + " WHERE id = " + id;

            return query;
        }

        public string BuildDeleteByIdQuery(string tableName, int id) 
        {
            return string.Format("DELETE FROM {0} WHERE id = {1};", tableName, id);
        }
    }
}
