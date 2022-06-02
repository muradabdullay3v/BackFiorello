using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Slides = _context.Slides.ToList(),
                Summary = _context.Summary.FirstOrDefault(),
                Categories = _context.Categories.Where(c=>!c.IsDeleted).ToList(),
                Products = _context.Products.Where(c=>!c.isDeleted)
                .Include(p=>p.Images).Include(p=>p.Category).ToList(),
                ValentineSummary = _context.ValentineSummary.FirstOrDefault(),
                ValentineSummaryList = _context.ValentineSummaryList.ToList(),
                FlowerExpertsCards = _context.FlowerExpertsCards.ToList(),
                FlowerExpertsTitle = _context.FlowerExpertsTitle.FirstOrDefault(),
                BlogCards = _context.BlogCards.ToList(),
                BlogTitle = _context.BlogTitle.FirstOrDefault(),
                SlickItems = _context.SlickItems.ToList(),
            };
            return View(home);
        }
    }
}
