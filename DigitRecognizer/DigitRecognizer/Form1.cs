using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitRecognizer
{
    public partial class Form1 : Form
    {
        public static string file = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            file = textBox1.Text;
            Form2 frm2 = new Form2();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show(this);
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "";
            file = "";
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
