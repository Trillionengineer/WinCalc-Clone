using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }
      
        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_pressed))
                Result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;                              //Will take the sender object from the parameters of "object" and turn it into a button ((Button)sender;) under the label "b".
            Result.Text = Result.Text + b.Text;
        }
                
        private void clear_entry(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;
            Equation.Text = value + " " + operation;
        }

        private void button11_Click(object sender, EventArgs e)
        {
                            
            Equation.Text = "";
                       
            switch (operation)
            {
                case "+":
                    Result.Text = (value + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            value = 0;
        }
    }
}
