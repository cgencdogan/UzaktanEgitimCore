using Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Concrete.EntityFramework.Contexts
{
    public class UzEmContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserLesson> UserLessons { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=UzaktanEgitim;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserLesson>().HasKey(ul => new { ul.UserId, ul.LessonId });
            builder.Entity<UserCourse>().HasKey(uc => new { uc.UserId, uc.CourseId });
            builder.Entity<UserOperationClaim>().HasKey(uoc => new { uoc.UserId, uoc.OperationClaimId });
        }
    }
}
