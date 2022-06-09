using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

    // class name must == file name
    public class SurveyController: Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(string Name, string Language, string Location, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Language = Language;
            ViewBag.Location = Location;
            ViewBag.Comment = Comment;
            return View("Success");

        }
        [HttpGet("success")]
        public ViewResult Success()
            {
                return View();
            }

        
    }