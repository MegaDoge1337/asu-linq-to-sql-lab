using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Task1Table : Form
    {
        private SqlClient.SqlClient _client;
        private SqlClient.Repositories.SchoolRoutineRepository _repository;

        public Task1Table(SqlClient.SqlClient client)
        {
            InitializeComponent();

            this._client = client;
            this._repository = new SqlClient.Repositories.SchoolRoutineRepository(this._client);
        }

        private void Task1Table_Load(object sender, EventArgs e)
        {
            var marks = this._repository.GetStudentsMarks();

            foreach (var mark in marks) 
            {
                if (!comboBox1.Items.Contains(mark.Lesson)) 
                {
                    comboBox1.Items.Add(mark.Lesson);
                }
            }
        }

        private void GetTaskDataBtn_Click(object sender, EventArgs e)
        {
            var lesson = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(comboBox1.Text)) 
            {
                return;
            }

            var allMarks = this._repository.GetStudentsMarks();

            var classes = allMarks.Select(m => m.Class).Distinct().OrderBy(c => c);

            var targetMarks = allMarks.Where(m => m.Lesson == lesson);

            var groupedTargetData = targetMarks.GroupBy(m => m.Surname + " " + m.Initials).Where(g => !g.Any(gm => gm.Mark == 2) && (g.Average(gm => gm.Mark) >= 3.5));

            dataGridView1.Rows.Clear();

            foreach (var classnum in classes) 
            {
                dataGridView1.Rows.Add(classnum, groupedTargetData.Count(g => g.Any(gm => gm.Class == classnum)));
            } 
        }
    }
}
