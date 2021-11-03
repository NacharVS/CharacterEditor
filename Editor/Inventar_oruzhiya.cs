using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Editor
{
    public partial class Inventar_oruzhiya : Form
    {
        public int m_uron;
        public int p_uron;
        public int critical_chance = 5;
        public Inventar_oruzhiya()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dop_okno1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randoom = rnd.Next(1, 2);
            int randoom2 = rnd.Next(2, 5);
            int bow = rnd.Next(1/2 , 3);
            if (comboBox1.Text == "Меч")
            {
                p_uron = 25;
                critical_chance *= 2;
                pictureBox1.Image = Properties.Resources.mech;
                if (radioButton1.Checked == true)
                {
                    p_uron *= randoom;
                    m_uron *= randoom;
                }
                if (radioButton2.Checked == true)
                {
                    p_uron *= randoom2;
                    m_uron *= randoom2;
                }
            }
            if (comboBox1.Text == "Топор")
            {
                pictureBox1.Image = Properties.Resources.topor;
                p_uron = 10;
                m_uron = 10;
                critical_chance *= 4;
                if (radioButton1.Checked == true)
                {
                    p_uron *= randoom;
                    m_uron *= randoom;
                }
                if (radioButton2.Checked == true)
                {
                    p_uron *= randoom2;
                    m_uron *= randoom2;
                }
            }
            if (comboBox1.Text == "Лук")
            {
                pictureBox1.Image = Properties.Resources.luck;
                p_uron = 20;
                critical_chance *= 3;
                m_uron = 5;
                if (radioButton1.Checked == true)
                {
                    p_uron *= randoom;
                    m_uron *= randoom;
                }
                if   (radioButton2.Checked == true)
                    {
                    p_uron *= bow;
                    m_uron *= bow;
                }
            }
            if (comboBox1.Text == "Волшебная палочка")
            {
                pictureBox1.Image = Properties.Resources.posoh;

                p_uron = 5;
                m_uron = 25;
                critical_chance *=  3;
                if (radioButton1.Checked == true)
                {
                    p_uron *= randoom;
                    m_uron *= randoom;
                }
                if(radioButton2.Checked == true)
                {
                    p_uron *= randoom2;
                    m_uron *= randoom2;
                }
            }
            comboBox1.Enabled = false;
            label2.Text = $"{p_uron}";
            label3.Text = $"{m_uron}";
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
