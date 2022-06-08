using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.FiorelloAdmin.Controllers
{
    [Area("FiorelloAdmin")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get;}
        private IWebHostEnvironment _env { get; }

        public SliderController(AppDbContext context , IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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
        public async Task<IActionResult> Create(Slide slide)
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
            var fileName=Guid.NewGuid().ToString() + slide.Photo.FileName;
            var resultPath = Path.Combine(_env.WebRootPath,"img",fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await slide.Photo.CopyToAsync(fileStream);

            }
            slide.Url = fileName;
            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
