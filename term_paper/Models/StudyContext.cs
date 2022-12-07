using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace term_paper.Models
{
    public class StudyContext : DbContext                       // база данных с двумя таблицами - студенты и преподы
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
