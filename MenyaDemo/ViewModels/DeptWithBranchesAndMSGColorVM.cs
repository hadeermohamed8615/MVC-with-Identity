using MenyaDemo.Models;

namespace MenyaDemo.ViewModels
{
    public class DeptWithBranchesAndMSGColorVM
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Msg { get; set; }
        public string  Color { get; set; }

        public int No { get; set; }
        public List<string> Branches { get; set; }

    }
}
