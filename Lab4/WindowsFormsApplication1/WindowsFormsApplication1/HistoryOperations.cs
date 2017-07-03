using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class HistoryOperations
    {
        public HistoryOperations(Investore object_)
        { Investore_ = object_; }
        public Investore Investore_ { get; set; }
        public bool Summa { get; set;}
        public string Date { get; set; }
        public string Type { get; set; }
    }
}
