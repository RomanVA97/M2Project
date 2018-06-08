using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class MaintenanceDTO
    {
        public string Id { get; set; }
        //public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Periodicity { get; set; }
        public int ExtimatedTime { get; set; }
        public string MaintenancePatternTypeId { get; set; }
        public bool ContaminationRisk { get; set; }
        public ComponentDTO Component { get; set; }
        public List<OperationDTO> Operations { get; set; }
        public LocationDTO Location { get; set; }
        public bool Completed { get; set; }



        public int? ComponentId { get; set; }
    }
}
