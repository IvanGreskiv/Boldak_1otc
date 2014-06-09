using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                vektor abc = new vektor();
                string a = textBox1.Text, b = textBox2.Text, c = textBox3.Text, d = textBox4.Text, m = textBox5.Text;
                string f = textBox6.Text, g = textBox7.Text, h = textBox8.Text, i = textBox9.Text, j = textBox10.Text;
                abc.vekt1(Convert.ToInt32(a), Convert.ToInt32(b), Convert.ToInt32(c), Convert.ToInt32(d), Convert.ToInt32(m), Convert.ToInt32(f), Convert.ToInt32(g), Convert.ToInt32(h), Convert.ToInt32(i), Convert.ToInt32(j));
            }
            if (radioButton1.Checked == true)
            {
                string K_A = textBox11.Text, K_B = textBox12.Text;
                kompl r = new kompl();
                r.kompl1(Convert.ToDouble(K_A), Convert.ToDouble(K_B));
            }
            if (radioButton3.Checked == true)
            {
                string M_A = textBox13.Text, M_B = textBox14.Text, M_C = textBox15.Text, M_D = textBox16.Text;
                matrix mat = new matrix();
                mat.matrix1(Convert.ToDouble(M_A), Convert.ToDouble(M_B), Convert.ToDouble(M_C), Convert.ToDouble(M_D));
            }
        }
    }
    public class norma
    {
        public double vekt_d(double[] vekt)
        {
            double j = 0;
            double sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += vekt[i] * vekt[i];
            }
            sum = Math.Sqrt(sum);
            string otv = Convert.ToString(sum);
            MessageBox.Show(otv);
            return 0;
        }

        public double kompl_d(double a, double b)
        {
            double abs = Math.Sqrt(a * a + b * b);
            string otv = Convert.ToString(abs);
            MessageBox.Show(otv);
            return 0;
        }

        public double matrix_d(double[,] matrixx)
        {
            double max_abs=0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (matrixx[i,j]>max_abs)
                    {
                        max_abs = Math.Abs(matrixx[i, j]);
                    }
                }
            }
                string otv = Convert.ToString(max_abs);
                MessageBox.Show(otv);
                return 0;
        }
    }

    public class vektor : norma
    {
        public void vekt1(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            double[] vekt = new double[] { a, b, c, d, e, g, h, i, j };
            double num = vekt_d(vekt);
        }

    }
    public class kompl : norma
    {
        public void kompl1(double a, double b)
        {
            double asd = kompl_d(a, b);
        }
    }

    public class matrix : norma
    {
        public void matrix1(double a, double b, double c, double d)
        {
            double[,] mas = { { a, b }, { c, d } };
            double asf = matrix_d(mas);
        }
    }
}
