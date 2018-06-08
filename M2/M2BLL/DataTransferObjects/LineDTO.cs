using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class LineDTO
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public AreaDTO Area { get; set; }
        public ManufacturerDTO Manufacturer { get; set; }
        public List<MachineDTO> Machines { get; set; }



        public string AreaId { get; set; }
        public string ManufacturerId { get; set; }
    }
}
