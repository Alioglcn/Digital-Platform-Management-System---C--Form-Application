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
    public partial class REVIEWS : Form
    {
        string gelenVeri;
        public REVIEWS(string data)
        {
            InitializeComponent();
            gelenVeri = data;
        }

        private void REVIEWS_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet8.reviews' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.reviewsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet8.reviews);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int reviews_id = random.Next(1003, 2000);
            string reviews_title = textBox2.Text;
            string reviews_content = textBox3.Text;
            string total = textBox4.Text;
            


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "INSERT INTO reviews (reviews_id, reviews_title, reviews_content, total) VALUES (@reviews_id, @reviews_title, @reviews_content, @total)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@reviews_id", reviews_id);
                command.Parameters.AddWithValue("@reviews_title", reviews_title);
                command.Parameters.AddWithValue("@reviews_content", reviews_content);
                command.Parameters.AddWithValue("@total", total);
               




                connection.Open();

                command.ExecuteNonQuery();


                MessageBox.Show("Data adding successful.");


               
                textBox2.Text = "";
                textBox3.Text = "";
                this.reviewsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet8.reviews);
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while adding data: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;


            string reviews_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "DELETE FROM reviews WHERE reviews_id = @reviews_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@reviews_id", reviews_id);


                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("The selected row is succesfully deleted.");


                this.reviewsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet8.reviews);
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


            string reviews_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int reviewsId;
            int.TryParse(reviews_id, out reviewsId);

       

            string updatedData1 = textBox2.Text;

            string updatedData2 = textBox3.Text;

            string updatedData3 = textBox4.Text;
           


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE reviews SET reviews_title = @updatedData1, reviews_content = @updatedData2, total = @updatedData3  WHERE reviews_id = @reviews_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@updatedData1", updatedData1);
                command.Parameters.AddWithValue("@updatedData2", updatedData2);
                command.Parameters.AddWithValue("@updatedData3", updatedData3);

                command.Parameters.AddWithValue("@reviews_id", reviewsId);

                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("Data is succesfully updated.");


                this.reviewsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet8.reviews);
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

        private void REVIEWS_FormClosing(object sender, FormClosingEventArgs e)
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
