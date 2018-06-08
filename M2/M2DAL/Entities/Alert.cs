using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Alert
    {
        public string Id { get; set; }
        public string Note { get; set; }
        public string FileUrl { get; set; }
        public ApplicationUser Creator { get; set; }
        public Operation Operation { get; set; }
        public DateTime TimeStamps { get; set; }




        public string OperationId { get; set; }
        public string CreatorId { get; set; }
    }
}
