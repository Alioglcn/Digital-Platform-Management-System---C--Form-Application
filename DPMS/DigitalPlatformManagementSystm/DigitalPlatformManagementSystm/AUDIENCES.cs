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
    public partial class AUDIENCES : Form
    {

        string gelenVeri;
        public AUDIENCES(string data)
        {
            InitializeComponent();
            gelenVeri = data;
        }

        private void AUDIENCES_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet7.audience' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.audienceTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet7.audience);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            HOMEPACKAGE au = new HOMEPACKAGE("");
            au.Show();
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
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int customer_id = random.Next(1003, 2000);
            string invoice_number = textBox2.Text;
            string reviews_id = textBox3.Text;
            string first_name = textBox4.Text;
            string last_name = textBox5.Text;
            string e_mail = textBox6.Text;
            string phone_number = textBox7.Text;
            string state = textBox10.Text;
            string country = textBox9.Text;
            string sign_up_date = textBox8.Text;
            string username = textBox12.Text;
            string password = textBox11.Text;



            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
               
                string query = "INSERT INTO audience (customer_id, invoice_number, reviews_id, first_name, last_name, e_mail, phone_number, state, country, sign_up_date, username, password) VALUES (@customer_id, @invoice_number, @reviews_id, @first_name, @last_name, @e_mail, @phone_number, @state, @country, @sign_up_date, @username, @password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.Parameters.AddWithValue("@invoice_number", invoice_number);
                command.Parameters.AddWithValue("@reviews_id", reviews_id);
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@e_mail", e_mail);
                command.Parameters.AddWithValue("@phone_number", phone_number);
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@sign_up_date", sign_up_date);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


               
                connection.Open();

              
                command.ExecuteNonQuery();

              
                MessageBox.Show("Data adding successful.");

                this.audienceTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet7.audience);

               
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;


            string customer_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "DELETE FROM audience WHERE customer_id = @customer_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", customer_id);


                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("The selected row is succesfully deleted.");


                this.audienceTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet7.audience);
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


            string customer_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int CI;
            int.TryParse(customer_id, out CI);

            float updatedData1;
            float.TryParse(textBox2.Text, out updatedData1);

            float updatedData2;
            float.TryParse(textBox3.Text, out updatedData2);

            string updatedData3 = textBox4.Text;
            string updatedData4 = textBox5.Text;
            string updatedData5 = textBox7.Text;


            string updatedData6 = textBox6.Text;

            string updatedData7 = textBox10.Text;
            string updatedData8 = textBox9.Text;
            string updatedData9 = textBox8.Text;
            string updatedData10 = textBox12.Text;
            string updatedData11 = textBox11.Text;


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE audience SET invoice_number = @updatedData1, reviews_id = @updatedData2, first_name = @updatedData3, last_name = @updatedData4, e_mail = @updatedData5, phone_number = @updatedData6, state = @updatedData7, country = @updatedData8, sign_up_date = @updatedData9, username = @updatedData10, password = @updatedData11  WHERE customer_id = @customer_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@updatedData1", updatedData1);
                command.Parameters.AddWithValue("@updatedData2", updatedData2);
                command.Parameters.AddWithValue("@updatedData3", updatedData3);
                command.Parameters.AddWithValue("@updatedData4", updatedData4);
                command.Parameters.AddWithValue("@updatedData5", updatedData5);
                command.Parameters.AddWithValue("@updatedData6", updatedData6);
                command.Parameters.AddWithValue("@updatedData7", updatedData7);
                command.Parameters.AddWithValue("@updatedData8", updatedData8);
                command.Parameters.AddWithValue("@updatedData9", updatedData9);
                command.Parameters.AddWithValue("@updatedData10", updatedData10);
                command.Parameters.AddWithValue("@updatedData11", updatedData11);
                command.Parameters.AddWithValue("@customer_id", CI);

                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("Data is succesfully updated.");


                this.audienceTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet7.audience);
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

        private void AUDIENCES_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }
    }
}
