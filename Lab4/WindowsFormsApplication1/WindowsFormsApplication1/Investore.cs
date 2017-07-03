using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Investore
    {
        public Investore(Account object_)
        {
            Account_ = object_;
        }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string BirthDay { get; set; }
        public string PasportSeries { get; set; }
        public string PasportNumber { get; set; }
        public Account Account_ { get; set; }
    }
}
