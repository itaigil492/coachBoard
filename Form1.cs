using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nawtonsoft.json;
Random RN =new Random();
		
		Dictionary<string, Dictionary<string, Dictionary<string, int>>> TeamInfo = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
			Dictionary<string, Dictionary<string, int>> Game1 = new Dictionary<string, Dictionary<string, int>>();
			Dictionary<string, Dictionary<string, int>> Game2 = new Dictionary<string, Dictionary<string, int>>();
			Dictionary<string, Dictionary<string, int>> Game3 = new Dictionary<string, Dictionary<string, int>>();
		Dictionary<string, int> MisCarGame1 = new Dictionary<string, int>();
		MisCarGame1.Add("number", 1574);
		MisCarGame1.Add("Panel", RN.Next(0,7));
		MisCarGame1.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> OrbitGame1 = new Dictionary<string, int>();
		OrbitGame1.Add("number", 1690);
		OrbitGame1.Add("Panel", RN.Next(0,7));
		OrbitGame1.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> DbugGame1 = new Dictionary<string, int>();
		DbugGame1.Add("number", 3316);
		DbugGame1.Add("Panel", RN.Next(0,7));
		DbugGame1.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> GeneralAngelsGame1 = new Dictionary<string, int>();
		GeneralAngelsGame1.Add("number", 2230);
		GeneralAngelsGame1.Add("Panel", RN.Next(0,7));
		GeneralAngelsGame1.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> GreenBlitzGame1 = new Dictionary<string, int>();
		GreenBlitzGame1.Add("number", 4590);
		GreenBlitzGame1.Add("Panel", RN.Next(0,7));
		GreenBlitzGame1.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> TheSpikesGame1 = new Dictionary<string, int>();
		TheSpikesGame1.Add("number", 2212);
		TheSpikesGame1.Add("Panel", RN.Next(0,7));
		TheSpikesGame1.Add("Cargo", RN.Next(0,7));
		
		
				Dictionary<string, int> MisCarGame2 = new Dictionary<string, int>();
		MisCarGame2.Add("number", 1574);
		MisCarGame2.Add("Panel", RN.Next(0,7));
		MisCarGame2.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> OrbitGame2 = new Dictionary<string, int>();
		OrbitGame2.Add("number", 1690);
		OrbitGame2.Add("Panel", RN.Next(0,7));
		OrbitGame2.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> DbugGame2 = new Dictionary<string, int>();
		DbugGame2.Add("number", 3316);
		DbugGame2.Add("Panel", RN.Next(0,7));
		DbugGame2.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> GeneralAngelsGame2 = new Dictionary<string, int>();
		GeneralAngelsGame2.Add("number", 2230);
		GeneralAngelsGame2.Add("Panel", RN.Next(0,7));
		GeneralAngelsGame2.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> GreenBlitzGame2 = new Dictionary<string, int>();
		GreenBlitzGame2.Add("number", 4590);
		GreenBlitzGame2.Add("Panel", RN.Next(0,7));
		GreenBlitzGame2.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> TheSpikesGame2 = new Dictionary<string, int>();
		TheSpikesGame2.Add("number", 2212);
		TheSpikesGame2.Add("Panel", RN.Next(0,7));
		TheSpikesGame2.Add("Cargo", RN.Next(0,7));
		
				Dictionary<string, int> MisCarGame3 = new Dictionary<string, int>();
		MisCarGame3.Add("number", 1574);
		MisCarGame3.Add("Panel", RN.Next(0,7));
		MisCarGame3.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> OrbitGame3 = new Dictionary<string, int>();
		OrbitGame3.Add("number", 1690);
		OrbitGame3.Add("Panel", RN.Next(0,7));
		OrbitGame3.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> DbugGame3 = new Dictionary<string, int>();
		DbugGame3.Add("number", 3316);
		DbugGame3.Add("Panel", RN.Next(0,7));
		DbugGame3.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> GeneralAngelsGame3 = new Dictionary<string, int>();
		GeneralAngelsGame3.Add("number", 2230);
		GeneralAngelsGame3.Add("Panel", RN.Next(0,7));
		GeneralAngelsGame3.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> GreenBlitzGame3 = new Dictionary<string, int>();
		GreenBlitzGame3.Add("number", 4590);
		GreenBlitzGame3.Add("Panel", RN.Next(0,7));
		GreenBlitzGame3.Add("Cargo", RN.Next(0,7));
		
		Dictionary<string, int> TheSpikesGame3 = new Dictionary<string, int>();
		TheSpikesGame3.Add("number", 2212);
		TheSpikesGame3.Add("Panel", RN.Next(0,7));
		TheSpikesGame3.Add("Cargo", RN.Next(0,7));
		
		
		Game1.Add("GreenBlitz", GreenBlitzGame1);
		Game1.Add("MisCar", MisCarGame1);
		Game1.Add("Orbit", OrbitGame1);
		Game1.Add("Dbug", DbugGame1);
		Game1.Add("GeneralAngels", GeneralAngelsGame1);
		Game1.Add("TheSpikes", TheSpikesGame1);
		Game2.Add("GreenBlitz", GreenBlitzGame2);
		Game2.Add("MisCar", MisCarGame2);
		Game2.Add("Orbit", OrbitGame2);
		Game2.Add("Dbug", DbugGame2);
		Game2.Add("GeneralAngels", GeneralAngelsGame2);
		Game2.Add("TheSpikes", TheSpikesGame2);
		Game3.Add("GreenBlitz", GreenBlitzGame3);
		Game3.Add("MisCar", MisCarGame3);
		Game3.Add("Orbit", OrbitGame3);
		Game3.Add("Dbug", DbugGame3);
		Game3.Add("GeneralAngels", GeneralAngelsGame3);
		Game3.Add("TheSpikes", TheSpikesGame3);
		TeamInfo.Add("Game1", Game1);
		TeamInfo.Add("Game2", Game2);
		TeamInfo.Add("Game3", Game3);

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

        public static List<double> Avg(Button button){

        }
        public static int RN(int max)  
        {  
            Random random = new Random();  
            return random.Next(max);  
        }  

    }
}
