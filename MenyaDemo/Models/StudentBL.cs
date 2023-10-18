namespace MenyaDemo.Models
{
    public static class StudentBL
    {
        public static List<Student> students = new List<Student>();
        static StudentBL()
        {
            students.Add(new Student() { Id = 1 , Name = "Ali" , Image = "4.png" , Age=22});
            students.Add(new Student() { Id =2 , Name = "Nada" , Image = "1.jpg" , Age=22});
            students.Add(new Student() { Id = 3 , Name = "Aya" , Image = "2.jpg" , Age=22});
            students.Add(new Student() { Id = 4 , Name = "Hamada" , Image = "3.jpg" , Age=22});
        }

        public static List<Student> GetAll()
        {
            return students;
        }

        public static Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
