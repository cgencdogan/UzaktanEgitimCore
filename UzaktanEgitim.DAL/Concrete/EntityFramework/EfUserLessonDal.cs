using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.DAL.Abstract;
using UzaktanEgitim.DAL.Concrete.EntityFramework.Contexts;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Concrete.EntityFramework
{
    public class EfUserLessonDal : EfEntityRepositoryBase<UserLesson, UzEmContext>, IUserLessonDal
    {
        public List<UserLesson> GetUserLessonsByUserId(int userId)
        {
            using (var context = new UzEmContext())
            {
                return context.UserLessons.Include(ul => ul.Lesson).Where(ul => ul.UserId == userId).ToList();
            }
        }
    }
}
