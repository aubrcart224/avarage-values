using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avarage_values
{
    public partial class averageNumbers : Form
    {
        //global variables
        double sum;
        double input;
        double numberOfNumbers;
        double average = 0;

        public averageNumbers()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //variables 

            input = Convert.ToDouble(textBox1.Text);
            

            //calcualtions 

            if (input  == 0)
            {
                average = sum / numberOfNumbers;
                outputLabel.Text = $"The Average is {average} "; 
            }
            else 
            {
                numberOfNumbers++;
                sum = sum + input;
                outputLabel.Text = $" {input} was added to the sum";
            
            }

            


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            input = 0;
            numberOfNumbers = 0;
            average = 0;
        }
    }
}
