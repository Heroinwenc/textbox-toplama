using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sira = 0, sayi1 = 0, sayi2 = 0;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sira % 2 == 0)
                {
                    sayi1 = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                }
                else if (sira % 2 == 1)
                {
                    sayi2 = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = (sayi1 + sayi2).ToString();
                    sayi1 = 0;sayi2 = 0; 
                }
                sira++;
            }
        }
    }
}
