using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private int n = 4;
        ComplexNumber[] number;

        private int i = 0;

        public int N { get => n; set => n = value; }
        public int I { get => i; set => i = value; }

        public Form1()
        {
            number = new ComplexNumber[N];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = new ComplexNumber();
            }
            InitializeComponent();
        }

        private void btnAlgebraicForm_Click(object sender, EventArgs e)
        {        
            for(int i = 0; i < number.Length; i++)
                txtResult.Text += $"z{i + 1} = " +  number[i].ToAlgebraicForm();
        }

        private void btnTrigonometricForm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < number.Length; i++)
                txtResult2.Text += $"z{i + 1} = " + number[i].ToTrigonometricForm();
        }

        private void btnExponentialForm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < number.Length; i++)
                txtResult3.Text += $"z{i + 1} = " + number[i].ToExponentialForm();
        }

        
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtR.Text = Convert.ToString(rnd.Next(-50, 50));
            txtFi.Text = Convert.ToString(rnd.Next(0, 360));
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            if( I < number.Length)
            {
                number[I] = new ComplexNumber();
                number[I].R = Convert.ToDouble(txtR.Text);
                number[i].Fi = Convert.ToDouble(txtFi.Text);
            }
            else
            {
                MessageBox.Show("Вы ввели все числа.");
            }
            I++;
        }

        private void btnFindExp_Click(object sender, EventArgs e)
        {
            txtResult4.Text = "";
            ComplexNumber num = new ComplexNumber();
            num = number[1] / number[0] + number[2] * number[3];
            txtResult4.Text += "Алгебраическая форма - \n z = " + num.ToStringAlgebraic();
            txtResult4.Text += "Тригонометрическая форма - \n z = " + num.ToStringTrigonometric();
            txtResult4.Text += "Показательная форма - \n z = " + num.ToStringExponential();
        }
    }
}
