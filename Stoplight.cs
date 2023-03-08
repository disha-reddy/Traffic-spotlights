using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    //class for the stoplight objects
    class Stoplight
    {
        //private variable name for the light colour
        private string color;

        //Method Name: Stoplight
        /*Description: This is a constructor that aids in the building of a class object.
        The stoplight's default color is red at first.*/
        public Stoplight()
        {
            this.color = "red";
        }

         //Method Name: GetColor
        //Description: a getter method that returns the object's color attribute
        public string GetColor()
        {
            return this.color;
        }

        //Method Name: ChangeC
        //Description: This is a method for changing the stoplight object's color attribute.
        public void ChangeC(string color)
        {
            this.color = color;
        }

       
    }
}
