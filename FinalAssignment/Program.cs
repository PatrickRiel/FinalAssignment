using System;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            using (var context = new StudentContext())
            {
                // Ensure the database is created
                context.Database.Initialize(force: false);

                // Add a new student
                var student = new Student { Name = "Patrick Chan", Age = 31 };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student added.");

                // Display all students
                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();  // Keep the console window open
    }
}
