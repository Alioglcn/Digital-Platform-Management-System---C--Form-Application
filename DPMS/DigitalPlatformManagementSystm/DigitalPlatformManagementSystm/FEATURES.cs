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
    public partial class FEATURES : Form
    {
        string gelenVeri;
        public FEATURES(string data)
        {
            InitializeComponent();
            gelenVeri = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HOMEPACKAGE au = new HOMEPACKAGE(gelenVeri);
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

        private void FEATURES_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet6.additional_features' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.additional_featuresTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet6.additional_features);
            
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int af_id = random.Next(1003, 2000);
            string dubbing_language = textBox2.Text;
            string subtitle_language = textBox3.Text;
            string ThreeD = textBox4.Text;
           



            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "INSERT INTO additional_features (af_id, dubbing_language, subtitle_language, ThreeD) VALUES (@af_id, @dubbing_language, @subtitle_language, @ThreeD)";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@af_id", af_id);
                command.Parameters.AddWithValue("@dubbing_language", dubbing_language);
                command.Parameters.AddWithValue("@subtitle_language", subtitle_language);
                command.Parameters.AddWithValue("@ThreeD", ThreeD);
                



                connection.Open();


                command.ExecuteNonQuery();

                MessageBox.Show("Data adding successful.");

                
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.additional_featuresTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet6.additional_features);
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

            
            string af_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                
                string query = "DELETE FROM additional_features WHERE af_id = @af_id";

               
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@af_id", af_id);

               
                connection.Open();

               
                command.ExecuteNonQuery();

               
                MessageBox.Show("The selected row is succesfully deleted.");

                
                this.additional_featuresTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet6.additional_features);
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



            string af_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int afId;
            int.TryParse(af_id, out afId);

           
            string updatedData1 = textBox2.Text;

            string updatedData2 = textBox3.Text;

            string updatedData3 = textBox4.Text;
           


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE additional_features SET af_id = @af_id, dubbing_language = @updatedData1, subtitle_language = @updatedData2, ThreeD = @updatedData3  WHERE af_id = @af_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@updatedData1", updatedData1);
                command.Parameters.AddWithValue("@updatedData2", updatedData2);
                command.Parameters.AddWithValue("@updatedData3", updatedData3);
                command.Parameters.AddWithValue("@af_id", afId);

                connection.Open();

                
                command.ExecuteNonQuery();

               
                MessageBox.Show("Data is succesfully updated.");

                
                this.additional_featuresTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet6.additional_features);
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

        private void FEATURES_FormClosing(object sender, FormClosingEventArgs e)
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
        }
    }
}
