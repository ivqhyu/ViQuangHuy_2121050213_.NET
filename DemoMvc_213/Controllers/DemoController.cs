using Microsoft.AspNetCore.Mvc;
using DemoMvc_213.Models;

namespace DemoMvc_213.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = "Đây là trang giới thiệu trong DemoController.";
            return View();
        }


        // ViewBag - ViewData - TempData
        public IActionResult DemoData()
        {
            var students = new List<string> { "Nguyen Van A", "Nguyen Van B", "Nguyen Van C" };

            ViewBag.Student = students;
            ViewData["Student"] = students;
            TempData["Student"] = string.Join(",", students); // TempData không lưu được List trực tiếp
            return View();
        }

        // Gửi nhận dữ liệu giữa Controller và View 
        public IActionResult SendData()
        {
            string message = "Tin nhắn được gửi từ Controller";
            ViewBag.Message = message;
            return View();
        }

        // Nhận dữ liệu từ View
        [HttpPost]
        public IActionResult ReceiveData(string username)
        {
            ViewBag.Result = $"Xin chào {username}, bạn đã gửi dữ liệu thành công!";
            return View("SendData");
        }




        // 
        public IActionResult CreateStudent()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            // Nhận dữ liệu từ form 
            if (ModelState.IsValid)
            {
                ViewBag.Info = $"Họ tên: {student.Name}, Tuổi: {student.Age}, Ngành: {student.Major}";
            }
            return View("StudentResult", student);
        }




// Hiển thị lời chào người dùng (nhập tên, tuổi)
        // Hiển thị form nhập tên
        public IActionResult Hello()
        {
            return View();
        }

        // Nhận dữ liệu từ form gửi lên
        [HttpPost]
        public IActionResult Hello(string name, int year)
        {
            int tuoi = DateTime.Now.Year - year;
            ViewBag.Message = $"Xin chào {name}, bạn {tuoi} tuổi.";
            return View();
        }



// Giải phương trình bậc 2
        public IActionResult PTB2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PTB2(double a, double b, double c)
        {
            string result;
            double delta = b * b - 4 * a * c;

            if (a == 0)
            {
                result = b == 0 ? "Phương trình vô nghiệm" : $"Phương trình có 1 nghiệm: x = {-c / b}";
            }
            else if (delta < 0)
            {
                result = "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                result = $"Phương trình có nghiệm kép: x₁ = x₂ = {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                result = $"Phương trình có 2 nghiệm phân biệt: x₁ = {x1}, x₂ = {x2}";
            }

            ViewBag.Result = result;
            return View();
        }

    }
}
