using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace term_paper.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<StudyContext>          // создание базы данных программмным способом
    {
        protected override void Seed(StudyContext context)
        {
            context.Students.Add(new Student() { ID = 111, FIO = "Malakyan Akhrimat", Group = "211-375" });

            context.Students.Add(new Student() { ID = 112, FIO = "Nepeipivo Vsevolod", Group = "221-721" });
            
            context.Students.Add(new Student() { ID = 1113, FIO = "Lizkodral Vitalina", Group = "191-846" });

            base.Seed(context);
        }
    }
}
