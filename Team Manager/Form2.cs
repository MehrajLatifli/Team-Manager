using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Manager
{
    public partial class ViewTeam : Form
    {
        public string Mystring { get; set; }
        public ViewTeam()
        {
            InitializeComponent();
        }

        public ViewTeam(string s0,string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string sn0, string sn1, string sn2, string sn3, string sn4, string sn5, string sn6, string sn7, string sn8, string sn9, string sn10, string flag)
        {
            InitializeComponent();
            label1.Text = s10;
            label2.Text = s1;
            label3.Text = s2;
            label4.Text = s3;
            label5.Text = s4;
            label6.Text = s0;
            label7.Text = s5;
            label8.Text = s6;
            label9.Text = s7;
            label10.Text = s8;
            label11.Text = s9;
            label21.Text = sn0;
            label19.Text = sn1;
            label13.Text = sn2;
            label14.Text = sn3;
            label20.Text = sn4;
            label15.Text = sn5;
            label16.Text = sn6;
            label17.Text = sn7;
            label18.Text = sn8;
            label22.Text = sn9;
            label23.Text = sn10;

            string country = flag;

   
            if (country == "Azerbaijan")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/AZ/shiny/64.png";
               
            }

            if (country == "Turkey")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/TR/shiny/64.png";

            }

            if (country == "Kazakhstan")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/KZ/shiny/64.png";

            }

            if (country == "Kyrgyzstan")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/KG/shiny/64.png";

            }
            if (country == "Uzbekistan")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/UZ/shiny/64.png";

            }

            if (country == "Turkmenistan")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/TM/shiny/64.png";

            }
            if (country == "Germany")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/DE/shiny/64.png";

            }

            if (country == "Denmark")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/DK/shiny/64.png";

            }

            if (country == "Norway")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/NO/shiny/64.png";

            }
            if (country == "Sweden")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/SE/shiny/64.png";

            }

            if (country == "Finland")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/FI/shiny/64.png";

            }

            if (country == "Estonia")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/EE/shiny/64.png";

            }

            if (country == "Latvia")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/LV/shiny/64.png";

            }

            if (country == "Lithuania")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/LT/shiny/64.png";

            }

            if (country == "Poland")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/PL/shiny/64.png";

            }

            if (country == "Ukraine")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/UA/shiny/64.png";

            }

            if (country == "Georgia")
            {
                pictureBox3.ImageLocation = "https://www.countryflags.io/GE/shiny/64.png";

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Mystring = label1.Text;
           
         
        }

      
    }
}
