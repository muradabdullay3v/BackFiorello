using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Summary> Summary { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ValentineSummary> ValentineSummary { get; set; }
        public DbSet<ValentineSummaryList> ValentineSummaryList { get; set; }
        public DbSet<FlowerExpertsTitle> FlowerExpertsTitle { get; set; }
        public DbSet<FlowerExpertsCards> FlowerExpertsCards { get; set; }
        public DbSet<BlogTitle> BlogTitle { get; set; }
        public DbSet<BlogCards> BlogCards { get; set; }
        public DbSet<SlickItem> SlickItems { get; set; }
    }
}
