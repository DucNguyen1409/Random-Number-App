using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;               
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

            if (txtNum1.Text == "" && txtNum2.Text == "")
            {
                MessageBox.Show("Enter a Number Please!!", "Notification");

            }
            else if (txtNum1.Text == "")
            {
                txtNum1.Text = txtNum2.Text;
                timer1.Start();
            }
            else if (txtNum2.Text == "")
            {
                txtNum2.Text = txtNum1.Text;
                timer1.Start();
            }
            else
            {
                timer1.Start();
                btnStop.Enabled = true;                
            }            
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            btnStop.Enabled = false;
            btnClear.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {        
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            Random random = new Random();              

            lblResult.Text = (random.Next(a, b)).ToString();                       
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnClear.Enabled = true;
        }
        
    }
}
