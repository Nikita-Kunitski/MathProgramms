using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Account
    {
        public int Nuber { get; set; }
        public string Type { get; set; }
        public int Balance { get; set; }
        public string DataCreateContribution { get; set; }
        public string InvestorName { get; set; }
        public bool SmsNotification { get; set; }
        public bool InternetBanking { get; set; }
        public Account()
        {}
    }
}
