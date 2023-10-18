using MenyaDemo.Entities;
using MenyaDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace MenyaDemo.Validators
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        //public int x { get; set; }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = (string)value;
            //Employee emplo = validationContext.ObjectInstance as Employee;
            ITIContext db = new ITIContext();
            Employee emp    = db.Employees.FirstOrDefault(e => e.Name == name);
            if(emp == null)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Name Already Exist");
        }
    }
}
