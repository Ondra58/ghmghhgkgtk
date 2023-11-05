using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] EratoshenovoSito(int n)
        {
            if (n >= 2)
            {
                int[] pole = new int[n];
                pole[0] = 2;
                int count = 1;

                for (int i = 3; i <= n; i++)
                {
                    bool prvocislo = true;
                    for (int x = 0; x < count && prvocislo; x++)
                    {
                        if (i % pole[x] == 0)
                            prvocislo = false;
                    }
                    if (prvocislo)
                    {
                        pole[count] = i;
                        count++;
                    }
                }
                Array.Resize(ref pole, count);
                return pole;
            }
            else
            {
                return new int[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                listBox1.Items.Clear();
                int n = int.Parse(textBox1.Text);
                int[] prvocisla = EratoshenovoSito(n);
                foreach (int x in prvocisla)
                {
                    listBox1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
