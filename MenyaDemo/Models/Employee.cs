using MenyaDemo.MetaData;
using MenyaDemo.Validators;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenyaDemo.Models
{
    [ModelMetadataType(typeof(EmployeeMetaData))]
   // [ModelMetadataType(typeof(EmployeeMetaData))]
    public class Employee
    {

        public int Id { get; set; }
       //// [Required]
       // // [StringLength(20)]
       // [MinLength(3,ErrorMessage ="Name Must be more than 3 char.")]
       // [MaxLength(25, ErrorMessage = "Name Must be less than 25 char.")]
       // [UniqueName]
        public string Name { get; set; }
        //[DisplayName("Employee Salary")]
        // [DataType(DataType.Password)]
        //[Range(4000,25000, ErrorMessage = "Salary Must be more than or equal 4000 and less than 25000")]
        //[Remote("TestSalary","Employee"
        //    ,ErrorMessage ="Salary must be divide by 5"
        //    ,AdditionalFields = "DeptId,Address")]
        public int Salary { get; set; }
        //[RegularExpression(@"\w*\.(jpg|png)", ErrorMessage = "Image must end with (png or jpg)")]
        public string?  Image { get; set; }
        //[RegularExpression("[a-zA-Z]{4,20}", ErrorMessage = "Address must be char. ONLY")]
        public string  Address { get; set; }
        [DisplayName("Department")]
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
