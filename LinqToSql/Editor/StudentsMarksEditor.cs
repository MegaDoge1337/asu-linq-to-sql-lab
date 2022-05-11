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
    public partial class StudentsMarksEditor : Form
    {
        private SchoolRoutineRepository _repository;

        public StudentsMarksEditor(SchoolRoutineRepository repository)
        {
            InitializeComponent();

            this._repository = repository;

            dataGridView2.Rows.Add("Предмет");
            dataGridView2.Rows.Add("Фамилия");
            dataGridView2.Rows.Add("Инициалы");
            dataGridView2.Rows.Add("Оценка");
            dataGridView2.Rows.Add("Класс");

            dataGridView3.Rows.Add("Предмет");
            dataGridView3.Rows.Add("Фамилия");
            dataGridView3.Rows.Add("Инициалы");
            dataGridView3.Rows.Add("Оценка");
            dataGridView3.Rows.Add("Класс");
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var data = _repository.GetStudentsMarks();

            dataGridView1.Rows.Clear();

            foreach (var element in data) 
            {
                dataGridView1.Rows.Add(element.ID, element.Lesson, element.Surname, element.Initials, element.Mark, element.Class);
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

            var entity = new SqlClient.Entities.StudentMark(
                    -1,
                    data[0],
                    data[1],
                    data[2],
                    Convert.ToInt32(data[3]),
                    Convert.ToInt32(data[4])
                );

            this._repository.AddStudentMark(entity);

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

            var studentMark = this._repository.GetStudentMarkById(id);

            if (studentMark == null) 
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            GetByIdBtn.Enabled = false;
            textBox1.Enabled = false;
            AcceptBtn.Enabled = true;

            dataGridView3.Rows[0].Cells["EditedValue"].Value = studentMark.Lesson;
            dataGridView3.Rows[1].Cells["EditedValue"].Value = studentMark.Surname;
            dataGridView3.Rows[2].Cells["EditedValue"].Value = studentMark.Initials;
            dataGridView3.Rows[3].Cells["EditedValue"].Value = studentMark.Mark.ToString();
            dataGridView3.Rows[4].Cells["EditedValue"].Value = studentMark.Class.ToString();
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

            var entity = new SqlClient.Entities.StudentMark(
                    Convert.ToInt32(textBox1.Text),
                    data[0],
                    data[1],
                    data[2],
                    Convert.ToInt32(data[3]),
                    Convert.ToInt32(data[4])
                );

            this._repository.UpdateStudentMark(entity);

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
            this._repository.DeleteStudentMark(id);
            textBox2.Text = "";
        }
    }
}
