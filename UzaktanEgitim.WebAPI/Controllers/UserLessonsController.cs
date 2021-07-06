using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UzaktanEgitim.Business.Abstract;
using UzaktanEgitim.Business.Concrete;
using UzaktanEgitim.DAL.Concrete.EntityFramework;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLessonsController : ControllerBase
    {
        [HttpGet]
        public List<UserLesson> GetById(int userId)
        {
            IUserLessonService userLessonService = new UserLessonManager(new EfUserLessonDal());
            var result = userLessonService.GetUserLessonsByUserId(userId);
            return result;
        }
    }
}
