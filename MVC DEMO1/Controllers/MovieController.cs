using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC_DEMO1.Controllers
{
    public class MoviesController:Controller
    {
        //Action:public non static
        // / Movies/GetMovie/10
   
        public IActionResult GetMovie(int id)
        {
            //return $"movie with id {id}";
            //ContentResult result = new ContentResult();
            //result.ContentType = $"movie with id {id}";
            //result.ContentType = "text/html";

            return Content($"movie with id {id}","text/html"); //helper method
        }
        [ActionName("Index")]
        [HttpGet]

        public IActionResult TextRedirectToAction()
        {
            //    RedirectResult redirectResult = new RedirectResult();
            //return Redirect("");
            //return RedirectToAction(nameof(GetMovie), new { id=1})
            return RedirectToRoute("default", new { controller = "Movies", action = "GetMovie", id = 1 });
    }
        public IActionResult TestModelBinding(Movie movie)
        {
            return View(movie);
        }
        public IActionResult TestModelBindingFromRequest([FromBody] Movie movie)
        {
            return View(movie);
        }



    }
}
