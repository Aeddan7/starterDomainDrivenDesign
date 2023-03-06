﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDomainDrivenDesign.Domain.Entities
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public bool isManager { get; set; } = false;
        public int teamId { get; set; }
    }
}
