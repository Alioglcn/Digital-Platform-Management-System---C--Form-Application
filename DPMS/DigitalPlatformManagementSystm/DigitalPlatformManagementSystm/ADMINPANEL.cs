using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPlatformManagementSystm
{
    public partial class ADMINPANEL : Form
    {
        public ADMINPANEL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "adminpanel"  && textBox2.Text == "654321")
            {
                HOMEPACKAGE hp = new HOMEPACKAGE("adminpanel");
                ACTORS a = new ACTORS("adminpanel");
                AUDIENCES au = new AUDIENCES("adminpanel");
                CONTENTS cn = new CONTENTS("adminpanel");
                STREAMS sm = new STREAMS("adminpanel");
                FEATURES ft = new FEATURES("adminpanel");
                REVIEWS rv = new REVIEWS("adminpanel");
                BILLS bi = new BILLS("adminpanel");
                hp.Show();
                this.Hide();
                    MessageBox.Show("Welcome to our system. Enjoy!  😄 ");
            }
            else if (textBox1.Text == "managerpanel" && textBox2.Text == "654321")
            {
                HOMEPACKAGE hp = new HOMEPACKAGE("managerpanel");
                ACTORS a = new ACTORS("managerpanel");
                AUDIENCES au = new AUDIENCES("managerpanel");
                CONTENTS cn = new CONTENTS("managerpanel");
                STREAMS sm = new STREAMS("managerpanel");
                FEATURES ft = new FEATURES("managerpanel");
                REVIEWS rv = new REVIEWS("managerpanel");
                BILLS bi = new BILLS("managerpanel");
                hp.Show();
                this.Hide();
                MessageBox.Show("Welcome to our system. Enjoy!  😄 ");
            }
            else
                MessageBox.Show("Please check your username and password  😄 ");
        }

        private void ADMINPANEL_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
