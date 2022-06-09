using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Helpers;
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
            if (slide.Photo.CheckFlieSize(200))
            {
                ModelState.AddModelError("Photo" , "Image's max size must be less than 200kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of File must be image");
                return View();
            }
            
            slide.Url = await slide.Photo.SaveFileAsync(_env.WebRootPath,"images");
            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var slider = _context.Slides.Find(id);
            if (slider == null) return NotFound();
            var path = Helper.GetPath(_env.WebRootPath , "img" , slider.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Slides.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
