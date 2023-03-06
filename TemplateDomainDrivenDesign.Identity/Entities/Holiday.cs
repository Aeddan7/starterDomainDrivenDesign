using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDomainDrivenDesign.Identity.Entities
{
    public class Holiday
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int userId { get; set; }
    }
}
