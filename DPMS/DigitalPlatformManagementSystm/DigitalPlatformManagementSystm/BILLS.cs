using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalPlatformManagementSystm
{
    public partial class BILLS : Form
    {
        string gelenVeri;
        public BILLS(string data)
        {
            InitializeComponent();
            gelenVeri   = data; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime sign_up_date;
            DateTime.TryParse(textBox2.Text, out sign_up_date);

            Random random = new Random();
            int invoice_number = random.Next(1003, 2000);

            string customer_plan = textBox3.Text;
            string service_period = textBox4.Text;
            string payment_method = textBox6.Text;
            string total_cost = textBox5.Text;


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "INSERT INTO bill (invoice_number, sign_up_date, customer_plan, service_period, payment_method, total_cost) VALUES (@invoice_number, @sign_up_date, @customer_plan, @service_period, @payment_method, @total_cost)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@invoice_number", invoice_number);
                command.Parameters.AddWithValue("@sign_up_date", sign_up_date);
                command.Parameters.AddWithValue("@customer_plan", customer_plan);
                command.Parameters.AddWithValue("@service_period", service_period);
                command.Parameters.AddWithValue("@payment_method", payment_method);
                command.Parameters.AddWithValue("@total_cost", total_cost);




                connection.Open();

                command.ExecuteNonQuery();


                MessageBox.Show("Data adding successful.");


               
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                this.billTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet4.bill);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veri eklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HOMEPACKAGE au = new HOMEPACKAGE("");
            if (gelenVeri == "managerpanel")
            {
                au.button1.Enabled = false;
                au.button3.Enabled = false;
                au.button6.Enabled = false;
                au.button7.Enabled = false;
                au.button1.Text = "NOT PERMISSION ENABLE";
                au.button3.Text = "NOT PERMISSION ENABLE";
                au.button6.Text = "NOT PERMISSION ENABLE";
                au.button7.Text = "NOT PERMISSION ENABLE";


            }
            au.Show();
            this.Hide();
        }

        private void BILLS_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet4.bill' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.billTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet4.bill);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;


            string invoice_number = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "DELETE FROM bill WHERE invoice_number = @invoice_number";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@invoice_number", invoice_number);


                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("The selected row is succesfully deleted.");


                this.billTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet4.bill);
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while deleting the row: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;



            string invoice_number = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int IN;
            int.TryParse(invoice_number, out IN);

            DateTime updatedData1;
            DateTime.TryParse(textBox2.Text, out updatedData1);



            string updatedData2 = textBox3.Text;

            string updatedData3 = textBox4.Text;

            string updatedData4 = textBox5.Text;

            string updatedData5 = textBox6.Text;

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE bill SET sign_up_date = @updatedData1, customer_plan = @updatedData2, service_period = @updatedData3, payment_method = @updatedData5, total_cost = @updatedData4  WHERE invoice_number = @invoice_number";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@updatedData1", updatedData1);
                command.Parameters.AddWithValue("@updatedData2", updatedData2);
                command.Parameters.AddWithValue("@updatedData3", updatedData3);
                command.Parameters.AddWithValue("@updatedData4", updatedData4);
                command.Parameters.AddWithValue("@updatedData5", updatedData5);
                command.Parameters.AddWithValue("@invoice_number", IN);

                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("Data is succesfully updated.");


                this.billTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet4.bill);
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while updating data: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BILLS_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
