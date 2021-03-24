using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Team_Manager
{
    public partial class MemberOfTeam : UserControl
    {
        
        public MemberOfTeam()
        {
            InitializeComponent();

           
        }


      


        public string Position
        {

            get { return PositiontextBox.Text; }
            set { PositiontextBox.Text = value; }

         

        }

    
        public string Number
        {

            get { return NumbertextBox.Text; }
            set { NumbertextBox.Text = value; }

        }

        
        public string FullName
        {

            get 
            {
                return FullNametextBox.Text;
            }

            set 
            {

                FullNametextBox.Text=value; 
            }

        }


        public string uFull = "GK";




        public void SavetoFile()
        {

  




        



            /*
            string sourceFile = $@"Data";
            string destFile = $@"Data2";

            var extensions = new[] { ".xml" }; // not sure if you really wanted to filter by extension or not, it kinda seemed like maybe you did. if not, comment this out

            var files = (from file in Directory.EnumerateFiles(sourceFile)
                         where extensions.Contains(Path.GetExtension(file), StringComparer.InvariantCultureIgnoreCase) // comment this out if you don't want to filter extensions
                         select new
                         {
                             Source = file,
                             Destination = Path.Combine(destFile, Path.GetFileName(file))
                         });

            foreach (var file in files)
            {
                File.Copy(file.Source, file.Destination,true);
            }

            */

            // System.IO.File.Copy($@"Data\{d.ToString("MM dd yyyy_HH mm ss")}.xml", $@"Data\General.xml", true);



      

        }

        private void NtextBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        public string s2 = "";
        private void NtextBox22_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void Createguna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void FullNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
