using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Team_Manager
{
    public partial class TeamManager : Form
    {
        public TeamManager()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        MemberOfTeam[] u = new MemberOfTeam[11];

        List<Team> teams = new List<Team>();





        public string dd = "DD";
        public string md = "MD";
        public string f = "F";
        public string gk = "GK";

        public string country = "";
        public string tactics = "";

        public string fullName0 = "";

        public string number0 = "";

        public string fullName1 = "";

        public string number1 = "";

        public string fullName2 = "";

        public string number2 = "";

        public string fullName3 = "";

        public string number3 = "";

        public string fullName4 = "";

        public string number4 = "";

        public string fullName5 = "";

        public string number5 = "";

        public string fullName6 = "";

        public string number6 = "";

        public string fullName7 = "";

        public string number7 = "";

        public string fullName8 = "";

        public string number8 = "";

        public string fullName9 = "";

        public string number9 = "";

        public string fullName10 = "";

        public string number10 = "";
        private void Generateguna2Button1_Click(object sender, EventArgs e)
        {


            if (Positionguna2ComboBox1.Text == "5 3 2")
            {
                for (int i = 0; i < u.Length; i++)
                {



                    u[0] = new MemberOfTeam();
                    u[0].Position = dd;

                    u[1] = new MemberOfTeam();
                    u[1].Position = dd;

                    u[2] = new MemberOfTeam();
                    u[2].Position = dd;

                    u[3] = new MemberOfTeam();
                    u[3].Position = dd;

                    u[4] = new MemberOfTeam();
                    u[4].Position = dd;

                    u[5] = new MemberOfTeam();
                    u[5].Position = md;

                    u[6] = new MemberOfTeam();
                    u[6].Position = md;

                    u[7] = new MemberOfTeam();
                    u[7].Position = md;

                    u[8] = new MemberOfTeam();
                    u[8].Position = f;

                    u[9] = new MemberOfTeam();
                    u[9].Position = f;


                    u[10] = new MemberOfTeam();
                    u[10].Position = gk;



                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }

                    else


                        flowLayoutPanel1.Controls.Add(u[0]);
                    flowLayoutPanel1.Controls.Add(u[1]);
                    flowLayoutPanel1.Controls.Add(u[2]);
                    flowLayoutPanel1.Controls.Add(u[3]);
                    flowLayoutPanel1.Controls.Add(u[4]);
                    flowLayoutPanel1.Controls.Add(u[5]);
                    flowLayoutPanel1.Controls.Add(u[6]);
                    flowLayoutPanel1.Controls.Add(u[7]);
                    flowLayoutPanel1.Controls.Add(u[8]);
                    flowLayoutPanel1.Controls.Add(u[9]);
                    flowLayoutPanel1.Controls.Add(u[10]);

                    if (!Directory.Exists("Data"))
                    {
                        Directory.CreateDirectory("Data");
                    }

                    Generateguna2Button1.Enabled = false;
                    Createguna2Button1.Enabled = true;

                    break;





                }

            }




            if (Positionguna2ComboBox1.Text == "3 3 4")
            {
                for (int i = 0; i < u.Length; i++)
                {



                    u[0] = new MemberOfTeam();
                    u[0].Position = dd;

                    u[1] = new MemberOfTeam();
                    u[1].Position = dd;

                    u[2] = new MemberOfTeam();
                    u[2].Position = dd;

                    u[3] = new MemberOfTeam();
                    u[3].Position = md;

                    u[4] = new MemberOfTeam();
                    u[4].Position = md;

                    u[5] = new MemberOfTeam();
                    u[5].Position = md;

                    u[6] = new MemberOfTeam();
                    u[6].Position = f;

                    u[7] = new MemberOfTeam();
                    u[7].Position = f;

                    u[8] = new MemberOfTeam();
                    u[8].Position = f;

                    u[9] = new MemberOfTeam();
                    u[9].Position = f;


                    u[10] = new MemberOfTeam();
                    u[10].Position = gk;



                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }

                    else


                        flowLayoutPanel1.Controls.Add(u[0]);
                    flowLayoutPanel1.Controls.Add(u[1]);
                    flowLayoutPanel1.Controls.Add(u[2]);
                    flowLayoutPanel1.Controls.Add(u[3]);
                    flowLayoutPanel1.Controls.Add(u[4]);
                    flowLayoutPanel1.Controls.Add(u[5]);
                    flowLayoutPanel1.Controls.Add(u[6]);
                    flowLayoutPanel1.Controls.Add(u[7]);
                    flowLayoutPanel1.Controls.Add(u[8]);
                    flowLayoutPanel1.Controls.Add(u[9]);
                    flowLayoutPanel1.Controls.Add(u[10]);

                    if (!Directory.Exists("Data"))
                    {
                        Directory.CreateDirectory("Data");
                    }

                    Generateguna2Button1.Enabled = false;
                    Createguna2Button1.Enabled = true;

                    break;





                }

            }
        }


        private void Createguna2Button1_Click(object sender, EventArgs e)
        {

            if (Positionguna2ComboBox1.Text == "5 3 2")
            {



                u[0].FullName = u[0].FullNametextBox.Text;
                fullName0 = u[0].FullName;

                u[1].FullName = u[1].FullNametextBox.Text;
                fullName1 = u[1].FullName;


                u[2].FullName = u[2].FullNametextBox.Text;
                fullName2 = u[2].FullName;


                u[3].FullName = u[3].FullNametextBox.Text;
                fullName3 = u[3].FullName;


                u[4].FullName = u[4].FullNametextBox.Text;
                fullName4 = u[4].FullName;


                u[5].FullName = u[5].FullNametextBox.Text;
                fullName5 = u[5].FullName;


                u[6].FullName = u[6].FullNametextBox.Text;
                fullName6 = u[6].FullName;


                u[7].FullName = u[7].FullNametextBox.Text;
                fullName7 = u[7].FullName;

                u[8].FullName = u[8].FullNametextBox.Text;
                fullName8 = u[8].FullName;


                u[9].FullName = u[9].FullNametextBox.Text;
                fullName9 = u[9].FullName;

                u[10].FullName = u[10].FullNametextBox.Text;
                fullName10 = u[10].FullName;

                u[0].Number = u[0].NumbertextBox.Text;
                number0 = u[0].Number;

                u[1].Number = u[1].NumbertextBox.Text;
                number1 = u[1].Number;


                u[2].Number = u[2].NumbertextBox.Text;
                number2 = u[2].Number;


                u[3].Number = u[3].NumbertextBox.Text;
                number3 = u[3].Number;


                u[4].Number = u[4].NumbertextBox.Text;
                number4 = u[4].Number;


                u[5].Number = u[5].NumbertextBox.Text;
                number5 = u[5].Number;


                u[6].Number = u[6].NumbertextBox.Text;
                number6 = u[6].Number;


                u[7].Number = u[7].NumbertextBox.Text;
                number7 = u[7].Number;

                u[8].Number = u[8].NumbertextBox.Text;
                number8 = u[8].Number;


                u[9].Number = u[9].NumbertextBox.Text;
                number9 = u[9].Number;

                u[10].Number = u[10].NumbertextBox.Text;
                number10 = u[10].Number;

                List<Team> teams = new List<Team>();

                country = Countrylabel1.Text;

                tactics = Positionguna2ComboBox1.SelectedItem.ToString();
                teams.Add(new Team(country, tactics,fullName0, number0, fullName1, number1, fullName2, number2, fullName3, number3, fullName4, number4, fullName5, number5, fullName6, number6, fullName7, number7, fullName8, number8, fullName9, number9, fullName10, number10)
                {
                    Country = country,
                    Tactics = tactics,
                    FullName0 = fullName0,

                    Number0 = number0,

                    FullName1 = fullName1,

                    Number1 = number1,


                    FullName2 = fullName2,

                    Number2 = number2,


                    FullName3 = fullName3,

                    Number3 = number3,


                    FullName4 = fullName4,

                    Number4 = number4,


                    FullName5 = fullName5,

                    Number5 = number5,


                    FullName6 = fullName6,

                    Number6 = number6,


                    FullName7 = fullName7,

                    Number7 = number7,


                    FullName8 = fullName8,

                    Number8 = number8,

                    FullName9 = fullName7,

                    Number9 = number7,


                    FullName10 = fullName10,

                    Number10 = number10,

                    Position0 = dd,
                    Position1 = dd,
                    Position2 = dd,
                    Position3 = dd,
                    Position4 = dd,

                    Position5 = md,
                    Position6 = md,
                    Position7 = md,

                    Position8 = f,
                    Position9 = f,

                    Position10 = gk,

                });

                DateTime d = DateTime.Now;


                var xml = new XmlSerializer(typeof(List<Team>));
                using (var fs = new FileStream($@"Data\{d.ToString("MM dd yyyy_HH mm ss")}.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, teams);
                }

                Team team = null;

                var xml2 = new XmlSerializer(typeof(List<Team>));

                using (var fs2 = new FileStream($@"Data\{d.ToString("MM dd yyyy_HH mm ss")}.xml", FileMode.OpenOrCreate))
                {
                    team = xml2.Deserialize(fs2) as Team;

                }


                ViewTeam form2 = new ViewTeam(fullName0, fullName1, fullName2, fullName3, fullName4, fullName5, fullName6, fullName7, fullName8, fullName9, fullName10, number0, number1, number2, number3, number4, number5, number6, number7, number8, number9, number10, Countrylabel1.Text);
                form2.Show();
                this.Hide();
            }


            if (Positionguna2ComboBox1.Text == "3 3 4")
            {



                u[0].FullName = u[0].FullNametextBox.Text;
                fullName0 = u[0].FullName;

                u[1].FullName = u[1].FullNametextBox.Text;
                fullName1 = u[1].FullName;


                u[2].FullName = u[2].FullNametextBox.Text;
                fullName2 = u[2].FullName;


                u[3].FullName = u[3].FullNametextBox.Text;
                fullName3 = u[3].FullName;


                u[4].FullName = u[4].FullNametextBox.Text;
                fullName4 = u[4].FullName;


                u[5].FullName = u[5].FullNametextBox.Text;
                fullName5 = u[5].FullName;


                u[6].FullName = u[6].FullNametextBox.Text;
                fullName6 = u[6].FullName;


                u[7].FullName = u[7].FullNametextBox.Text;
                fullName7 = u[7].FullName;

                u[8].FullName = u[8].FullNametextBox.Text;
                fullName8 = u[8].FullName;


                u[9].FullName = u[9].FullNametextBox.Text;
                fullName9 = u[9].FullName;

                u[10].FullName = u[10].FullNametextBox.Text;
                fullName10 = u[10].FullName;

                u[0].Number = u[0].NumbertextBox.Text;
                number0 = u[0].Number;

                u[1].Number = u[1].NumbertextBox.Text;
                number1 = u[1].Number;


                u[2].Number = u[2].NumbertextBox.Text;
                number2 = u[2].Number;


                u[3].Number = u[3].NumbertextBox.Text;
                number3 = u[3].Number;


                u[4].Number = u[4].NumbertextBox.Text;
                number4 = u[4].Number;


                u[5].Number = u[5].NumbertextBox.Text;
                number5 = u[5].Number;


                u[6].Number = u[6].NumbertextBox.Text;
                number6 = u[6].Number;


                u[7].Number = u[7].NumbertextBox.Text;
                number7 = u[7].Number;

                u[8].Number = u[8].NumbertextBox.Text;
                number8 = u[8].Number;


                u[9].Number = u[9].NumbertextBox.Text;
                number9 = u[9].Number;

                u[10].Number = u[10].NumbertextBox.Text;
                number10 = u[10].Number;

                List<Team> teams = new List<Team>();

                teams.Add(new Team(country, tactics, fullName0, number0, fullName1, number1, fullName2, number2, fullName3, number3, fullName4, number4, fullName5, number5, fullName6, number6, fullName7, number7, fullName8, number8, fullName9, number9, fullName10, number10)
                {

                    Country = country,
                    Tactics = tactics,

                    FullName0 = fullName0,

                    Number0 = number0,

                    FullName1 = fullName1,

                    Number1 = number1,


                    FullName2 = fullName2,

                    Number2 = number2,


                    FullName3 = fullName3,

                    Number3 = number3,


                    FullName4 = fullName4,

                    Number4 = number4,


                    FullName5 = fullName5,

                    Number5 = number5,


                    FullName6 = fullName6,

                    Number6 = number6,


                    FullName7 = fullName7,

                    Number7 = number7,


                    FullName8 = fullName8,

                    Number8 = number8,

                    FullName9 = fullName7,

                    Number9 = number7,


                    FullName10 = fullName10,

                    Number10 = number10,

                    Position0 = dd,
                    Position1 = dd,
                    Position2 = dd,

                    Position3 = md,
                    Position4 = md,
                    Position5 = md,

                    Position6 = f,
                    Position7 = f,
                    Position8 = f,
                    Position9 = f,

                    Position10 = gk,

                });

                DateTime d = DateTime.Now;


                var xml = new XmlSerializer(typeof(List<Team>));
                using (var fs = new FileStream($@"Data\{d.ToString("MM dd yyyy_HH mm ss")}.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, teams);
                }

                Team team = null;

                var xml2 = new XmlSerializer(typeof(List<Team>));

                using (var fs2 = new FileStream($@"Data\{d.ToString("MM dd yyyy_HH mm ss")}.xml", FileMode.OpenOrCreate))
                {
                    team = xml2.Deserialize(fs2) as Team;

                }


                ViewTeam334 form3 = new ViewTeam334(fullName0, fullName1, fullName2, fullName3, fullName4, fullName5, fullName6, fullName7, fullName8, fullName9, fullName10, number0, number1, number2, number3, number4, number5, number6, number7, number8, number9, number10, Countrylabel1.Text);
                form3.Show();
                this.Hide();
            }
        }

 

        private void CountrycomboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CountrycomboBox1.Text == "Azerbaijan")
            {
                Countrylabel1.Text = "Azerbaijan";
            }
            if (CountrycomboBox1.Text == "Turkey")
            {
                Countrylabel1.Text = "Turkey";
            }
            if (CountrycomboBox1.Text == "Kazakhstan")
            {
                Countrylabel1.Text = "Kazakhstan";
            }
            if (CountrycomboBox1.Text == "Kyrgyzstan")
            {
                Countrylabel1.Text = "Kyrgyzstan";
            }
            if (CountrycomboBox1.Text == "Uzbekistan")
            {
                Countrylabel1.Text = "Uzbekistan";
            }
            if (CountrycomboBox1.Text == "Turkmenistan")
            {
                Countrylabel1.Text = "Turkmenistan";
            }
            if (CountrycomboBox1.Text == "Germany")
            {
                Countrylabel1.Text = "Germany";
            }
            if (CountrycomboBox1.Text == "Denmark")
            {
                Countrylabel1.Text = "Denmark";
            }
            if (CountrycomboBox1.Text == "Norway")
            {
                Countrylabel1.Text = "Norway";
            }
            if (CountrycomboBox1.Text == "Sweden")
            {
                Countrylabel1.Text = "Sweden";
            }
            if (CountrycomboBox1.Text == "Finland")
            {
                Countrylabel1.Text = "Finland";
            }
            if (CountrycomboBox1.Text == "Estonia")
            {
                Countrylabel1.Text = "Estonia";
            }
            if (CountrycomboBox1.Text == "Latvia")
            {
                Countrylabel1.Text = "Latvia";
            }
            if (CountrycomboBox1.Text == "Lithuania")
            {
                Countrylabel1.Text = "Lithuania";
            }
            if (CountrycomboBox1.Text == "Poland")
            {
                Countrylabel1.Text = "Poland";
            }
            if (CountrycomboBox1.Text == "Ukraine")
            {
                Countrylabel1.Text = "Ukraine";
            }
            if (CountrycomboBox1.Text == "Georgia")
            {
                Countrylabel1.Text = "Georgia";
            }
            
        }
    }
}
