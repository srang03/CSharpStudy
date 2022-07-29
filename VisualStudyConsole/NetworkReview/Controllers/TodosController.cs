using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace NetworkReview.Controllers
{
    [Route("api/[controller]")]
    public class TodosController :ControllerBase
    {
        ModelControllerJson _service;
        public TodosController()
        {
            _service = new ModelControllerJson();
        }
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Content("Welcome");
        //}

        [HttpPost]
        public IActionResult Add([FromBody] Model model)
        {
            model.Id = _service._repository.Max(x => x.Id) + 1;
            model.Date = DateTime.Now;
            _service.Add(model);
            return Content($"{model.Id}{model.IsDone}{model.Name}");
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllList());
        }
    }
}
