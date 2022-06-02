using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public Summary Summary { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public ValentineSummary ValentineSummary { get; set; }
        public List<ValentineSummaryList> ValentineSummaryList { get; set; }
        public FlowerExpertsTitle FlowerExpertsTitle { get; set; }
        public List<FlowerExpertsCards> FlowerExpertsCards { get; set; }
        public BlogTitle BlogTitle { get; set; }
        public List<BlogCards> BlogCards { get; set; }
        public List<SlickItem> SlickItems { get; set; }
    }
}
