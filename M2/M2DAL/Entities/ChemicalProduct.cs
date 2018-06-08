using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class ChemicalProduct
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public Operation Operation { get; set; }





        public string OperationId { get; set; }
    }
}
