using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getInput = textBox1.Text;
            string getInput1 = comboBox1.Text;
            string getInput2 = textBox2.Text;
            string getInput3 = textBox3.Text;
            string getInput4 = textBox4.Text;
            string getInput5 = textBox5.Text;
            string getInput6 = comboBox2.Text;
            string getInput7 = dateTimePicker1.Text;
            string getInput8 = textBox6.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getInput1 + ".txt")))
            {
                outputFile.WriteLine("Student No: " + getInput);
                outputFile.WriteLine("Full Name: " + getInput2 + "," + getInput3 + getInput4);
                outputFile.WriteLine("Program: " + getInput1);
                outputFile.WriteLine("Gender: " + getInput6);
                outputFile.WriteLine("Age: " + getInput5);
                outputFile.WriteLine("Birthday: " + getInput7);
                outputFile.WriteLine("Contact No. " + getInput8);
            }
        }
    }
}
