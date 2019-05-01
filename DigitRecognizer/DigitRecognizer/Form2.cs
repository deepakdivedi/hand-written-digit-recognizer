using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DigitRecognizer
{
    public partial class Form2 : Form
    {
        string inputFile,outputFile;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inputFile = Form1.file;
            label2.Text = Form1.file;
            PictureBox inputBox = new PictureBox();
            inputBox.Dock = DockStyle.Fill;
            inputBox.Image = Image.FromFile(inputFile);
            inputBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.Controls.Add(inputBox);

            Hurestic();

            label3.Text = "E:\\PROJECTS\\DigitRecognizer\\DATA\\output_image.png";
            outputFile = label3.Text;
            PictureBox outputBox = new PictureBox();
            outputBox.Dock = DockStyle.Fill;
            outputBox.Image = Image.FromFile(outputFile);
            outputBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel2.Controls.Add(outputBox);
        }

        void Hurestic()
        {
            string fileName = "E:\\PROJECTS\\DigitRecognizer\\Recognizer\\Recognizer.py";
            string command = "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\Python36_64\\python.exe";

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = command;
            start.Arguments = string.Format("{0} {1}", fileName, inputFile);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            Process process = Process.Start(start);
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
