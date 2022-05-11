using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql.Editor
{
    public partial class Editor : Form
    {
        private string _tableName;
        private List<string> _tableFields;

        private SqlClient.SqlClient _client;

        public Editor(string tableName, List<string> tableFields, SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._tableName = tableName;
            this._tableFields = tableFields;

            this._client = client;
        }
    }
}
