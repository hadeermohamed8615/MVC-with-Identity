namespace MenyaDemo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string MangerName { get; set; }
       // public bool IsDeleted { get; set; } = false;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
