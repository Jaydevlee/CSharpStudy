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
    public partial class Form1 : Form
    {   
        enum Operators
        {
            None,
            Add,
            Substract,
            Mutiply,
            Divide,
            Result
        }
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperhand = 0;
        int secondOperhand = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "0";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "1";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "2";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "3";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "4";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "5";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "6";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "7";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "8";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "9";
            int number = int.Parse(strNumber);
            display.Text = number.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentOperator = Operators.Add;
            firstOperhand = int.Parse(display.Text);
            operatorChangeFlag = true;
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            currentOperator = Operators.Substract;
            firstOperhand = int.Parse(display.Text);
            operatorChangeFlag = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            currentOperator = Operators.Mutiply;
            firstOperhand = int.Parse(display.Text);
            operatorChangeFlag = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            currentOperator = Operators.Divide;
            firstOperhand = int.Parse(display.Text);
            operatorChangeFlag = true;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
           
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (currentOperator == Operators.Add)
            {
                secondOperhand = int.Parse(display.Text);
                int result = firstOperhand += secondOperhand;
                display.Text = result.ToString();
                operatorChangeFlag = true;
            }
            
            if (currentOperator ==  Operators.Substract)
            {
                secondOperhand = int.Parse(display.Text);
                int result = firstOperhand -= secondOperhand;
                display.Text = result.ToString();
                operatorChangeFlag = true;
            }

            if (currentOperator == Operators.Mutiply)
            {
                secondOperhand = int.Parse(display.Text);
                int result = firstOperhand *= secondOperhand;
                display.Text = result.ToString();
                operatorChangeFlag = true;
            }

            if (currentOperator == Operators.Divide)
            {
                secondOperhand = int.Parse(display.Text);
                if (secondOperhand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                
                int result = firstOperhand /= secondOperhand;
                display.Text = result.ToString();
                operatorChangeFlag = true;
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            firstOperhand = 0;
            secondOperhand = 0;
            operatorChangeFlag = false;
            display.Text = "0";
        }
    }
}
