using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Url { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
