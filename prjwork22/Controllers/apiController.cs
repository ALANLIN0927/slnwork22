using Microsoft.AspNetCore.Mvc;
using prjwork22.Models;

namespace prjwork22.Controllers
{
   




    public class apiController : Controller
    {

        private readonly DemoContext _context;

        public apiController(DemoContext context)
        {

            _context = context;
        }



        public IActionResult Index()
        {
            return View();
        }


        public IActionResult check(string name)
        {
         var a =_context.Members.Any(m=>m.Name==name);
            if (a)
            {
                return Content("重複", "text/palin");
            }
            return Content("可以","text/palin");

        }
        public IActionResult Region()
        {
            var regionname = _context.Address.Select(re => re.City).Distinct();
            return Json(regionname);    //回傳地區名
        }
        public IActionResult area(string region)
        {
            var areaname = _context.Address.Where(ar => ar.City == region).Select(are => are.SiteId).Distinct();
            return Json(areaname);      //條件區的城市名等於帶進來的城市名 然後不重複回傳
        }
        public IActionResult road(string area)
        {
            var roadname = _context.Address.Where(ro => ro.SiteId == area).Select(roa => roa.Road).Distinct();
            return Json(roadname);      

        }
    }
}
