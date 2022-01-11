using DotFlix.Classes;
using DotFlix.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotflix_api.Controllers
{
    [Route("controller")]
    public class LessonController : Controller
    {
        private readonly IRepository<Lesson> _repositoryLesson;

        public LessonController(IRepository<Lesson> repositoryLesson)
        {
            _repositoryLesson = repositoryLesson;
        }

        [HttpGet("")]
        public IActionResult Relation()
        {
            //Wtf?
            return Ok(_repositoryLesson.Relation().Select(a=> new LessonModel(a)));

            //IList<LessonModel> lesson = new List<LessonModel>();
            //return Ok(lesson);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] LessonModel model)
        {
            _repositoryLesson.Update(id, model.ToLesson()); // Exists AutoMapper
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repositoryLesson.Delete(id);
            return NoContent();
        }
        

        [HttpPost("{id}")]
        public IActionResult Insert(int id, [FromBody]LessonModel model) => Ok(model);

        [HttpGet("{id}")]
        public IActionResult Consult(int id) => Ok(id);

    }
}
