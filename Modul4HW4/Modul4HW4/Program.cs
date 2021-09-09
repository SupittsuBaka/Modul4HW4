using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modul4HW4.DataAccess;
using Modul4HW4.Entities;
using Modul4HW4.Services;

namespace Modul4HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigService();
            var creator = new EntityProvider();
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            dbContextOptionsBuilder.UseLazyLoadingProxies();
            dbContextOptionsBuilder.UseSqlServer(config.ConnectionString);
            using (var dbContext = new ApplicationContext(dbContextOptionsBuilder.Options))
            {
                var query1 = dbContext.Employees
                    .Include(x => x.Office)
                        .Include(x => x.EmployeeProject)
                    .ToList();

                var query2 = dbContext.Employees.Select(t => new { Name = t.FirstName + " " + t.LastName, Experience = (DateTime.Now - t.HiredDate).TotalDays / 365 }).ToArray();

                var employee1 = dbContext.Employees.Find(1);
                employee1.LastName = "Epifancev";
                var employee2 = dbContext.Employees.Find(2);
                employee2.LastName = "Pigeon";
                dbContext.Employees.UpdateRange(employee1, employee2);
                dbContext.SaveChanges();

                dbContext.Employees.Add(
                   new Employee
                   {
                       LastName = "employee",
                       FirstName = "new",
                       DateOfBirth = DateTime.Today,
                       HiredDate = DateTime.Today,
                       OfficeId = 1,
                       Title = new Title
                       {
                           Name = "oguzok"
                       },
                       EmployeeProject = new List<EmployeeProject>
                       {
                            new EmployeeProject
                            {
                                StartedDate = DateTime.Today,
                                Rate = 1000,
                                Project = new Project
                                {
                                    StartedDate = DateTime.Today,
                                    Budget = 1000,
                                    ClientId = 1,
                                    Name = "New Project"
                                }
                            }
                       }
                   });
                dbContext.SaveChanges();

                dbContext.Employees.Remove(dbContext.Employees.FirstOrDefault(t => t.Title.Name == "oguzok"));
                dbContext.SaveChanges();

                var query3 = dbContext.Employees
                   .Select(t => new { Name = t.FirstName + " " + t.LastName, Title = t.Title.Name })
                   .ToList()
                   .GroupBy(t => t.Title)
                   .Where(t => !t.Key.Contains("a", StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
