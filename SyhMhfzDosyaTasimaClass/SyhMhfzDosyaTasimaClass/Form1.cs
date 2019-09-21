using System;
using System.IO;
using System.Windows.Forms;

namespace SyhMhfzDosyaTasimaClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ebubekirbastama.klasor_tasi(textBox1.Text, textBox2.Text));
             MessageBox.Show(ebubekirbastama.Copy(textBox1.Text, textBox2.Text));
        }
    }
}
