using System.Data;
using System.Drawing.Imaging;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace ColorManeger
{
    public partial class Form1 : Form
    {
        int red, green, blue, temp;
        int total, maximum, minimum;

        public Form1()
        {
            InitializeComponent();
        }

        private void ‹@”\FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void DisplayColor()
        {
            ColorLabel.ForeColor = Color.FromArgb(red, green, blue);

            string temp = "#";
            if (red < 16)
            {
                temp += "0" + red.ToString("X");
            }
            else
            {
                temp += red.ToString("X");
            }

            if (green < 16)
            {
                temp += "0" + green.ToString("X");
            }
            else
            {
                temp += green.ToString("X");
            }

            if (blue < 16)
            {
                temp += "0" + blue.ToString("X");
            }
            else
            {
                temp += blue.ToString("X");
            }

            ColorCode.Text = temp;
        }

        void AdjustValues()
        {
            if (red < 0) red = 0; if (red > 255) red = 255;
            if (green < 0) green = 0; if (green > 255) green = 255;
            if (blue < 0) blue = 0; if (blue > 255) blue = 255;


            RedTB.Text = Convert.ToString(red);
            GreenTB.Text = Convert.ToString(green);
            BlueTB.Text = Convert.ToString(blue);

            RedSB.Value = red;
            GreenSB.Value = green;
            BlueSB.Value = blue;
        }

        private void RedTB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RedTB.Text, out temp)) red = int.Parse(RedTB.Text);
            AdjustValues();
            DisplayColor();
        }

        private void BlueTB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(BlueTB.Text, out temp)) blue = int.Parse(BlueTB.Text);
            AdjustValues();
            DisplayColor();
        }

        private void GreenTB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(GreenTB.Text, out temp)) green = int.Parse(GreenTB.Text);
            AdjustValues();
            DisplayColor();
        }

        private void RedSB_Scroll_1(object sender, ScrollEventArgs e)
        {
            red = RedSB.Value;
            AdjustValues();
            DisplayColor();
        }

        private void GreenSB_Scroll(object sender, ScrollEventArgs e)
        {
            green = GreenSB.Value;
            AdjustValues();
            DisplayColor();
        }

        private void BlueSB_Scroll(object sender, ScrollEventArgs e)
        {
            blue = BlueSB.Value;
            AdjustValues();
            DisplayColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ColorCode.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maximum = Math.Max(Math.Max(red, green), Math.Max(green, blue));
            minimum = Math.Min(Math.Min(red, green), Math.Min(green, blue));
            total = maximum + minimum;

            red = total - red;
            green = total - green;
            blue = total - blue;
            DisplayColor();
            AdjustValues();
        }
    }
}