﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ToyUniverseData.Models
{
    public partial class Applicant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
