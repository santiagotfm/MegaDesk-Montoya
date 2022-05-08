using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    }
}
