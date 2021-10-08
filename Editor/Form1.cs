using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        int strenght = 20;
        int doxterity = 20;
        int intelligence = 20;
        int constitution = 20;
        int hp;
        int dop=200;
        int P_Attack = 20;
        int M_Attack = 20;
        int P_Defence = 20;
        int M_Degence = 20;
        int Attack_Speed = 20;
        int Walking_speed = 20;
        int HP = 100;
        int MP = 100;
        int lvl = 1;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            operationd.Malo(int.Parse(textBox2.Text), button2, button4, button6, button8);
            intelligence = intelligence - 1;
            textBox2.Text = $"{intelligence}";
            dop = dop + 1;
            label7.Text = $"{dop}";
            M_Attack -= 10;
            label13.Text = $"{M_Attack}";
            M_Degence -= 5;
            label15.Text = $"{M_Degence}";
            MP -= 5;
            label23.Text = $"{MP}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Warrior")
            {
                strenght = 30;
                constitution =25;
                intelligence =  10;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                comboBox1.Enabled = false;
                if (strenght <= 30 && constitution <= 25 && intelligence <= 10 && comboBox1.Text == "Warrior")
                {
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;

                }
                

            }
                
            if (comboBox1.Text == "Mage")
            {
                intelligence = 30;
                strenght = 10;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                comboBox1.Enabled = false;

                if (strenght <= 10 || doxterity <= 20 || constitution <= 20 || intelligence <= 30 && comboBox1.Text == "Mage")
                {
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;

                }
               
            } 
                
            if (comboBox1.Text == "Archer")
            {
                doxterity = 30;
                constitution = 15;
                strenght = 15;
                intelligence = 25;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                comboBox1.Enabled = false;
                if (doxterity <= 30 || constitution <= 15 || strenght <= 15 || intelligence <= 25 ) 
                {
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                }
               
            }
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((strenght <= 30 || constitution <= 25 || doxterity <= 20 || intelligence <= 10) && comboBox1.Text == "Warrior")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
                if ((strenght >= 250 || doxterity >= 70 || constitution >= 100 || intelligence >= 50) && comboBox1.Text == "Warrior") 
                {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
                }
            if ((strenght <= 10 || doxterity <= 20 || constitution <= 20 || intelligence <= 30) && comboBox1.Text == "Mage")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 50 || doxterity >= 50 || constitution >= 50 || intelligence >= 250) && comboBox1.Text == "Mage")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((doxterity <= 30 || constitution <= 15 || strenght <= 15 || intelligence <= 25) && comboBox1.Text == "Archer")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
            }
            if ((strenght >= 60 || doxterity >= 250 || constitution >= 60 || intelligence >= 100) && comboBox1.Text == "Archer")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((strenght <= 30 || constitution <= 25 || doxterity <= 20 || intelligence <= 10) && comboBox1.Text == "Warrior")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 250 || doxterity >= 70 || constitution >= 100 || intelligence >= 50) && comboBox1.Text == "Warrior")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((strenght <= 10 || doxterity <= 20 || constitution <= 20 || intelligence <= 30) && comboBox1.Text == "Mage")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 50 || doxterity >= 50 || constitution >= 50 || intelligence >= 250) && comboBox1.Text == "Mage")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((doxterity <= 30 || constitution <= 15 || strenght <= 15 || intelligence <= 25) && comboBox1.Text == "Archer")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
            }
            if ((strenght >= 60 || doxterity >= 250 || constitution >= 60 || intelligence >= 100) && comboBox1.Text == "Archer")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((strenght <= 30 || constitution <= 25 || doxterity <= 20 || intelligence <= 10) && comboBox1.Text == "Warrior")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 250 || doxterity >= 70 || constitution >= 100 || intelligence >= 50) && comboBox1.Text == "Warrior")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((strenght <= 10 || doxterity <= 20 || constitution <= 20 || intelligence <= 30) && comboBox1.Text == "Mage")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 50 || doxterity >= 50 || constitution >= 50 || intelligence >= 250) && comboBox1.Text == "Mage")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((doxterity <= 30 || constitution <= 15 || strenght <= 15 || intelligence <= 25) && comboBox1.Text == "Archer")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
            }
            if ((strenght >= 60 || doxterity >= 250 || constitution >= 60 || intelligence >= 100) && comboBox1.Text == "Archer")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if ((strenght <= 30 || constitution <= 25 || doxterity <= 20 || intelligence <= 10) && comboBox1.Text == "Warrior")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 250 || doxterity >= 70 || constitution >= 100 || intelligence >= 50) && comboBox1.Text == "Warrior")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((strenght <= 10 || doxterity <= 20 || constitution <= 20 || intelligence <= 30) && comboBox1.Text == "Mage")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;

            }
            if ((strenght >= 50 || doxterity >= 50 || constitution >= 50 || intelligence >= 250) && comboBox1.Text == "Mage")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if ((doxterity <= 30 || constitution <= 15 || strenght <= 15 || intelligence <= 25) && comboBox1.Text == "Archer")
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
            }
            if ((strenght >= 60 || doxterity >= 250 || constitution >= 60 || intelligence >= 100) && comboBox1.Text == "Archer")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
            }

        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            
            label7.Text =  $"{dop}";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label12.Text = $"{P_Attack}";
            label13.Text = $"{M_Attack}";
            label14.Text = $"{P_Defence}";
            label15.Text = $"{M_Degence}";
            label18.Text = $"{Attack_Speed}";
            label19.Text = $"{Walking_speed}";
            label22.Text = $"{HP}";
            label23.Text = $"{MP}";
            textBox1.Text =$"{constitution}" ;
            textBox2.Text = $"{intelligence}";
            textBox3.Text = $"{doxterity}";
            textBox4.Text = $"{strenght}";

            if (radioButton1.Checked == true)
            {
                M_Degence += 10;
                label15.Text = $"{M_Degence}";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            strenght = strenght + 1;
            textBox4.Text = $"{strenght}";
            dop = dop - 1;
            label7.Text = $"{dop}";
             
            
                P_Attack = P_Attack + 5;
            label12.Text = $"{P_Attack}";
                HP = HP + 5;
            label22.Text = $"{HP}";

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8,button7, button5, button9, button1);
            
            
            dop = dop - 1;
            label7.Text = $"{dop}";
            Attack_Speed = Attack_Speed + 5;
            label18.Text = $"{Attack_Speed}";
            Walking_speed = Walking_speed + 2;
            label19.Text = $"{Walking_speed}";
            textBox3.Text = $"{doxterity}";
            doxterity = doxterity + 1;
            P_Defence += 3;
            label14.Text = $"{P_Defence}";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            intelligence = intelligence + 1;
            textBox2.Text = $"{intelligence}";
            dop = dop - 1;
            label7.Text = $"{dop}";
            M_Attack += 10;
            label13.Text = $"{M_Attack}";
            M_Degence += 5;
            label15.Text = $"{M_Degence}";
            MP += 5;
            label23.Text = $"{MP}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            constitution = constitution + 1;
            textBox1.Text = $"{constitution}";
            dop = dop - 1;
            label7.Text = $"{dop}";
            P_Defence += 5;
            label14.Text = $"{P_Defence}";
            HP += 10;
            label22.Text = $"{HP}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            operationd.Malo(int.Parse(textBox4.Text), button2, button4, button6, button8);
            strenght = strenght - 1;
            textBox4.Text = $"{strenght}";
            dop = dop + 1;
            label7.Text = $"{dop}";
                P_Attack = P_Attack - 5;
            label12.Text = $"{P_Attack}";
                HP = HP - 5;
            label22.Text = $"{HP}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            operationd.Malo(int.Parse(textBox3.Text), button2, button4, button6, button8);
            doxterity = doxterity - 1;
            textBox3.Text = $"{doxterity}";
            dop = dop + 1;
            label7.Text = $"{dop}";
            Attack_Speed = Attack_Speed - 5;
            label18.Text = $"{Attack_Speed}";
            Walking_speed = Walking_speed - 2;
            label19.Text = $"{Walking_speed}";
            textBox2.Text = $"{intelligence}";
            P_Defence += 3;
            label14.Text = $"{P_Defence}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operationd.ButtonsOff(int.Parse((label7.Text)), button2, button4, button6, button8, button7, button5, button9, button1);
            operationd.Malo(int.Parse(textBox1.Text), button2, button4, button6, button8);
            constitution = constitution - 1;
            textBox1.Text = $"{constitution}";
            dop = dop + 1;
            label7.Text = $"{dop}";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text =$"{constitution}" ;
            textBox2.Text = $"{intelligence}";
            textBox3.Text = $"{doxterity}";
            textBox4.Text =$"{strenght}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true /*&& lvl == 2*/)
            {
                
                radioButton1.Enabled = false;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;

                M_Degence += 10;
                label15.Text = $"{M_Degence}";
                P_Defence += 5;
                label14.Text = $"{P_Defence}";
                intelligence = intelligence + rnd;
                textBox2.Text = $"{intelligence}";
                MP += 5;
                label23.Text = $"{MP}";
                M_Attack += 5;
                label13.Text = $"{M_Attack}";
                P_Defence -= 3;
                label14.Text = $"{P_Defence}";

                /////////////////////////////
                

            }

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true /*&& lvl == 2*/)
            {
                radioButton1.Enabled = true; 
                radioButton2.Enabled = false;
                radioButton3.Enabled = true;


            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true /*&& lvl == 2*/)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
