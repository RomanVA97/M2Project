using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class ComponentDTO
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public MachineDTO Machine { get; set; }
        public MaintenanceDTO Maintenance { get; set; }
        //public ComponentType ComponentType { get; set; }




        public string MachineId { get; set; }
        public string MaintenanceId { get; set; }
        //public int? ComponentTypeId { get; set; }
    }
}
