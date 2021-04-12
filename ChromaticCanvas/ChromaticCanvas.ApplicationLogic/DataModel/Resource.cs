using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.DataModel
{
    public class Resource
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Location { get; set; }
        public bool Available { get; set; }
    }
}
