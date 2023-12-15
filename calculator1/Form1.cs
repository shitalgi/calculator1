using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || (isOperationPerformed))
                textBox1_Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;


            textBox1_Result.Text = textBox1_Result.Text + button.Text;



            }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            labelCurrentOperation.Text = resultvalue + " " + operationPerformed;
            resultvalue = Double.Parse(textBox1_Result.Text);
            isOperationPerformed = true;
        }

        private void button4_click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
        }

        private void button5_click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            resultvalue = 0;
        }

        private void button15_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1_Result.Text = (resultvalue + Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "-":
                    textBox1_Result.Text = (resultvalue - Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "*":
                    textBox1_Result.Text = (resultvalue * Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "/":
                    textBox1_Result.Text = (resultvalue / Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            labelCurrentOperation.Text = "";
            
        }
    }
    }

