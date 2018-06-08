using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class Manufacturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamps { get; set; }
        public List<Line> Lines { get; set; }
    }
}
