using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Hary",
                    Department = Dept.IT,
                    Email = "Hary@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Mary",
                    Department = Dept.HR,
                    Email = "Mary@gmail.com"
                }

                );
        }
    }
}
