using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create 4 spolight variables 

        //north stoplights
        Stoplight n_light = new Stoplight();

        //south stoplights
        Stoplight s_light = new Stoplight();

        //east stoplights
        Stoplight e_light = new Stoplight();

        //west stoplights
        Stoplight w_light = new Stoplight();

        //Method Name: B_BTN_Click
        /*Description: When the user presses the Backward button, 
        this function will handle the event and invoke another assistance function: Manual Switch.*/
        private void B_BTN_Click(object sender, EventArgs e)
        {
            //To cycle the system state backwards, use the assistance method Manual Switch.
            Manual_Switch("backwards");
        } 

        //Method Name: F_BTN_Click
        //Description: When the user presses the Forward button, this function will handle 
        //the event and call another assistance function: Manual Switch.
        private void F_BTN_Click(object sender, EventArgs e)
        {
            //To cycle the system state forwards, use the assistance method Manual Switch.
            Manual_Switch("forward");
        }

        /*This static variable will aid in the identification of the system's state 
        as well as the transition between states. 
        This variable will be assigned to each state and will specify which stoplight 
        should be turned on for which light. 
        The default condition is 1, which means that all of the first stoplights are red. 
        There are eight states in total.*/
        static int s = 1;


        //Method Name: Maunual_Switch
        /*Description: This is a feature that allows you to manually modify the color 
        of the stoplights based on the current state of the system. 
        The function will take a parameter that specifies whether the cycle should go forward or backward.*/
        public void Manual_Switch(string direction)
        {

            if (direction != "forward")
            {
                //We just decrease the state, but if we are currently in state 1, we return to that state.
                if (s > 1)
                {
                    s--;
                }
            }
            else {
                //Because we have a total of 8 states, we will utilize the modulo operation to keep that state in the range of 1 to 8.
                s = (s + 1) % 9;
                if (s == 0)
                {
                    s = 1;
                }
            }

            MessageBox.Show("CURRENT STATE: " + s);

                /* Now we check the state and modify the colors of the stoplight objects accordingly.
                North and south lights are red, east and west lights are green in state one.*/
            if (s == 1)
            {
                n_light.ChangeC("red");
                N_L1_BX.BackColor = Color.Red;

                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;

                e_light.ChangeC("green");
                E_L1_BX.BackColor = Color.Green;

                w_light.ChangeC("green");]
                W_L1_BX.BackColor = Color.Green;
            }
            //state 2: all the light are red
            else if (s == 2)
            {
                n_light.ChangeC("red");
                N_L1_BX.BackColor = Color.Red;

                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;

                e_light.ChangeC("red");
                E_L1_BX.BackColor = Color.Red;

                w_light.ChangeC("red");
                W_L1_BX.BackColor = Color.Red;
            }
            //state 3: north light green, the rest stay at their previous colour
            else if (s == 3)
            {
                n_light.ChangeC("green");
                N_L1_BX.BackColor = Color.Green;

                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;

                e_light.ChangeC("red");
                E_L1_BX.BackColor = Color.Red;

                w_light.ChangeC("red");
                W_L1_BX.BackColor = Color.Red;
            }
            //state 4: south light green, the rest stay the same
            else if (s == 4)
            {
                
                n_light.ChangeC("green");
                N_L1_BX.BackColor = Color.Green;

                s_light.ChangeC("green");
                S_L1_BX.BackColor = Color.Green;

                e_light.ChangeC("red");
                E_L1_BX.BackColor = Color.Red;

                w_light.ChangeC("red");
                W_L1_BX.BackColor = Color.Red;
            }
            //state 5: north and south lights red, the rest stay the same
            else if (s == 5)
            {
                n_light.ChangeC("red");
                N_L1_BX.BackColor = Color.Red;

                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;

                e_light.ChangeC("red");
                E_L1_BX.BackColor = Color.Red;

                w_light.ChangeC("red");
                W_L1_BX.BackColor = Color.Red;
            }
            //state 6: east light green, the rest stay the same
            else if (s == 6)
            { 
                
                n_light.ChangeC("red");
                N_L1_BX.BackColor = Color.Red;

                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;

                e_light.ChangeC("green");
                E_L1_BX.BackColor = Color.Green;

                w_light.ChangeC("red");
                W_L1_BX.BackColor = Color.Red;
            }
            //state 7: west light green, the rest stay the same
            else if (s == 7)
            { 
                
                n_light.ChangeC("red");
                N_L1_BX.BackColor = Color.Red;
                 
                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;

                e_light.ChangeC("green");
                E_L1_BX.BackColor = Color.Green;

                w_light.ChangeC("green");
                W_L1_BX.BackColor = Color.Green;

            }
            //state 8: east and west lights red, the rest stay the same
            else
            {
                n_light.ChangeC("red");
                N_L1_BX.BackColor = Color.Red;

                s_light.ChangeC("red");
                S_L1_BX.BackColor = Color.Red;
                
                e_light.ChangeC("red");
                E_L1_BX.BackColor = Color.Red;

                w_light.ChangeC("red");
                W_L1_BX.BackColor = Color.Red;

               
            }

            //print all spotlights
            Console.WriteLine("\n\nCURRENT STATE: " + s);
            Console.WriteLine("\nNorth light: " + n_light.GetColor());
            Console.WriteLine("South light: " + s_light.GetColor());
            Console.WriteLine("East light: " + e_light.GetColor());
            Console.WriteLine("West light: " + w_light.GetColor());
        }
    }
}
