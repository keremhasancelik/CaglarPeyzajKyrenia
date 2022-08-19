using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
        public string? Company { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? SmtpServer { get; set; }
        public string? SmtpMail { get; set; }
        public string? SmtpPassword { get; set; }
        public int SmtpPort { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Linkedin { get; set; }
        public bool Status { get; set; }
    }
}
