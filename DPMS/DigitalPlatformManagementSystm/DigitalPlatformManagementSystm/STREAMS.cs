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
    public partial class STREAMS : Form
    {
        string gelenVeri;
        public STREAMS(string data)
        {
            InitializeComponent();
            gelenVeri   = data;
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

        private void STREAMS_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet2.streams' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.streamsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet2.streams);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float stream_duration;
            float.TryParse(textBox7.Text, out stream_duration);
            Random random = new Random();
            int stream_id = random.Next(1003, 2000);
            string customer_id = textBox2.Text;
            string content_id = textBox3.Text;
            string stream_date = textBox4.Text;
            string stream_time = textBox5.Text;
            string stream_rating = textBox6.Text;
           


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
               
                string query = "INSERT INTO streams (stream_id, customer_id, content_id, stream_date," +
                    " stream_time, stream_duration, stream_rating) VALUES (@stream_id, @customer_id, @content_id, @stream_date, @stream_time, @stream_duration, @stream_rating)";

              
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@stream_id", stream_id);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.Parameters.AddWithValue("@content_id", content_id);
                command.Parameters.AddWithValue("@stream_date", stream_date);
                command.Parameters.AddWithValue("@stream_time", stream_time);
                command.Parameters.AddWithValue("@stream_duration", stream_duration);
                command.Parameters.AddWithValue("@stream_rating", stream_rating);
                

                
                connection.Open();

               
                command.ExecuteNonQuery();

                MessageBox.Show("Data adding successful.");

               
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                this.streamsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet2.streams);

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


            string stream_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "DELETE FROM streams WHERE stream_id = @stream_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@stream_id", stream_id);


                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("The selected row is succesfully deleted.");


                this.streamsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet2.streams);
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



            string stream_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int streamID;
            int.TryParse(stream_id, out streamID);

            float updatedData2;
            float.TryParse(textBox2.Text, out updatedData2);

            float updatedData3;
            float.TryParse(textBox3.Text, out updatedData3);

           
            DateTime updatedData4;
            DateTime.TryParse(textBox4.Text, out updatedData4);

            string updatedData5 = textBox5.Text;

            float updatedData6;
            float.TryParse(textBox7.Text, out updatedData6);

            float updatedData7;
            float.TryParse(textBox6.Text, out updatedData7);

        
            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE streams SET customer_id = @updatedData2, content_id = @updatedData3, stream_date = @updatedData4, stream_time = @updatedData5, stream_duration = @updatedData6, stream_rating = @updatedData7  WHERE stream_id = @stream_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@stream_id", streamID);
                command.Parameters.AddWithValue("@updatedData2", updatedData2);
                command.Parameters.AddWithValue("@updatedData3", updatedData3);
                command.Parameters.AddWithValue("@updatedData4", updatedData4);
                command.Parameters.AddWithValue("@updatedData5", updatedData5);
                command.Parameters.AddWithValue("@updatedData6", updatedData6);
                command.Parameters.AddWithValue("@updatedData7", updatedData7);
               

                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("Data is succesfully updated.");


                this.streamsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet2.streams);
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

        private void STREAMS_FormClosing(object sender, FormClosingEventArgs e)
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
        }
    }
}
