using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class ComponentType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        //IConfiguration / JSON File
        public int MaintenancePeriodicity
        {
            get { return 0; }
        }

        public int EstimatedTimeForExecution { get; set; }


    }
}
