using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Machine
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public Line Line { get; set; }
        public List<Component> Components { get; set; }
        //public List<MachineStopPeriod> MachineStopPeriods { get; set; }



        public int? LineId { get; set; }
    }
}
