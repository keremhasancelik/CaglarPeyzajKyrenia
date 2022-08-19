using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public bool Status { get; set; }
    }
}
