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
    }
}
