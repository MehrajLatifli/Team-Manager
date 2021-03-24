using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Manager
{
   public class Team
    {
        public Team()
        {

        }

        public Team(string country, string tactics)
        {
            Country = country;
            Tactics = tactics;
        }

        public Team(string country, string tactics, string fullName0,  string number0, string fullName1,  string number1, string fullName2,  string number2, string fullName3,  string number3, string fullName4,  string number4, string fullName5, string number5, string fullName6, string number6, string fullName7, string number7, string fullName8, string number8, string fullName9, string number9, string fullName10, string number10)
        {
            Country = country;
            Tactics = tactics;

            FullName0 = fullName0;
     
            Number0 = number0;
            FullName1 = fullName1;
       
            Number1 = number1;
            FullName2 = fullName2;
       
            Number2 = number2;
            FullName3 = fullName3;
       
            Number3 = number3;
            FullName4 = fullName4;
    
            Number4 = number4;
            FullName5 = fullName5;
   
            Number5 = number5;
            FullName6 = fullName6;
     
            Number6 = number6;
            FullName7 = fullName7;

            Number7 = number7;
            FullName8 = fullName8;
  
            Number8 = number8;
            FullName9 = fullName9;
 
            Number9 = number9;
            FullName10 = fullName10;
     
            Number10 = number10;
        }

        public string Country { get; set; }
        public string Tactics { get; set; }


        public string FullName0 { get; set; }
        public string Number0 { get; set; }
        public string Position0 { get; set; }

        public string FullName1 { get; set; }
        public string Number1 { get; set; }
        public string Position1 { get; set; }

        public string FullName2 { get; set; }
        public string Position2 { get; set; }
        public string Number2 { get; set; }

        public string FullName3 { get; set; }
        public string Position3 { get; set; }
        public string Number3 { get; set; }

        public string FullName4 { get; set; }
        public string Position4 { get; set; }
        public string Number4 { get; set; }

        public string Position5 { get; set; }
        public string FullName5 { get; set; }
        public string Number5 { get; set; }

        public string FullName6 { get; set; }
        public string Number6 { get; set; }
       public string Position6 { get; set; }

        public string FullName7 { get; set; }
        public string Position7 { get; set; }
        public string Number7 { get; set; }

        public string FullName8 { get; set; }
        public string Position8 { get; set; }
        public string Number8 { get; set; }

        public string FullName9 { get; set; }
        public string Position9 { get; set; }
        public string Number9 { get; set; }

        public string FullName10 { get; set; }
        public string Position10 { get; set; }
        public string Number10 { get; set; }


    }
}
