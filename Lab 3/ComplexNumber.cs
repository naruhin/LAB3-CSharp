using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class ComplexNumber
    {
        //ыыыыыы
        private double r;
        private double fi;
        private double a;
        private double b;

        public double R { get => r; set => r = value; }
        public double Fi { get => fi; set => fi = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public ComplexNumber()
        {

        }

        public ComplexNumber(double r, double fi)
        {
            this.R = r;
            this.Fi = fi;
        }



        //Перегрузка оператора суммы
        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber num = new ComplexNumber();
            if (num1.A == 0 && num1.B == 0 && num2.A == 0 && num2.B == 0)
            {
                num.A = num1.getA() + num2.getA();
                num.B = num1.getB() + num2.getB();
            }
            else
            {
                num.A = num1.A + num2.A;
                num.B = num1.B + num2.B;
            } 
            return num;
        }
        //Перегрузка оператора вычитания
        public static ComplexNumber operator - (ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber num = new ComplexNumber();
            if (num1.A == 0 && num1.B == 0 && num2.A == 0 && num2.B == 0)
            {
                num.A = num1.getA() - num2.getA();
                num.B = num1.getB() - num2.getB();
            }
            else
            {
                num.A = num1.A - num2.A;
                num.B = num1.B - num2.B;
            }
            return num;
        }
        //Перегрузка оператора умножения
        public static ComplexNumber operator * (ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber num = new ComplexNumber();
            if (num1.A == 0 && num1.B == 0 && num2.A == 0 && num2.B == 0)
            {
                num.A = (num1.getA() * num2.getA() - num1.getB() * num2.getB());
                num.B = (num1.getA() * num2.getB() + num2.getA() * num1.getB());
            }
            else
            {
                num.A = (num1.A * num2.A - num1.B * num2.B);
                num.B = (num1.A * num2.B + num2.A * num1.B);
            }
            
            return num;
        }
        //Перегрузка оператора деления
        public static ComplexNumber operator  / (ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber num = new ComplexNumber();
            if (num1.A == 0 && num1.B == 0 && num2.A == 0 && num2.B == 0)
            {
                num.A = (num1.getA() * num2.getA() + num1.getB() * num2.getB()) / (Math.Pow(num2.getA(), 2) + Math.Pow(num2.getB(), 2));
                num.B = (num2.getA() * num1.getB() - num1.getA() * num2.getB()) / (Math.Pow(num2.getA(), 2) + Math.Pow(num2.getB(), 2));
            }
            else
            {
                num.A = (num1.A * num2.A + num1.B * num2.B) / (Math.Pow(num2.A, 2) + Math.Pow(num2.B, 2));
                num.B = (num2.A * num1.B - num1.A * num2.B) / (Math.Pow(num2.A, 2) + Math.Pow(num2.B, 2));
            }
            
            return num;
        }


        public double getA()
        {
            A = this.R * Math.Cos(this.Fi * (Math.PI / 180));
            return A;
        }
        public double getB()
        {
            B = this.R * Math.Sin(this.Fi * (Math.PI / 180));
            return B;
        }
        public string ToStringAlgebraic()
        {
            return Math.Round(this.A,3) + " + " + Math.Round(this.B,3) + "i\n";
        }
        public string ToStringTrigonometric()
        {
            return Math.Round(Math.Sqrt(Math.Pow(this.A, 2) + Math.Pow(this.B, 2)),3) +
                   "(cos(" + Math.Round(Math.Atan(this.A / this.B) * 180, 3) + ") " +
                   "+ sin(" + Math.Round(Math.Atan(this.A / this.B) * 180, 3) + ")i )\n"; 
        }
        public string ToStringExponential()
        {
            return Math.Round(Math.Sqrt(Math.Pow(this.A, 2) + Math.Pow(this.B, 2)),3) + "+ e^" + Math.Round(Math.Atan(this.A / this.B) * 180,3) + "i\n";
        }

        //Перевод в алгебраическую форму
        public string ToAlgebraicForm()
        {
            A = Math.Round(this.R * Math.Cos(this.Fi * (Math.PI / 180)),3);
            B = Math.Round(this.R * Math.Sin(this.Fi * (Math.PI / 180)),3);
            return  A + " + " + B + "i\n\n"; 
        }
        //Перевод в тригонометрическую форму
        public string ToTrigonometricForm()
        {
            return   this.R + "(cos(" + this.Fi + ") + sin(" + this.Fi + ")i)\n\n";
        }
        //Перевод в экспоненциальную форму
        public string ToExponentialForm()
        {
            return  this.R + "e^" + this.Fi + "i\n\n";
        }
    }
}
