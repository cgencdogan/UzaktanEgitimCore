using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaktanEgitim.Entities.Concrete
{
    public class Course : IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string CoverImgPath { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        
        public virtual ICollection<UserCourse> UserCourses { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
