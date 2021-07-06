using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Business.Abstract;
using UzaktanEgitim.DAL.Abstract;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.Business.Concrete
{
    public class UserLessonManager : IUserLessonService
    {
        IUserLessonDal _userLessonDal;

        public UserLessonManager(IUserLessonDal userLessonDal)
        {
            _userLessonDal = userLessonDal;
        }

        public List<UserLesson> GetUserLessonsByUserId(int userId)
        {
            return _userLessonDal.GetUserLessonsByUserId(userId);
        }
    }
}
