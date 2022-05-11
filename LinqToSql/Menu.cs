using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToSql.SqlClient.Repositories;

namespace LinqToSql
{
    public partial class Menu : Form
    {
        private SqlClient.SqlClient _client;

        public Menu()
        {
            InitializeComponent();
            this._client = new SqlClient.SqlClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableMenu();

            var connection = this._client.Connect();

            if (connection == null)
            {
                DbConnectionIndicartor.Text = "Не удалось подключиться к базе данных";
                DbConnectionIndicartor.BackColor = Color.Red;
                DbConnectionIndicartor.ForeColor = Color.White;
            }
            else
            {
                EnableMenu();

                DbConnectionIndicartor.Text = "Соединение установлено";
                DbConnectionIndicartor.BackColor = Color.Green;
                DbConnectionIndicartor.ForeColor = Color.White;
            }
        }

        private void DisableMenu() 
        {
            Task1Btn.Enabled = false;
            Task21Btn.Enabled = false;
            Task22Btn.Enabled = false;
            Task3Btn.Enabled = false;
            Task5Btn.Enabled = false;
            OpenStudentsMarksTableBtn.Enabled = false;
            OpenCustomersTableBtn.Enabled = false;
            OpenDiscountsTableBtn.Enabled = false;
            OpenProductsTableBtn.Enabled = false;
            OpenPurchasesTableBtn.Enabled = false;
            OpenPricesTableBtn.Enabled = false;
        }

        private void EnableMenu() 
        {
            Task1Btn.Enabled = true;
            Task21Btn.Enabled = true;
            Task22Btn.Enabled = true;
            Task3Btn.Enabled = true;
            Task5Btn.Enabled = true;
            OpenStudentsMarksTableBtn.Enabled = true;
            OpenCustomersTableBtn.Enabled = true;
            OpenDiscountsTableBtn.Enabled = true;
            OpenProductsTableBtn.Enabled = true;
            OpenPurchasesTableBtn.Enabled = true;
            OpenPricesTableBtn.Enabled = true;
        }

        private void OpenStudentsMarksTableBtn_Click(object sender, EventArgs e)
        {
            new Editor.StudentsMarksEditor(new SchoolRoutineRepository(this._client)).ShowDialog();
        }

        private void Task1Btn_Click(object sender, EventArgs e)
        {
            new Task1Table(this._client).ShowDialog();
        }

        private void OpenCustomersTableBtn_Click(object sender, EventArgs e)
        {
            new Editor.CustomersEditor(new CustomerRepository(this._client)).ShowDialog();
        }

        private void OpenDiscountsTableBtn_Click(object sender, EventArgs e)
        {
            new Editor.DiscountsEditor(new DiscountRepository(this._client)).ShowDialog();
        }

        private void OpenProductsTableBtn_Click(object sender, EventArgs e)
        {
            new Editor.ProductsEditor(new ProductRepository(this._client)).ShowDialog();
        }

        private void OpenPurchasesTableBtn_Click(object sender, EventArgs e)
        {
            new Editor.PurchasesEditor(new PurchasesRepository(this._client)).ShowDialog();
        }

        private void OpenPricesTableBtn_Click(object sender, EventArgs e)
        {
            new Editor.PricesEditor(new PriceRepository(this._client)).ShowDialog();
        }

        private void Task21Btn_Click(object sender, EventArgs e)
        {
            new Task21Table(this._client).ShowDialog();
        }

        private void Task22Btn_Click(object sender, EventArgs e)
        {
            new Task22Table(this._client).ShowDialog();
        }

        private void Task3Btn_Click(object sender, EventArgs e)
        {
            new Task3Table(this._client).ShowDialog();
        }

        private void Task5Btn_Click(object sender, EventArgs e)
        {
            new Task5Table(this._client).ShowDialog();
        }
    }
}
