using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Fİbbo : Form
    {
        public Fİbbo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = 1;
            int s2 = 1;
            int s3;
            int son = Convert.ToInt32(textBox1.Text);

            listBox1.Items.Add(s1);
            listBox1.Items.Add(s2);
            for (int i = 1; i < son; i++)
            {
                s3 = s1 + s2;
                s1 = s2;
                s2 = s3;
                
                listBox1.Items.Add(s3);
            }


           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";

        }
    }
}
