using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework {
    internal class Program {
        static void Main(string[] args) {
            using var teacherContext = new TeacherContext();

            teacherContext.Database.Exists();

            var query = (from t in teacherContext.teacher
                         join c in teacherContext.connect on t.teach_id equals c.teach_id
                         join p in teacherContext.pupil on c.stud_id equals p.stud_id
                         where p.firstname == "გიორგი"
                         select new {
                             t.firstname,
                             t.lastname,
                             t.gender,
                             t.subj,
                         }).ToList();

        }
    }
}
