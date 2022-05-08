using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public const int MAXWIDTH = 96;
        public const int MINWIDTH = 24;
        public const int MAXDEPTH = 48;
        public const int MINDEPTH = 12;
        public const int BASEPRICE = 200;
    }
        enum DesktopMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
}
