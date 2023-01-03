using Microsoft.AspNetCore.Mvc;
using Phan1.Models;

namespace Phan1.Controllers
{
public class StudentController : Controller 
{
    public IActionResult Index()
    {
//Khởi tạo list student
            var StdList =new List<Student>()
            {
                new Student{ StudentID=1, StudentName="Nguyễn Văn A", StudentAge=14},
                new Student{ StudentID=2, StudentName="Nguyễn Văn B", StudentAge=19},
                new Student{ StudentID=3, StudentName="Nguyễn Văn C", StudentAge=25},
                new Student{ StudentID=4, StudentName="Nguyễn Văn D", StudentAge=17},
                new Student{ StudentID=5, StudentName="Nguyễn Văn E", StudentAge=10},
                new Student{ StudentID=6, StudentName="Nguyễn Văn E", StudentAge=15},
                new Student{ StudentID=7, StudentName="Nguyễn Văn H", StudentAge=14},
                new Student{ StudentID=8, StudentName="Nguyễn Văn M", StudentAge=19},
                new Student{ StudentID=9, StudentName="Nguyễn Văn P", StudentAge=25},
                new Student{ StudentID=10, StudentName="Nguyễn Văn Q", StudentAge=17},
                new Student{ StudentID=11, StudentName="Nguyễn Văn T", StudentAge=10},
                new Student{ StudentID=15, StudentName="Nguyễn Văn E", StudentAge=15},



            };
            // ViewBag.DanhsachSV = StdList.Count();
            ViewData["Student"] = StdList;
            return View(StdList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            ViewBag.Sinhvien ="Hello:  "+ std.StudentID + "-"+ std.StudentName + "-"+ std.StudentAge;
            return View();
        }
    }
}