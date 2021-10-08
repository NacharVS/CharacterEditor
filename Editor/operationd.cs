using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    class operationd
    {
        public static void ButtonsOff(int extraPoints, Button button, Button button1, Button button2, Button button3,Button button4, Button button5, Button button6, Button button7)
        {

                
            if (1 < extraPoints || extraPoints < 20)
            {
                button.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                if (extraPoints > 1 || extraPoints > 20) 
                {
                    button.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = true;
                   button5.Enabled = true;
                   button6.Enabled = true;
                   button7.Enabled = true;
                    if(1 < extraPoints && extraPoints < 19)
                    {
                        button.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                    }
                }
            }
        }
        public static void Malo(int extraPoints1, Button button6, Button button4, Button button2, Button button8)
        {
            if (extraPoints1 >= 1)
            {
                button2.Enabled = true;
                button6.Enabled = true;
                button4.Enabled = true;
                button8.Enabled = true;
            }
            if (extraPoints1 == 0)
            {
                button2.Enabled = false;
                button6.Enabled = false;
                button4.Enabled = false;
                button8.Enabled = false;
            }
        }

    }
}
