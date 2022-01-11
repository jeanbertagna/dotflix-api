using Microsoft.AspNetCore.Mvc;

namespace dotflix_api.Controllers
{
    [Route("controller")]
    public class LessonController : Controller
    {
        [HttpGet("")]
        public IActionResult Relation()
        {
            IList<LessonModel> lesson = new List<LessonModel>();

            return Ok(lesson);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] LessonModel model)
        {
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(id);

        [HttpPost("{id}")]
        public IActionResult Insert(int id, [FromBody]LessonModel model) => Ok(model);

        [HttpGet("{id}")]
        public IActionResult Consult(int id) => Ok(id);

    }
}
