using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class MachineStopPeriod
    {
        public string Id { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public Machine Machine { get; set; }
        public Operation Operation { get; set; }



        public int? MachineId { get; set; }
        public int? OperationId { get; set; }
    }
}
