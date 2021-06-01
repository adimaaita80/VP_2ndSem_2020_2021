using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture27_Lesson1
{
    public partial class frmCalculator : Form
    {
        double firstNumber;
        double secondNumber;

        CalculatorState currentState = CalculatorState.firstNumberInput;

        OperationState currentOperation;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            this.button0.Click += new EventHandler(allNumericButtons_click);
            this.button1.Click += new EventHandler(allNumericButtons_click);
            this.button2.Click += new EventHandler(allNumericButtons_click);
            this.button3.Click += new EventHandler(allNumericButtons_click);
            this.button4.Click += new EventHandler(allNumericButtons_click);
            this.button5.Click += new EventHandler(allNumericButtons_click);
            this.button6.Click += new EventHandler(allNumericButtons_click);
            this.button7.Click += new EventHandler(allNumericButtons_click);
            this.button8.Click += new EventHandler(allNumericButtons_click);
            this.button9.Click += new EventHandler(allNumericButtons_click);

            this.buttonPlus.Click += new EventHandler(allOperationsButtons_click);
            this.buttonMinus.Click += new EventHandler(allOperationsButtons_click);
            this.buttonMultiply.Click += new EventHandler(allOperationsButtons_click);
            this.buttonDivision.Click += new EventHandler(allOperationsButtons_click);
        }

        private void allNumericButtons_click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            txtResult.Text += currentButton.Text;
        }

        private void allOperationsButtons_click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                firstNumber = double.Parse(txtResult.Text);

                txtResult.Text = "";

                currentState = CalculatorState.secondNumberInput;

                Button currentButton = (Button)sender;

                if (currentButton.Name == "buttonPlus")
                {
                    currentOperation = OperationState.add;
                }
                else if (currentButton.Name == "buttonMinus")
                {
                    currentOperation = OperationState.sub;
                }
                else if (currentButton.Name == "buttonMultiply")
                {
                    currentOperation = OperationState.mul;
                }
                else if (currentButton.Name == "buttonDivision")
                {
                    currentOperation = OperationState.div;
                }
            }
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if(currentState == CalculatorState.secondNumberInput && txtResult.Text != "")
            {
                double result = 0;
                secondNumber = double.Parse(txtResult.Text);
                
                if(currentOperation == OperationState.add)
                {
                    result = firstNumber + secondNumber;
                }
                else if(currentOperation == OperationState.sub)
                {
                    result = firstNumber - secondNumber;
                }
                else if (currentOperation == OperationState.mul)
                {
                    result = firstNumber * secondNumber;
                }
                else if (currentOperation == OperationState.div)
                {
                    result = firstNumber / secondNumber;
                }

                txtResult.Text = result.ToString();
                currentState = CalculatorState.firstNumberInput;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            currentState = CalculatorState.firstNumberInput;
        }


    }
}
