using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.DataTransferObjects
{
    public class AlertDTO
    {
        public string Id { get; set; }
        public string Note { get; set; }
        public string FileUrl { get; set; }
        public UserDTO Creator { get; set; }
        public OperationDTO Operation { get; set; }
        public DateTime TimeStamps { get; set; }




        public string OperationId { get; set; }
    }
}
