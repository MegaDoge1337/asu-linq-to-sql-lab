using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Repositories
{
    public class SchoolRoutineRepository
    {
        private SqlClient _client;
        private QueryBuilder _qb;
        private string _tableName;

        public SchoolRoutineRepository(SqlClient client) 
        {
            this._client = client;
            this._qb = new QueryBuilder();
            this._tableName = "SchoolRoutine";
        }

        public List<Entities.StudentMark> GetStudentsMarks() 
        {
            var studentsMarks = new List<Entities.StudentMark>();

            var query = this._qb.BuildSelectAllQuery(this._tableName);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null) 
            {
                while (reader.Read())
                {
                    var studentMark = new Entities.StudentMark (
                        Convert.ToInt32(reader.GetValue(0)),
                        Convert.ToString(reader.GetValue(1)),
                        Convert.ToString(reader.GetValue(2)),
                        Convert.ToString(reader.GetValue(3)),
                        Convert.ToInt32(reader.GetValue(4)),
                        Convert.ToInt32(reader.GetValue(5))
                    );

                    studentsMarks.Add(studentMark);
                }

                reader.Close();
            }

            return studentsMarks;
        }

        public Entities.StudentMark GetStudentMarkById(int id)
        {
            Entities.StudentMark studentMark = null;

            var query = this._qb.BuildSelectByIdQuery(this._tableName, id);

            var reader = this._client.ExecuteSelect(query);

            if (reader != null)
            {
                reader.Read();

                studentMark = new Entities.StudentMark (
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToString(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2)),
                    Convert.ToString(reader.GetValue(3)),
                    Convert.ToInt32(reader.GetValue(4)),
                    Convert.ToInt32(reader.GetValue(5))
                );

                reader.Close();
            }

            return studentMark;
        }

        public int AddStudentMark(Entities.StudentMark studentMark)
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("lesson", studentMark.Lesson);
            fieldsAndValues.Add("surname", studentMark.Surname);
            fieldsAndValues.Add("initials", studentMark.Initials);
            fieldsAndValues.Add("mark", studentMark.Mark.ToString());
            fieldsAndValues.Add("classnum", studentMark.Class.ToString());



            var query = this._qb.BuildInsertQuery(this._tableName, fieldsAndValues);

            var execResult = this._client.ExecuteInsert(query);
            return execResult;
        }

        public int UpdateStudentMark(Entities.StudentMark studentMark) 
        {
            var fieldsAndValues = new Dictionary<string, string>();

            fieldsAndValues.Add("lesson", studentMark.Lesson);
            fieldsAndValues.Add("surname", studentMark.Surname);
            fieldsAndValues.Add("initials", studentMark.Initials);
            fieldsAndValues.Add("mark", studentMark.Mark.ToString());
            fieldsAndValues.Add("classnum", studentMark.Class.ToString());

            var id = studentMark.ID;

            var query = this._qb.BuildUpdateByIdQuery(this._tableName, fieldsAndValues, id);
            var execResult = this._client.ExecuteUpdate(query);
            return execResult;
        }

        public int DeleteStudentMark(int id) 
        {
            var query = this._qb.BuildDeleteByIdQuery(this._tableName, id);
            var execResult = this._client.ExecuteDelete(query);
            return execResult;
        }
    }
}
