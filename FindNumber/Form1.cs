using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 10);
            chance = 10;
            display.Text = "맞출 숫자를 입력하세요";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                display.Text = "숫자를 입력하세요.";
                return;
            }

            int inputNumber = int.Parse(textBox.Text);
            if(inputNumber == findNumber)
            {
                display.Text = "정답입니다.";
            }
            if (inputNumber != findNumber)
            {
                chance--;
                display.Text = $"틀렸습니다. 남은 기회: {chance}";
            }
            if (chance <= 0)
            {
                display.Text = $"게임 오버! 정답은 {findNumber}였습니다.";
            }
        }
    }
}
