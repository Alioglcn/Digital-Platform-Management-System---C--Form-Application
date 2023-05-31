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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DigitalPlatformManagementSystm
{
    
    public partial class ACTORS : Form
    {string gelenVeri;
        public ACTORS(string data)
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

        private void ACTORS_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'digitalPlatformManagementSystemDataSet1.actors' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            this.actorsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet1.actors);
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int actorId = random.Next(1003, 2000);
            string actorName = textBox2.Text;
            string age = textBox3.Text;

            
            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                
                string query = "INSERT INTO actors (actor_id, actor_name, age) VALUES (@actorId, @actorName, @age)";

                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@actorId", actorId);
                command.Parameters.AddWithValue("@actorName", actorName);
                command.Parameters.AddWithValue("@age", age);

               
                connection.Open();

               
                command.ExecuteNonQuery();

                MessageBox.Show("Data adding successful.");

                
               
                textBox2.Text = "";
                textBox3.Text = "";
                this.actorsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet1.actors);
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


            string actor_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "DELETE FROM actors WHERE actor_id = @actor_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@actor_id", actor_id);


                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("The selected row is succesfully deleted.");


                this.actorsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet1.actors);
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


            string actor_id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            int actorId;
            int.TryParse(actor_id, out actorId);

            float updatedData2;
            float.TryParse(textBox3.Text, out updatedData2);

            string updatedData1 = textBox2.Text;


            string connectionString = "Data Source=.;Initial Catalog=DigitalPlatformManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string query = "UPDATE actors SET actor_name = @updatedData1, age = @updatedData2  WHERE actor_id = @actor_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@updatedData1", updatedData1);
                command.Parameters.AddWithValue("@updatedData2", updatedData2);
                command.Parameters.AddWithValue("@actor_id", actorId);

                connection.Open();


                command.ExecuteNonQuery();


                MessageBox.Show("Data is succesfully updated.");


                this.actorsTableAdapter.Fill(this.digitalPlatformManagementSystemDataSet1.actors);
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

        private void ACTORS_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
         
        }
    }
}
