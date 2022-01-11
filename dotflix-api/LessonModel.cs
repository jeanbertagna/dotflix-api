using DotFlix.Classes;

namespace dotflix_api
{
    public class LessonModel
    {
        public int Id { get; protected set; }

        public Category Category { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public bool Excluded { get; set; }


        public LessonModel(Lesson lesson)
        {
            Id = lesson.returnId();
            Category = lesson.returnCategory();
            Title = lesson.resturnTitle();
            Description = lesson.returnDescription();
            Year = lesson.returnYear();
            Excluded = lesson.returnExcluded();
        }

        public Lesson ToLesson()
        {
            return new Lesson(Id, Category, Title, Description, Year);
        }
    }
}
