using Core.DataAccess.EntityFramework;
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
    public class EfLessonDal : EfEntityRepositoryBase<Lesson, UzEmContext>, ILessonDal
    {
    }
}
