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
    public partial class CONTENTS : Form
    {
        string gelenVeri;
        public CONTENTS(string data)
        {
            InitializeComponent();
            gelenVeri = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HOMEPACKAGE au = new HOMEPACKAGE(gelenVeri);
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

        private void CONTENTS_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet5.content' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.contentTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet5.content);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cost_per_stream;
            float.TryParse(textBox10.Text, out cost_per_stream);

            Random random = new Random();
            int content_id = random.Next(1003, 2000);
            string actor_id = textBox2.Text;
            string af_id = textBox3.Text;
            string title = textBox4.Text;
            string episode = textBox5.Text;
            string genre = textBox7.Text;
            string duration = textBox6.Text;
          
            string release_date = textBox9.Text;
            string distributor = textBox8.Text;
            



            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "INSERT INTO content (content_id, actor_id, af_id, title, episode, genre, duration, cost_per_stream, release_date, distributor) VALUES (@content_id, @actor_id, @af_id, @title, @episode, @genre, @duration, @cost_per_stream, @release_date, @distributor)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@content_id", content_id);
                command.Parameters.AddWithValue("@actor_id", actor_id);
                command.Parameters.AddWithValue("@af_id", af_id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@episode", episode);
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@cost_per_stream", cost_per_stream);
                command.Parameters.AddWithValue("@release_date", release_date);
                command.Parameters.AddWithValue("@distributor", distributor);




                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("Data adding successful.");

                this.contentTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet5.content);

               
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                

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


            string content_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "DELETE FROM content WHERE content_id = @content_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@content_id", content_id);


                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("The selected row is succesfully deleted.");


                this.contentTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet5.content);
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

           

            string content_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int contentId;
            int.TryParse(content_id, out contentId);

            float updatedData1;
            float.TryParse(textBox2.Text, out updatedData1);

            float updatedData2;
            float.TryParse(textBox3.Text, out updatedData2);

            float updatedData4;
            float.TryParse(textBox5.Text, out updatedData4);

            float updatedData6;
            float.TryParse(textBox6.Text, out updatedData6);

            float updatedData7;
            float.TryParse(textBox10.Text, out updatedData7);

            string updatedData3 = textBox4.Text;
            
            string updatedData5 = textBox7.Text;
           
            string updatedData8 = textBox9.Text;
            string updatedData9 = textBox8.Text;


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE content SET actor_id = @updatedData1, af_id = @updatedData2, title = @updatedData3, episode = @updatedData4, genre = @updatedData5, duration = @updatedData6, cost_per_stream = @updatedData7, release_date = @updatedData8, distributor = @updatedData9  WHERE content_id = @content_id";


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
                command.Parameters.AddWithValue("@content_id", contentId);

                connection.Open();

               
                command.ExecuteNonQuery();

                
                MessageBox.Show("Data is succesfully updated.");

                
                this.contentTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet5.content);
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

        private void CONTENTS_FormClosing(object sender, FormClosingEventArgs e)
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
        }
    }
}
