using System;
using System.Linq;

namespace CRUDStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new StudentContext())
            {
                context.Database.EnsureCreated();
                
                var repo = new StudentRepository(context);
                
                // Console.WriteLine("Enter Student Information");
                //
                // Console.WriteLine("Id:");
                // var id = Convert.ToInt32(Console.ReadLine());
                //
                // Console.WriteLine("First Name:");
                // var firstName = Console.ReadLine();
                //
                // Console.WriteLine("Last Name:");
                // var lastName = Console.ReadLine();
                //
                // Console.WriteLine("Phone:");
                // var phone = Console.ReadLine();
                //
                // var student = repo.Create(id, firstName,lastName,phone);
                // // var student = repo.GetStudentById(2);
                // Console.WriteLine("Student Identified by Id "+ student.Id +" has been Added Successfully!");

                Console.WriteLine("All the students");
                var students = repo.GetAllStudents.ToList();
                Console.WriteLine( "ID| First Name| Last Name | Phone");
                Console.WriteLine("=====================================");

                foreach (var stud in students)
                {
                    Console.WriteLine(stud.Id + " |"+ stud.FirstName+" |"+ stud.LastName+" |"+stud.Phone);
   
                }
            }
            // var context = new StudentContext("Data Source=StudentDB.db");
           
        }
    }
}