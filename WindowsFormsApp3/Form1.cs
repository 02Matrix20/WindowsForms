using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int[] mas;
        public string Sum
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mas = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(k => int.Parse(k.Trim())).ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked)
            {
                Form2 fm2 = new Form2();
                int sum = 0;
                foreach (int value in mas)
                {
                    sum += value;
                }
                textBox2.Text = sum.ToString();
                fm2.textBox1.Text = this.textBox2.Text;

                fm2.ShowDialog();
            }
            if (radioButton2.Checked)
            {
                Form2 fm2 = new Form2();
                int  dob = 1;
                foreach (int value in mas)
                {
                    dob *= value;

                }
                textBox2.Text = dob.ToString();
                fm2.textBox1.Text = this.textBox2.Text;

                fm2.ShowDialog();
            }
            Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
