using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magic8Ball
{
    public partial class Form1 : Form
    {
        // set up randomizer
        Random randGen = new Random();
        // set up random variable
        int random = 0;
      
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            random = randGen.Next(1, 7);

            switch (random)
            {
                case 1:
                    messageOutput.Text = "Yes";
                    break;
                case 2:
                    messageOutput.Text = "No";
                    break;
                case 3:
                    messageOutput.Text = "Maybe";
                    break;
                case 4:
                    messageOutput.Text = "I don't know";
                    break;
                case 5:
                    messageOutput.Text = "That's your decision";
                    break;
                case 6:
                    messageOutput.Text = "No one knows";
                    break;
                case 7:
                    messageOutput.Text = "That's enough questions for today";
                    break;
                default:
                   messageOutput.Text = "Not a valid category";
                    break;

            }


        }
    }
}
