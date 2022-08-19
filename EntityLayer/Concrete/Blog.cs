using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? Author { get; set; }
        public string? Date { get; set; }
        public string? Budget { get; set; }
        public string? Schedule { get; set; }
        public string? Comments { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
