using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Products
    {
        [Key]
        public int ProductsId { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? TitleTwo { get; set; }
        public string? Detail { get; set; }
        public string? Location { get; set; }
        public string? Area { get; set; }
        public string? Budget { get; set; }
        public string? Schedule { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; }
    }
}
