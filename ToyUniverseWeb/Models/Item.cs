using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToyUniverseData.Models;

namespace ToyUniverseWeb.Models
{
    public class Item
    {
        public string CToyId { get; set; }
        public int SiQty { get; set; }

        public virtual Toy CToy { get; set; }
    }
}
