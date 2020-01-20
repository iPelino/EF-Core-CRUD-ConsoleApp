using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CRUDStudentApp
{
    public class StudentContext : DbContext
    {
        // private readonly SqliteConnection _connection;
        // private readonly DbContextOptions _options;

        // public StudentContext()
        // {
        //     _connection = new SqliteConnection("Data Source=StudentDb.db");
        //     _connection.Open();
        //     _options = new DbContextOptionsBuilder()
        //         .UseSqlite(_connection)
        //         .Options;
        //
        // }
        // private readonly string _connectionString;
        //
        // public StudentContext(string connectionString)
        // {
        //     _connectionString = connectionString;
        // }
        //
   
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlite("Data source=StudentDB.db");
            // !!!: Use to complete path to your Database in your project
            optionsBuilder.UseSqlite(@"Data Source=.\home\RiderProjects\CRUDStudentApp\CRUDStudentApp\StudentDB.db");

        }
    }
}