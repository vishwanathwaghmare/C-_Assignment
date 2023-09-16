using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    /*5)You need to create mobile phones for apple for a special edition. In this edition the color of all the
    phones has to be &quot;Space Grey&quot;. Make sure that the color can never be changed once applied in the
    system.*/

    class ApplePhone
    {
        // Private set allows setting the color only within this class
        public string Color { get; private set; }

        // Constructor to set the color during object creation
        public ApplePhone()
        {
            Color = "Space Grey";
        }

        public void DisplayPhoneDetails()
        {
            Console.WriteLine($"Apple Phone - Color: {Color}");
        }
    }

    class Mobile
    {
        static void Main(string[] args)
        {
            ApplePhone specialEditionPhone = new ApplePhone();
            specialEditionPhone.DisplayPhoneDetails();

            // Attempting to change the color will result in a compilation error
            // specialEditionPhone.Color = "Silver";
        }
    }

}
