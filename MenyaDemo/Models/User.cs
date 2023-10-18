using System.ComponentModel.DataAnnotations;

namespace MenyaDemo.Models
{
    public class User
    {
        public string  UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
