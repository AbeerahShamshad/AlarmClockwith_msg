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
        public Form1()
        {
            InitializeComponent();
        }
        int hour, min, sec;
        string ahour, amin;

        private void button1_Click(object sender, EventArgs e)
        {
            ahour = comboBox1.Text;
            amin = comboBox2.Text;
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Not Set");
            }
            else {
                MessageBox.Show("Alarm is set");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i=0;i<24;i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int j=0;j<60;j++) { 
                comboBox2.Items.Add(j);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
            lblh.Text = hour.ToString();
            lblm.Text = min.ToString();
            lbls.Text = sec.ToString();
            Ring_Alarm();

        }
      void  Ring_Alarm() {
         
            if (ahour == hour.ToString() && amin == min.ToString())
            {
                MessageBox.Show("Alram is ringing");
            }
            
          
        }


    }
}
