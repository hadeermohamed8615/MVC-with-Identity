using MenyaDemo.Entities;
using MenyaDemo.Models;
using MenyaDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MenyaDemo.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext db = new ITIContext();

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveNew(Department NewDept)
        {
            if(NewDept.Name != null && NewDept.MangerName !=null)
            {
                db.Departments.Add(NewDept);
                db.SaveChanges();
                // return View("Index",db.Departments.ToList());
                return RedirectToAction("Index");
            }
            return View("New",NewDept);

        }
        //must be public
        //cant be overload [post|get]
        //cant be static
        [HttpGet]
        public IActionResult Edit()
        {
            return Content("First Edit");
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            return Content("First Edit");
        }

        public IActionResult Index()
        {
            var depts = db.Departments.ToList();
          //  return View("Index");//viewName = Index , Model = NULL not valid
          //  return View("Index", depts);//viewName = Index , Model = depts valid
            return View(depts);//viewName = Index , Model = depts --Valid
           //  return View();//viewName = Index , Model = NULL --Not Valid
        }

        public IActionResult DeptWithBranch(int id)
        {
            var dept = db.Departments.FirstOrDefault(x => x.Id == id);
            List<string> Branches = new List<string>();
            Branches.Add("Ismailia");
            Branches.Add("Cairo");
            Branches.Add("Smart");
            Branches.Add("Mansoura");
            ViewData["Brc"] = Branches;

            ViewData["msg"] = "Hello";

            ViewBag.name = "Ahmed";

            ViewBag.Model = dept;

            ViewData["no"] = 1;

            ViewData["clr"] = "red";
            return View(dept);
        }

        public IActionResult DeptWithBranchWithVM(int id)
        {
            DeptWithBranchesAndMSGColorVM vm = new DeptWithBranchesAndMSGColorVM();
            var dept = db.Departments.FirstOrDefault(x => x.Id == id);
            List<string> Branches = new List<string>();
            Branches.Add("Ismailia");
            Branches.Add("Cairo");
            Branches.Add("Smart");
            Branches.Add("Mansoura");

            vm.DeptId = dept.Id;
            vm.DeptName = dept.Name;
            vm.Branches = Branches;
            vm.No = 2;
            vm.Msg = "Hello";
            vm.Color = "green";

            return View(vm);
        }
    }
}
