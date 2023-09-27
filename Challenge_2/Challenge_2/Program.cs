using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection.Metadata;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                Student newStudent = new Student { StudentName = "John Doe" };
                context.Students.Add(newStudent);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully.");
        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
        }

        public class StudentContext : DbContext
        {
            public StudentContext(DbContextOptions<StudentContext> options) : base(options)
            {
            }
            public DbSet<Student> Students { get; set; }
        }
    }
}
