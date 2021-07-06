using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.Business.Abstract
{
    public interface IUserLessonService
    {
        List<UserLesson> GetUserLessonsByUserId(int userId);
    }
}
