using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDomainDrivenDesign.Identity.Entities
{
    public class Document
    {
        public int id { get; set; }
        public DateTime uploadDate { get; set; }
        public string path { get; set; }
        public string holidayId { get; set; }
    }
}
