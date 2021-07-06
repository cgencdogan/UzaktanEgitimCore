using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaktanEgitim.Entities.Concrete
{
    public class UserCourse : IEntity
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }

        public virtual User User { get; set; }
        public virtual Course Course { get; set; }

        public DateTime StatedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
    }
}
