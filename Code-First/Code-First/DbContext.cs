using System;
using System.Data.Entity;

namespace Code_First
{
    class StudentDbContext : DbContext
    {
            public DbSet<Student> Students { get; set; }
    }
}
