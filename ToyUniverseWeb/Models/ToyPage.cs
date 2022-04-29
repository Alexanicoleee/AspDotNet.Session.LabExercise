using ToyUniverseData.Models;
using System.Collections.Generic;

namespace ToyUniverseData.Models
{
    public class ToyPage
    {
        public List<Toy> ToyList { get; set; }

        public int CurrentPageIndex { get; set; }

        public int PageCount { get; set; }
    }
}
