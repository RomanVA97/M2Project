using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2PL.Models
{
    public class PlantViewModel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public List<AreaViewModel> Areas { get; set; }
    }
}
