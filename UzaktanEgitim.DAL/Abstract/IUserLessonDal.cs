using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Abstract
{
    public interface IUserLessonDal : IEntityRepository<UserLesson>
    {
        List<UserLesson> GetUserLessonsByUserId(int userId);
    }
}
