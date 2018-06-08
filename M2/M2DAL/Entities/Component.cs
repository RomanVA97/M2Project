using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Component
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public Machine Machine { get; set; }
        public Maintenance Maintenance { get; set; }
        //public ComponentType ComponentType { get; set; }




        public string MachineId { get; set; }
        public string MaintenanceId { get; set; }
        //public int? ComponentTypeId { get; set; }
    }
}
