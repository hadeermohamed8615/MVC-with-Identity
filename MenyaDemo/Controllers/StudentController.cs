using MenyaDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

namespace MenyaDemo.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult ShowAll()
        {
            var stds = StudentBL.GetAll();
            return View("ShowData",stds);
        }

        public IActionResult Details(int id)
        {
            return View(StudentBL.GetById(id));
        }

































        //Action => Public / Not Static / No OverLoad
        //Domain/Studnet/First
        public ContentResult First()
        {
            //Declartion
            ContentResult result = new ContentResult();
           
            //Inailization
            result.Content = "Hello from MVC";
            //return
            return result;

          
        }

        //Domain/Student/Second
        public ViewResult Second()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "MyView";
            return result;
            //Views/Student/MyView.cshtml
            //Views/Shared/MyView.cshtml
        }
        //Domain/Student/mix?id=5
        public IActionResult mix(int id)
        {
            if(id % 2 == 0)
            {
               
                return Content("Hello from MVC");
            }
            else
            {
              
                return View("MyView");
              
            }
        }


        //ContentResult => Data (string) => Content("")
        //ViewResult => View => View()
        //JsonResult => Json => Json()
       
    }
}
