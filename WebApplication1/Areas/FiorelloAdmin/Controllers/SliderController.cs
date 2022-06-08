using Microsoft.AspNetCore.Mvc;
using System.IO;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.FiorelloAdmin.Controllers
{
    [Area("FiorelloAdmin")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get;}

        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Slides);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slide slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slide.Photo.Length/1024 > 200)
            {
                ModelState.AddModelError("Photo" , "Image's max size must be less than 200kb");
                return View();
            }
            if (!slide.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Type of File must be image");
                return View();
            }
            using (FileStream fileStream = new FileStream(@"F:\VS pr\WebApplication1\WebApplication1\wwwroot\images\" + slide.Photo.FileName, FileMode.Create))
            {
                slide.Photo.CopyTo(fileStream);

            }
            return Json(slide.Photo.FileName);
        }
    }
}
