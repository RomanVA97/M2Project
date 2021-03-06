﻿using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Operation
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public DateTime DueDate { get; set; }
        public bool Done { get; set; }
        public bool ReferenceExist { get; set; }
        public bool SpareExist { get; set; }
        public bool ExternalMaintainer { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int MachineStopTime { get; set; }
        public bool MManagerApprove { get; set; }
        public bool PManagerApprove { get; set; }
        public bool QManagerApprove { get; set; }
        public bool ContaminationRisk { get; set; }
        public int Vote { get; set; }
        public Maintenance Maintenance { get; set; }
        public Component Component { get; set; }
        public ApplicationUser Creator { get; set; } 
        public ApplicationUser Worker { get; set; }
        public List<ChemicalProduct> ChemicalProducts { get; set; }
        public Location Location { get; set; }
        public List<Alert> Alerts { get; set; }        
        public DateTime TimeStamps { get; set; }
        


        public string LocationId { get; set; }
        public string ComponentId { get; set; }
        public string MaintenanceId { get; set; }
        public string CreatorId { get; set; }
        public string WorkerId { get; set; }
    }
}
