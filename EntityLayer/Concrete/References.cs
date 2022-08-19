using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class References
    {
        [Key]
        public int ReferencesSayId { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public string? Comment { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; }
    }
}
