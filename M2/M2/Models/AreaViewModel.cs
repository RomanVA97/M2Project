using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2PL.Models
{
    public class AreaViewModel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        //public PlantDTO Plant { get; set; }
        //public List<LineDTO> Lines { get; set; }



        public string PlantId { get; set; }
    }
}
