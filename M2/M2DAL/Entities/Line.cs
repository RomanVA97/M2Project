using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Line
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public Area Area { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Machine> Machines { get; set; }



        public string AreaId { get; set; }
        public string ManufacturerId { get; set; }
    }
}
