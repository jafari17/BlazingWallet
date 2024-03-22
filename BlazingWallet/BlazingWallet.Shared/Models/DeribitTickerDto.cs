using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingWallet.Shared.Models
{
    public class DeribitTickerDto
    {
        public string InstrumentName { get; set; }
        public string Delta { get; set; }
        public string MarkPrice { get; set; }
    }
}
