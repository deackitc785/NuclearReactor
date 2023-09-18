using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep() 
using System.Media; //allows the use of SoundPlayer(); 

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it 
           
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.ping);
            alertPlayer.Play();

            //change the colour of the state labels and output message 
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            //change the font and background colours, and the message in outputLabel 
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;
            outputLabel.Text = "Meltdown Imminent";

            //redraw the screen to show updates then pause for 1 second 
            Refresh();
            Thread.Sleep(1000);

            //change the colour of the state labels and output message 
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            //change the font and background colours of the output label 
            outputLabel.ForeColor = Color.White;
            outputLabel.BackColor = Color.Red;

            //redraw the screen to show updates then pause for 1 second 
            Refresh();
            Thread.Sleep(1000);

            //change the colour of the state labels and output message 
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            //change the font and background colours of the output label 
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;

            //redraw the screen to show updates then pause for 1 second 
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
