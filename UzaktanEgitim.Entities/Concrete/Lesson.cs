using Core.Entities;
using System;
using System.Collections.Generic;

namespace UzaktanEgitim.Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int VideoPath { get; set; }
        public int VideoLength { get; set; }
        public int LessonOrder { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<UserLesson> UserLessons { get; set; }
    }
}
