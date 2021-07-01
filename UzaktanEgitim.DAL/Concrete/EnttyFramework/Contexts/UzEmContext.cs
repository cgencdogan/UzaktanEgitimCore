using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Concrete.EnttyFramework.Contexts
{
    public class UzEmContext : IdentityDbContext
    {
        public UzEmContext()
        {
            Database.SetConnectionString(@"server=(localdb)\MSSQLLocalDB;database=UzaktanEgitim;Integrated Security=true");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
