using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Location
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public List<Maintenance> Maintenances { get; set; }
        public List<Operation> Operations { get; set; }

    }
}
