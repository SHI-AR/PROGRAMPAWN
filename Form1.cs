using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 1:
                    button3.Text = "ALARM8:00";
                    break;
                case 2:
                    button3.Text = "ALARM9:00";
                    break;
                case 3:
                    button3.Text = "ALARM10:00";
                    break;
                case 4:
                    button3.Text = "ALARM11:00";
                    break;
                case 5:
                    button3.Text = "ALARM12:00";
                    break;
                default:
                    break;
            }


        }
        public static int yes = 0, yes2 = 0, yes3 = 0, yes4 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (button2.Text == "NEXTPROG" && yes > 0 && yes2 > 0 && yes3 > 0 && yes4 == 0)
                System.Environment.Exit(1);
            if (button2.Text == "CARSNEXT" && yes > 0 && yes2 > 0 && yes3 > 0)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.KIA_FORTE;
                button2.Text = "NEXTPROG";
            }
            if (button2.Text == "CARTNEXT" && yes > 0 && yes2 > 0 && yes3 == 0)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.CART;
                button2.Text = "CARSNEXT";
                yes3++;
            }
            if (button2.Text == "ORDERSNEXT" && yes > 0 && yes2 == 0) 
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.ORDERS1;
                button2.Text = "CARTNEXT";
                yes2++;
            }
            if (button2.Text == "AMAZONNEXT" && yes == 0)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.AMAZON;
                button2.Text = "ORDERSNEXT";
                yes++;
            }
        }
    }
}
