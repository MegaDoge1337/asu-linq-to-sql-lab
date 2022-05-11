using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Task62Table : Form
    {
        private SqlClient.SqlClient _client;
        public Task62Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;
        }
    }
}
