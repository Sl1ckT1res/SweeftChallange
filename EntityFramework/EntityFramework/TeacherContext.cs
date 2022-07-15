using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework {

    internal class TeacherContext : DbContext{

        public TeacherContext() : base() {

        }

        public DbSet<teacher> teacher { get; set; }
        public DbSet<pupil> pupil { get; set; }
        public DbSet<connect> connect { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
        }

    }
}
