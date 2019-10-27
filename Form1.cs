using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppThird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool MenuOpen = false;
        int NumButton = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MenuOpen == false) 
            {   
                panel1.Height += 853;
                MenuOpen = true;
            }
            else if (MenuOpen == true)
            {
                panel1.Height -= 853;
                MenuOpen = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (NumButton == 2)
            {
                button1.Text = "תפריט";
                panel1.Height -= 853;
                MenuOpen = false;
                NumButton = 0;
            }
            else
            {
                button1.Text = "נתונים מסוג א";
                NumButton = 2;
                panel1.Height -= 853;
                MenuOpen = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NumButton == 3)
            {
                button1.Text = "תפריט";
                panel1.Height -= 853;
                MenuOpen = false;
                NumButton = 0;
            }
            else
            {
                button1.Text = "נתונים מסוג ב";
                NumButton = 3;
                panel1.Height -= 853;
                MenuOpen = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NumButton == 4)
            {
                button1.Text = "תפריט";
                panel1.Height -= 853;
                MenuOpen = false;
                NumButton = 0;
            }
            else
            {
                button1.Text = "נתונים מסוג ג";
                NumButton = 4;
                panel1.Height -= 853;
                MenuOpen = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NumButton == 5)
            {
                button1.Text = "תפריט";
                panel1.Height -= 853;
                MenuOpen = false;
                NumButton = 0;
            }
            else
            {
                button1.Text = "נתונים מסוג ד";
                NumButton = 5;
                panel1.Height -= 853;
                MenuOpen = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
