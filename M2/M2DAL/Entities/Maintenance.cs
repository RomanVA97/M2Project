using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Maintenance
    {
        public string Id { get; set; }
        //public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Periodicity { get; set; }
        public int ExtimatedTime { get; set; }
        public string MaintenancePatternTypeId { get; set; }
        public bool ContaminationRisk { get; set; }
        public Component Component { get; set; }
        public List<Operation> Operations { get; set; }
        public Location Location { get; set; }
        public bool Completed { get; set; }



        public string ComponentId { get; set; }
        public string LocationId { get; set; }
    }
}
