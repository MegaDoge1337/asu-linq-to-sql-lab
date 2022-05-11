using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.SqlClient.Entities
{
    public class StudentMark
    {
        public int ID;
        public string Lesson;
        public string Surname;
        public string Initials;
        public int Mark;
        public int Class;

        public StudentMark(int id, string lesson, string surname, string initials, int mark, int classnum) 
        {
            this.ID = id;
            this.Lesson = lesson;
            this.Surname = surname;
            this.Initials = initials;
            this.Mark = mark;
            this.Class = classnum;
        }
    }
}
