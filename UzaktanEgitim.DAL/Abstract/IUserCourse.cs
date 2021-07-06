using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Abstract
{
    public interface IUserCourseDal : IEntityRepository<UserCourse>
    {
        List<UserCourse> GetUserCoursesByUserId(int id);
    }
}
