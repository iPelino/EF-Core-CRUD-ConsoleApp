using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CRUDStudentApp
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlite(@"Data Source=.\home\RiderProjects\CRUDStudentApp\CRUDStudentApp\StudentDB.db");

        }
    }
}
