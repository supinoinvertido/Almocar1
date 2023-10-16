using Microsoft.AspNetCore.Mvc;

namespace AlmoCar.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
     [Area("Admin")]
     public IActionResult Index(){
        return View();
     }   
    }
}