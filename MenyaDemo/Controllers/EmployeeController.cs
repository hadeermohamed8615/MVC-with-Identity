using MenyaDemo.Entities;
using MenyaDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenyaDemo.Controllers
{
    public class EmployeeController : Controller
    {
        ITIContext db = new ITIContext();

        //*public IActionResult TestPartialView()
        //{

        //}


        public IActionResult Details(int id)
        {
           
            return PartialView("_EmpCardPartialView", db.Employees.Find(id));
           // return View(db.Employees.Find(id));
        }







        public IActionResult TestSalary(int Salary,int DeptId)
        {
            if(Salary % 5 == 0 && DeptId == 1)
            {
                return Json(true);
            }else if(Salary % 3 == 0 && DeptId == 2)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        public IActionResult New()
        {
            var depts = db.Departments.ToList();
            ViewData["depts"] = depts;
            return View();
        }
        [HttpPost]
        public IActionResult New(Employee emp)
        {
          //  if(emp.Name != null)
          if(ModelState.IsValid)
            {
                try
                {
                   // throw new Exception();
                            db.Employees.Add(emp);
                            db.SaveChanges();
                            return RedirectToAction("Index","Employee");
                }catch(Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
                
              //  return RedirectToAction("Edit", "Employee", new {id=emp.Id});
            }
            var depts = db.Departments.ToList();
            ViewData["depts"] = depts;
            return View(emp);
        }
        
        public IActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee emp = db.Employees.FirstOrDefault(e=>e.Id == id);
            var depts = db.Departments.ToList();
            ViewData["depts"] = depts;
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute]int id,Employee emp)
        {
            //if(emp.Name != null && emp.Address != null)
            if(ModelState.IsValid == true)
            {
                var OldEmp = db.Employees.FirstOrDefault(e=>e.Id ==id);
                OldEmp.Name = emp.Name;
                OldEmp.Address = emp.Address;
                OldEmp.DeptId = emp.DeptId;
                OldEmp.Salary = emp.Salary;
                OldEmp.Image = emp.Image;
               // db.Employees.Update(emp); //Core 7 --Id not Exist => Add | Id Exist => Update 
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewData["depts"] = depts;
                return View(emp);
            }
        }
    }
}
