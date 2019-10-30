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

		


namespace WindowsFormsAppThird
{
    public partial class Form1 : Form
    {
        Random RN =new Random();
    	Dictionary<string, int> MisCarGame1 = new Dictionary<string, int>(){
            ("number", 1574),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
        };
		
		Dictionary<string, int> OrbitGame1 = new Dictionary<string, int>(){
            ("number", 1690),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		Dictionary<string, int> DbugGame1 = new Dictionary<string, int>(){
            ("number", 3316),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		Dictionary<string, int> GeneralAngelsGame1 = new Dictionary<string, int>(){
            ("number", 2230),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> GreenBlitzGame1 = new Dictionary<string, int>(){
            ("number", 4590),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> TheSpikesGame1 = new Dictionary<string, int>(){
            ("number", 2212),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		
		Dictionary<string, int> MisCarGame2 = new Dictionary<string, int>(){
            ("number", 1574),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> OrbitGame2 = new Dictionary<string, int>(){
            ("number", 1690),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> DbugGame2 = new Dictionary<string, int>(){
            ("number", 3316),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> GeneralAngelsGame2 = new Dictionary<string, int>(){
            ("number", 2230),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> GreenBlitzGame2 = new Dictionary<string, int>(){
            ("number", 4590),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> TheSpikesGame2 = new Dictionary<string, int>(){
            ("number", 2212),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
				Dictionary<string, int> MisCarGame3 = new Dictionary<string, int>(){
            ("number", 1574),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> OrbitGame3 = new Dictionary<string, int>(){
            ("number", 1690),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> DbugGame3 = new Dictionary<string, int>(){
            ("number", 3316),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> GeneralAngelsGame3 = new Dictionary<string, int>(){
            ("number", 2230),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> GreenBlitzGame3 = new Dictionary<string, int>(){
            ("number", 4590),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};
		
		Dictionary<string, int> TheSpikesGame3 = new Dictionary<string, int>(){
            ("number", 2212),
		    ("Panel", RN.Next(0,7)),
		    ("Cargo", RN.Next(0,7))
		};

		
Dictionary<string, Dictionary<string, int>> Game1 = new Dictionary<string, Dictionary<string, int>>(){
        ("GreenBlitz", GreenBlitzGame1),
		("MisCar", MisCarGame1),
		("Orbit", OrbitGame1),
		("Dbug", DbugGame1),
		("GeneralAngels", GeneralAngelsGame1),
		("TheSpikes", TheSpikesGame1)
        };
		Dictionary<string, Dictionary<string, int>> Game2 = new Dictionary<string, Dictionary<string, int>>(){
        ("GreenBlitz", GreenBlitzGame2),
		("MisCar", MisCarGame2),
		("Orbit", OrbitGame2),
		("Dbug", DbugGame2),
		("GeneralAngels", GeneralAngelsGame2),
		("TheSpikes", TheSpikesGame2)
        };
        
		Dictionary<string, Dictionary<string, int>> Game3 = new Dictionary<string, Dictionary<string, int>>(){
        ("GreenBlitz", GreenBlitzGame3),
		("MisCar", MisCarGame3),
		("Orbit", OrbitGame3),
		("Dbug", DbugGame3),
		("GeneralAngels", GeneralAngelsGame3),
		("TheSpikes", TheSpikesGame3) 
        };

	Dictionary<string, Dictionary<string, Dictionary<string, int>>> TeamInfo = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>(){
        ("Game1", Game1),
		("Game2", Game2),
		("Game3", Game3)
        };
        public Form1()
        {
            InitializeComponent();
        }
        
        string jsondata = JsonConvert.SerializeObject(TeamInfo);
        
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
            List<double> Output = new List<double>();
            if (button.Text = "Cargo"){
            Dictionary<string, Dictionary<string, Dictionary<string, int>>> jsonoutput = JsonConvert.desiarlize<Dictionary<string, Dictionary<string, Dictionary<string, int>>>>(jsondata);
            double MisCarCargo = (jsonoutput[Game1[MisCarGame1[Cargo]]]+jsonoutput[Game2[MisCarGame2[Cargo]]]+jsonoutput[Game3[MisCarGame3[Cargo]]])/3;
            double DbugCargo = (jsonoutput[Game1[DbugGame1[Cargo]]]+jsonoutput[Game2[DbugGame2[Cargo]]]+jsonoutput[Game3[DbugGame3[Cargo]]])/3;
            double OrbitCargo = (jsonoutput[Game1[OrbitGame1[Cargo]]]+jsonoutput[Game2[OrbitGame2[Cargo]]]+jsonoutput[Game3[OrbitGame3[Cargo]]])/3;
            double GeneralAngelsCargo = (jsonoutput[Game1[GeneralAngelsGame1[Cargo]]]+jsonoutput[Game2[GeneralAngelsGame2[Cargo]]]+jsonoutput[Game3[GeneralAngelsGame3[Cargo]]])/3;
            double TheSpikesCargo = (jsonoutput[Game1[TheSpikesGame1[Cargo]]]+jsonoutput[Game2[TheSpikesGame2[Cargo]]]+jsonoutput[Game3[TheSpikesGame3[Cargo]]])/3;
            double GreenBlitzCargo = (jsonoutput[Game1[GreenBlitzGame1[Cargo]]]+jsonoutput[Game2[GreenBlitzGame2[Cargo]]]+jsonoutput[Game3[GreenBlitzGame3[Cargo]]])/3;
            Output.Add(MisCarCargo);
            Output.Add(DbugCargo);
            Output.Add(OrbitCargo);
            Output.Add(GeneralAngelsCargo);
            Output.Add(TheSpikesCargo);
            Output.Add(GreenBlitzCargo);
            
            }
            else if (button.Text = "Panel"){
            Dictionary<string, Dictionary<string, Dictionary<string, int>>> jsonoutput = JsonConvert.desiarlize<Dictionary<string, Dictionary<string, Dictionary<string, int>>>>(jsondata);
            double MisCarPanels = (jsonoutput[Game1[MisCarGame1[Panels]]]+jsonoutput[Game2[MisCarGame2[Panels]]]+jsonoutput[Game3[MisCarGame3[Panels]]])/3;
            double DbugPanels = (jsonoutput[Game1[DbugGame1[Panels]]]+jsonoutput[Game2[DbugGame2[Panels]]]+jsonoutput[Game3[DbugGame3[Panels]]])/3;
            double OrbitPanels = (jsonoutput[Game1[OrbitGame1[Panels]]]+jsonoutput[Game2[OrbitGame2[Panels]]]+jsonoutput[Game3[OrbitGame3[Panels]]])/3;
            double GeneralAngelsPanels = (jsonoutput[Game1[GeneralAngelsGame1[Panels]]]+jsonoutput[Game2[GeneralAngelsGame2[Panels]]]+jsonoutput[Game3[GeneralAngelsGame3[Panels]]])/3;
            double TheSpikesPanels = (jsonoutput[Game1[TheSpikesGame1[Panels]]]+jsonoutput[Game2[TheSpikesGame2[Panels]]]+jsonoutput[Game3[TheSpikesGame3[Panels]]])/3;
            double GreenBlitzPanels = (jsonoutput[Game1[GreenBlitzGame1[Panels]]]+jsonoutput[Game2[GreenBlitzGame2[Panels]]]+jsonoutput[Game3[GreenBlitzGame3[Panels]]])/3;
            Output.Add(MisCarPanels);
            Output.Add(DbugPanels);
            Output.Add(OrbitPanels);
            Output.Add(GeneralAngelsPanels);
            Output.Add(TheSpikesPanels);
            Output.Add(GreenBlitzPanels);
            }
            return(Output);
        }
        public static int RN(int max)  
        {  
            Random random = new Random();  
            return random.Next(max);  
        }  

    }
}
