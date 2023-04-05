using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare a class and with different type of access modifier (propertise+method)

namespace oop
{
    public class Prob1
    {
        public string firstName { get; set; }
        protected string lastName { get; set; }

        internal string city { get; set; }
            private string country { get; set; }

        //public
        public void SetFirstName(string firstName)
        {

        }
        //Private
        void SetLastName(string lastName)
        {

        }
        //Protected
        protected void SetCountryName(string country)
        {

        }

        //Internal
        internal void SetCityName(string city)
        {

        }


    }
}
