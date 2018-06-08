using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class ChemicalProductDTO
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public OperationDTO Operation { get; set; }





        public string OperationId { get; set; }
    }
}
