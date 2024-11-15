using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCCR
{
    public class DMC
    {
        public int number { get; set; }
        public string discription { get; set; }
        public int[] RGB { get; set; } = new int[3];
        public Color HexColor { get; set; }
        public string RGBcode {get; set;}

        /// <summary>
        /// prints the dmc color
        /// </summary>
        public void printinfo()
        {
            MessageBox.Show(number + " " + discription + " " + RGB[0] + " " + RGB[1] + " " + RGB[2] + " " + RGBcode);
        }
    }
}
