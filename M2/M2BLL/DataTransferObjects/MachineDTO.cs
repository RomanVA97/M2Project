using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class MachineDTO
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public LineDTO Line { get; set; }
        public List<ComponentDTO> Components { get; set; }
        //public List<MachineStopPeriod> MachineStopPeriods { get; set; }



        public int? LineId { get; set; }
    }
}
