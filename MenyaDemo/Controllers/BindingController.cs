using MenyaDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenyaDemo.Controllers
{
    public class BindingController : Controller
    {
        ///Primitive Data
        ///Complex
        ///Collection
        ///

        ///PrimtiveDT
        ///
        ///Binding/PrimitiveDT?id=5&name=ali
        ///Binding/PrimitiveDT/1/ali XXXXXXXXXXX
        public IActionResult PrimitiveDT(int id , string name , string[] color)
        {
            return Content("Ay7aga");
        }

        ///Collection
        ///Binding/CollectionDT?phones[ali]=12345&name=ali
        public IActionResult CollectionDT(Dictionary<string, string> phones,string name) 
        {
            phones["ali"] = "12345";
            return Content("Ay7aga");

        }
        ///Binding/ComplixDT?id=1&name=SD&mangerName=ali
        //////Binding/ComplixDT?id=1&id=2&name=SD&mangerName=ali&Employees[0].name=mohamed
        public IActionResult ComplixDT(Department dept,string name,int id)
        {
            return Content("Ay7aga");

        }
    }
}
