using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class LocationDTO
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public List<MaintenanceDTO> Maintenances { get; set; }
        public List<OperationDTO> Operations { get; set; }

    }
}
