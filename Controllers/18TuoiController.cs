using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace NGUYENPHANVINH_2021050911_KiemTra.Controllers
{
    public class 18TuoiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int NamSinh)
        {
            int Nam = 2025;
            int Tuoi = 2025 -NamSinh;
        if (Tuoi > 18)
        {
            string strOutput = "Ban da du 18 tuoi";
            ViewBag.18Tuoi = strOutput;
                
            }
            return View();
        }
    }    
}