using System.Data.Entity;
public class StudentContext : DbContext
{
    // DbSet property for the Student entity
    public DbSet<Student> Students { get; set; }

    // Constructor that specifies the connection string
    public StudentContext() : base("name=StudentDb")
    {
    }
}

