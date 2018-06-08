using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class ManufacturerDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamps { get; set; }
        public List<LineDTO> Lines { get; set; }
    }
}
