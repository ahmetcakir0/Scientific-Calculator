using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = string.Empty;
        }


        public string sonuc;

        private void AddOperator(string op)
        {
            if (!textBox1.Text.EndsWith(" + ") &&
                !textBox1.Text.EndsWith(" - ") &&
                !textBox1.Text.EndsWith(" * ") &&
                !textBox1.Text.EndsWith(" / ") &&
                !textBox1.Text.EndsWith(" x ") &&
                !textBox1.Text.EndsWith(" : "))
            {
                textBox1.Text += $" {op} ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                double kare = sayi * sayi;
                sonuc = kare.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            sonuc = pi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double eulerNumber = Math.E;
            sonuc = eulerNumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.EndsWith(" + ") ||
                    textBox1.Text.EndsWith(" - ") ||
                    textBox1.Text.EndsWith(" * ") ||
                    textBox1.Text.EndsWith(" / "))
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                double kup = Math.Pow(sayi, 3);
                sonuc = kup.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                if (sayi >= 0)
                {
                    double karekok = Math.Sqrt(sayi);
                    sonuc = karekok.ToString();
                }
                else
                {
                    MessageBox.Show("Negatif sayının karekökü alınamaz.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                if (sayi < 0)
                {
                    textBox1.Text = (-1 * sayi).ToString();
                }
                else
                {
                    textBox1.Text = sayi.ToString();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                double expDeger = Math.Exp(sayi);
                sonuc = expDeger.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string[] sayilar = textBox1.Text.Split(' ');

            if (sayilar.Length == 2 &&
                double.TryParse(sayilar[0], out double sayi1) &&
                double.TryParse(sayilar[1], out double sayi2))
            {
                if (sayi2 != 0)
                {
                    double modDeger = sayi1 % sayi2;
                    sonuc = modDeger.ToString();
                }
                else
                {
                    MessageBox.Show("Sıfıra bölme hatası.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Lütfen iki geçerli sayı girin (örnek: 10 3).", "Hata");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                if (sayi >= 0)
                {
                    double karekok = Math.Sqrt(sayi);
                    double sonucu = 2 * karekok;

                    sonuc = sonucu.ToString();
                }
                else
                {
                    MessageBox.Show("Negatif sayının karekökü alınamaz.", "Hata");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int sayi) && sayi >= 0)
            {
                long faktoriyel = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }

               sonuc = faktoriyel.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddOperator(":");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string[] sayilar = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (sayilar.Length == 2 &&
                double.TryParse(sayilar[0], out double taban) &&
                double.TryParse(sayilar[1], out double us))
            {
                sonuc = Math.Pow(taban, us).ToString();
                textBox1.Text = sonuc;
            }
            else
            {
                MessageBox.Show("Lütfen 'taban üs' biçiminde girin (örnek: 2 3).", "Hata");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AddOperator("x");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double us))
            {
                double sonucbu = Math.Pow(10, us);
                sonuc = sonucbu.ToString();

                textBox1.Text = sonuc;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AddOperator("-");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi) && sayi > 0)
            {
                double logDegeri = Math.Log10(sayi);

                sonuc = logDegeri.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen pozitif bir sayı girin.", "Hata");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AddOperator("+");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi) && sayi > 0)
            {
                double lnDegeri = Math.Log(sayi);

                sonuc = lnDegeri.ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi))
            {
                double yeniSayi = -sayi;

                sonuc = yeniSayi.ToString();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !textBox1.Text.Contains(","))
            {
                if (!textBox1.Text.EndsWith(" + ") &&
                    !textBox1.Text.EndsWith(" - ") &&
                    !textBox1.Text.EndsWith(" * ") &&
                    !textBox1.Text.EndsWith(" / "))
                {
                    textBox1.Text += ",";
                }
            }
        }
        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                string ifade = textBox1.Text.Replace(",", ".")
                                            .Replace("x", "*")
                                            .Replace(":", "/");
                DataTable dataTable = new DataTable();
                object hesaplanmisSonuc = dataTable.Compute(ifade, null);

                if (hesaplanmisSonuc != null)
                {
                    if (hesaplanmisSonuc.ToString().Contains("."))
                    {
                        double sonucDouble = Convert.ToDouble(hesaplanmisSonuc);
                        textBox1.Text = sonucDouble.ToString("0.##").Replace(".", ",");
                    }
                    else
                    {
                        textBox1.Text = hesaplanmisSonuc.ToString();
                    }
                    Geçmiş.Items.Add(textBox1.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz bir ifade girdiniz.", "Hata");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }
    }
}
