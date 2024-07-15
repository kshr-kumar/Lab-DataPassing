using Microsoft.AspNetCore.Mvc;

namespace Lab_DataPassing.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
