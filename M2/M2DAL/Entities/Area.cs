using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Area
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public Plant Plant { get; set; }
        public List<Line> Lines { get; set; }



        public string PlantId { get; set; }
    }
}
