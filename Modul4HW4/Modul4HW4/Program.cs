using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modul4HW4.Services;
using Modul4HW4.DataAccess;

namespace Modul4HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigService();
            var creator = new EntityProvider();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var option = optionsBuilder.UseSqlServer(config.ConnectionString).Options;
            using (var db = new ApplicationContext(option))
            {
            }
        }
    }
}
