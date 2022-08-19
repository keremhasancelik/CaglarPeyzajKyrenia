using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? TitleTwo { get; set; }
        public string? DetailTwo { get; set; }
        public string? TitleThere { get; set; }
        public string? DetailThere { get; set; }
        public string? Image { get; set; }
        public string? WorkerDetail { get; set; }
        public string? WorkerImage { get; set; }
        public string? JobOpenings { get; set; }
        public string? JobOpeningsDetail { get; set; }
        public bool Status { get; set; }
    }
}
