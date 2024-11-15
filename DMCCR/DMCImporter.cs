using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCCR
{
    public class DMCImporter
    {
        public BindingList<DMC> AllString = new BindingList<DMC>();
        public void fileopen()
        {
            string filePath = Path.GetFullPath("DMCLIST.txt");
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    DMC dmc = new DMC();
                    int location = 0;
                    string[] d = sr.ReadLine().Split(' ');
                    dmc.number = Int32.Parse(d[location]);
                    location++;
                    bool getname = true;
                    string colorname = "";
                    while (getname)
                    {
                        if (int.TryParse(d[location], out _)){
                            getname = false;
                        }
                        else
                        {
                            colorname += " " + d[location];
                            location++;
                        }
                    }
                    dmc.discription = colorname;
                    int[] ints = { Int32.Parse(d[location]), Int32.Parse(d[location + 1]), Int32.Parse(d[location + 2]) };
                    dmc.RGB = ints;
                    dmc.RGBcode = d[location + 3];
                    dmc.HexColor = Color.FromArgb(dmc.RGB[0], dmc.RGB[1], dmc.RGB[2]);
                    AllString.Add(dmc);

                }
                sr.Close();
            }
        }
    }
}
