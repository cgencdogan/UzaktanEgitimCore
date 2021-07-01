using Core.Entities;

namespace UzaktanEgitim.Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public int VideoPath { get; set; }
        public int VideoLength { get; set; }
        public int LessonOrder { get; set; }
        public int CreatedBy { get; set; }
        public int CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int UpdatedDate { get; set; }
    }
}
