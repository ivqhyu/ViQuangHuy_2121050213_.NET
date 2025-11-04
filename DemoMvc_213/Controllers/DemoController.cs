using Microsoft.AspNetCore.Mvc;

namespace DemoMvc_213.Controllers
{
    public class DemoController : Controller
    {
        // Action Index => hiển thị trang Views/Demo/Index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        // Ví dụ thêm: truyền dữ liệu ra View
        public IActionResult About()
        {
            ViewBag.Message = "Đây là trang giới thiệu trong DemoController.";
            return View();
        }
    }
}
