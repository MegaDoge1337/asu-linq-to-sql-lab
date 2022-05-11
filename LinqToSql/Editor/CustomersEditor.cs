using LinqToSql.SqlClient.Repositories;
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
    public partial class CustomersEditor : Form
    {
        private CustomerRepository _repository;

        public CustomersEditor(CustomerRepository repository)
        {
            InitializeComponent();

            this._repository = repository;

            dataGridView2.Rows.Add("Код потребителя");
            dataGridView2.Rows.Add("Улица проживания");
            dataGridView2.Rows.Add("Год рождения");

            dataGridView3.Rows.Add("Код потребителя");
            dataGridView3.Rows.Add("Улица проживания");
            dataGridView3.Rows.Add("Год рождения");
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var data = _repository.GetCustomers();

            dataGridView1.Rows.Clear();

            foreach (var element in data) 
            {
                dataGridView1.Rows.Add(element.ID, element.CustomerCode, element.Street, element.BirthYear);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            var data = new List<string>();

            foreach (DataGridViewRow row in dataGridView2.Rows) 
            {
                var value = row.Cells["Value"].Value.ToString();

                if (string.IsNullOrWhiteSpace(value)) 
                {
                    MessageBox.Show("Поля не должны быть пустыми");
                    return;
                }

                data.Add(value);
            }

            var entity = new SqlClient.Entities.Customer(
                    -1,
                    data[0],
                    data[1],
                    Convert.ToInt32(data[2])
                );

            this._repository.AddCustomer(entity);

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["Value"].Value = null;
            }
        }

        private void GetByIdBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox1.Text);

            if (id < 0) 
            {
                MessageBox.Show("ИД не может быть отрицательным");
                return;
            }

            var customer = this._repository.GetCustomerById(id);

            if (customer == null) 
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            GetByIdBtn.Enabled = false;
            textBox1.Enabled = false;
            AcceptBtn.Enabled = true;

            dataGridView3.Rows[0].Cells["EditedValue"].Value = customer.CustomerCode;
            dataGridView3.Rows[1].Cells["EditedValue"].Value = customer.Street;
            dataGridView3.Rows[2].Cells["EditedValue"].Value = customer.BirthYear.ToString();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            var data = new List<string>();

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                var value = row.Cells["EditedValue"].Value.ToString();

                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Поля не должны быть пустыми");
                    return;
                }

                data.Add(value);
            }

            var entity = new SqlClient.Entities.Customer(
                    Convert.ToInt32(textBox1.Text),
                    data[0],
                    data[1],
                    Convert.ToInt32(data[2])
                );

            this._repository.UpdateCustomer(entity);

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.Cells["EditedValue"].Value = null;
            }

            AcceptBtn.Enabled = false;
            textBox1.Enabled = true;
            textBox1.Text = "";
            GetByIdBtn.Enabled = true;
        }

        private void DeleteByIdBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox2.Text);
            this._repository.DeleteCustomer(id);
            textBox2.Text = "";
        }
    }
}
