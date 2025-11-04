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

    }
}
