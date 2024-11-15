using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DMCCR
{

    public partial class Form1 : Form
    {
        /// <summary>
        /// just for importing stuff
        /// </summary>
        public DMCImporter atticus = new DMCImporter();
        /// <summary>
        /// list of all dmc colors
        /// </summary>
        private BindingList<DMC> Strings = new BindingList<DMC>(); //dont think i need this and filtered strings
        /// <summary>
        /// list of all filtered colors set to match
        /// </summary>
        private BindingList<DMC> FilteredStrings = new BindingList<DMC>();//dont think i need this and  strings
        /// <summary>
        /// 
        /// </summary>
        private BindingList<DMC> top8s = new BindingList<DMC>();
        private List<Color> ColorsUsed = new List<Color>();
        /// <summary>
        /// kinda an error checking thing
        /// </summary>
        public bool ImageLoaded = false;
        private Bitmap ImageUploaded;
        private Bitmap ImageEdited;
        public Form1()
        {
            InitializeComponent();
            atticus.fileopen();
            Strings = atticus.AllString;
            UXdmcList.DataSource = Strings;
            UXdmcList.DisplayMember = "discription";
            UxFilteredColors.DataSource = FilteredStrings;
            UxFilteredColors.DisplayMember = "discription";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            top8s = new BindingList<DMC>();
            ColorsUsed = new List<Color>();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico;*.tiff";
                ofd.Title = "Select an Image File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image into a Bitmap I dont know how much will need this depends on later
                        Bitmap selectedImage = new Bitmap(ofd.FileName);

                        // Display the image in the PictureBox
                        pictureBox1.Image = selectedImage;
                        //changes click positoin to match stretched image
                        ImageLoaded = true;
                        ImageUploaded = selectedImage;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// button for convert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Convert_Click(object sender, EventArgs e)
        {
            var BigOlDictionary = new Dictionary<Color, Color>();
            Bitmap ConvertedImage = ImageUploaded;
            if(ConvertedImage.Height > ConvertedImage.Width)
            {
                for (int i = 0; i < ConvertedImage.Width; i++)
                {
                    for (int j = 0; j < ConvertedImage.Height; j++)
                    {
                        Color originalColor = ConvertedImage.GetPixel(i, j);
                        if (BigOlDictionary.TryGetValue(originalColor, out Color value)){
                            ConvertedImage.SetPixel(i, j, value);

                        }
                        else
                        {
                            Color newColor = findtop1(originalColor);
                            ConvertedImage.SetPixel(i, j, newColor);
                            BigOlDictionary.Add(originalColor, newColor);
                            if (ColorsUsed.Contains(newColor)){}
                            else
                            {
                                ColorsUsed.Add(newColor);
                            }

                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < ConvertedImage.Height; i++)
                {
                    for (int j = 0; j < ConvertedImage.Width; j++)
                    {
                        Color originalColor = ConvertedImage.GetPixel(j, i);
                        if (BigOlDictionary.TryGetValue(originalColor, out Color value))
                        {
                            ConvertedImage.SetPixel(j, i, value);

                        }
                        else
                        {
                            Color newColor = findtop1(originalColor);
                            ConvertedImage.SetPixel(j, i, newColor);
                            BigOlDictionary.Add(originalColor, newColor);
                            if (ColorsUsed.Contains(newColor)){}else
                            {
                                ColorsUsed.Add(newColor);
                            }

                        }
                    }
                }
            }
 
            ImageEdited = ConvertedImage;
            pictureBox1.Image = ImageEdited;
            Tab2.Enabled = true;
            Tab1.Enabled = true;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ImageLoaded == true)
            {
                PointF stretched(Point p0, PictureBox pb)
                {
                    if (pb.Image == null) return PointF.Empty;

                    float scaleX = 1f * pb.Image.Width / pb.ClientSize.Width;
                    float scaleY = 1f * pb.Image.Height / pb.ClientSize.Height;

                    return new PointF(p0.X * scaleX, p0.Y * scaleY);
                }
                PointF mDown = stretched(e.Location, pictureBox1);
                Color c = ((Bitmap)pictureBox1.Image).GetPixel((int)mDown.X, (int)mDown.Y);
                HexColorName.BackColor = c;
                ColorExampleImage.BackColor = c;
                HexColorName.Text = c.Name;
                HexColorName.ForeColor = complementary(c);

                DMC[] test = findtop8(c);
                BindingList<DMC> top8 = new BindingList<DMC>();
                for(int i = 0; i < 8; i++)
                {
                    top8.Add(test[i]);
                }
                top8s = top8;
                UxFilteredColors.DataSource = top8s;
                UxFilteredColors.DisplayMember = "discription";
                ColorExampleFiltered.BackColor = top8s[UxFilteredColors.SelectedIndex].HexColor;
            }
            else
            {
                MessageBox.Show("Hi gabriel");
            }

        } 
        private DMC[] findtop8(Color c)
        {
            KeyValuePair<double, DMC>[] testint = new KeyValuePair<double, DMC>[454];
            double r1 = c.R;
            double g1 = c.G;
            double b1 = c.B;
            int r = 0;
            foreach (DMC s in Strings)
            {
                double r2 = s.RGB[0];
                double g2 = s.RGB[1];
                double b2 = s.RGB[2];
                double x = Math.Sqrt(Math.Pow(r2 - r1, 2) + Math.Pow(g2 - g1, 2) + Math.Pow(b2 - b1, 2));
                double num = Math.Pow(255, 2);
                double p = x / Math.Sqrt(num + num + num);
                testint[r] = new KeyValuePair<double, DMC>(p, s);
                r++;
            }
            DMC[] ToReturn = new DMC[8]; 
            KeyValuePair<double, DMC>[] convertTo = testint.OrderBy(kvp => kvp.Key).Take(8).ToArray();
            for (int i = 0; i < 8; i++)
            {
                ToReturn[i] = convertTo[i].Value;
            }

            return ToReturn;
        }
        private Color findtop1(Color c)
        {
            KeyValuePair<double, DMC>[] testint = new KeyValuePair<double, DMC>[454];
            double r1 = c.R;
            double g1 = c.G;
            double b1 = c.B;
            int r = 0;
            foreach (DMC s in Strings)
            {
                double r2 = s.RGB[0];
                double g2 = s.RGB[1];
                double b2 = s.RGB[2];
                double x = Math.Sqrt(Math.Pow(r2 - r1, 2) + Math.Pow(g2 - g1, 2) + Math.Pow(b2 - b1, 2));
                double num = Math.Pow(255, 2);
                double p = x / Math.Sqrt(num + num + num);
                testint[r] = new KeyValuePair<double, DMC>(p, s);
                r++;
            }
            DMC[] ToReturn = new DMC[8];
            KeyValuePair<double, DMC>[] convertTo = testint.OrderBy(kvp => kvp.Key).Take(8).ToArray();
            return convertTo[0].Value.HexColor;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorExample.BackColor = Strings[UXdmcList.SelectedIndex].HexColor;
            DMCHexColorName.BackColor = Strings[UXdmcList.SelectedIndex].HexColor;
            DMCHexColorName.Text = Strings[UXdmcList.SelectedIndex].HexColor.Name;
            DMCHexColorName.ForeColor = complementary(Strings[UXdmcList.SelectedIndex].HexColor);
        }
        private void UxFilteredColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorExampleFiltered.BackColor = top8s[UxFilteredColors.SelectedIndex].HexColor;
            FilteredHexColorName.BackColor = top8s[UxFilteredColors.SelectedIndex].HexColor;
            FilteredHexColorName.Text = top8s[UxFilteredColors.SelectedIndex].HexColor.Name;
            FilteredHexColorName.ForeColor = complementary(top8s[UxFilteredColors.SelectedIndex].HexColor);
        }
        /// <summary>
        /// gets the complementary color
        /// </summary>
        /// <returns></returns>
        public Color complementary(Color c)
        {
            int complementaryRed = 255 - c.R;
            int complementaryGreen = 255 - c.G;
            int complementaryBlue = 255 - c.B;
            return Color.FromArgb(complementaryRed, complementaryGreen, complementaryBlue);
        }
        #region extra so far
        private void Tab1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageUploaded;
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageEdited;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ColorExampleFiltered_Paint(object sender, PaintEventArgs e)
        {

        }



        #endregion

        private void UxSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                string ExportingColors = "";
                foreach (Color c in ColorsUsed)
                {
                    foreach (DMC d in Strings)
                    {
                        if (d.HexColor == c)
                        {
                            ExportingColors += (d.discription + " " + (d.number).ToString() + "\n");
                            break;
                        }
                    }
                }
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string FullPath = Path.Combine(desktopPath, textBox1.Text);
                string textFilePath = Path.Combine(FullPath, "file.txt");
                string imageFilePath = Path.Combine(FullPath, "image.png");
                if (ImageEdited != null){
                    try{
                        if (!Directory.Exists(FullPath))
                        {
                            Directory.CreateDirectory(FullPath);
                        }
                        File.WriteAllText(textFilePath, ExportingColors);
                        ImageEdited.Save(imageFilePath, ImageFormat.Png);
                        textBox1.Text = "";
                    }

                    catch (Exception ex){MessageBox.Show(ex.Message);}
                }
            }
            else{MessageBox.Show("enter a name for the stitch");}

        }
    }
}
