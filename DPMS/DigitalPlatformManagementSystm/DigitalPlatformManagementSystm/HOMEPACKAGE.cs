using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DigitalPlatformManagementSystm
{
    public partial class HOMEPACKAGE : Form
    {
        string gelenVeri;
        public HOMEPACKAGE(string data)
        {
            InitializeComponent();
            gelenVeri = data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50; 
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            ToolTip info = new ToolTip();

            info.SetToolTip(button1, "Customer Operations");
            info.SetToolTip(button2, "Content Operations");
            info.SetToolTip(button3, "Stream Operations");
            info.SetToolTip(button4, "Actor Operations");
            info.SetToolTip(button5, "Feature Operations");
            info.SetToolTip(button6, "Review Operations");
            info.SetToolTip(button7, "Bill Operations");

            if (gelenVeri == "managerpanel")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Text = "NOT PERMISSION ENABLE";
                button3.Text = "NOT PERMISSION ENABLE";
                button6.Text = "NOT PERMISSION ENABLE";
                button7.Text = "NOT PERMISSION ENABLE";
                

            }
            

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AUDIENCES au = new AUDIENCES(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CONTENTS au = new CONTENTS(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STREAMS au = new STREAMS(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ACTORS au = new ACTORS(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FEATURES au = new FEATURES(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            REVIEWS au = new REVIEWS(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BILLS au = new BILLS(gelenVeri);
            au.Show();
            this.Hide();
        }

        private void HOMEPACKAGE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure to exit the program?", "The program is closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                   
                    Application.Exit();
                }
                else
                {
                    
                    e.Cancel = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left -= 5; 

            if (label1.Left + label1.Width < 0) 
            {
                label1.Left = this.Width; 
            }
        }
    }
}
