using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class AreaDTO
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamps { get; set; }
        public PlantDTO Plant { get; set; }
        public List<LineDTO> Lines { get; set; }



        public string PlantId { get; set; }
    }
}
