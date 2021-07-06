using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaktanEgitim.Entities.Concrete
{
    public class UserLesson : IEntity
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }

        public virtual User User { get; set; }
        public virtual Lesson Lesson { get; set; }

        public bool IsFinished { get; set; }
        public int? PausedTime { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
    }
}
