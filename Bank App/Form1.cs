using System.Data.SqlClient;
using System.Data;
using System;
namespace Bank_App
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }


        string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                string query = "Insert into [dbo].[bankAcc] VALUES(@name,@bankName,@accNo,@accType,@balance);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@bankName", txtBankName.Text);
                cmd.Parameters.AddWithValue("@accNo", Convert.ToInt64(txtAccNo.Text));
                cmd.Parameters.AddWithValue("@accType", cbAccType.Text);
                cmd.Parameters.AddWithValue("@balance", Convert.ToInt32(txtBalance.Text));
                int i = cmd.ExecuteNonQuery();

                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Insertion Failed");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the ID of the record to update:", "Update Record", "");

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            if (!int.TryParse(input, out int recordID))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "update [dbo].[bankAcc] set name=@name,bankName=@bankName,accNo=@accNo,accType=@accType,balance=@balance where id=@id;";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", recordID);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@bankName", txtBankName.Text);
            cmd.Parameters.AddWithValue("@accNo", Convert.ToInt64(txtAccNo.Text));
            cmd.Parameters.AddWithValue("@accType", cbAccType.Text);
            cmd.Parameters.AddWithValue("@balance", Convert.ToInt32(txtBalance.Text));
            int i = cmd.ExecuteNonQuery();

            con.Close();
            if (i > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Updation Failed");

            }


            // Disable update button until ID is submitted
            btnUpdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Store the ID
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "select * from [dbo].[bankAcc] ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the ID of the record to update:", "Update Record", "");

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            if (!int.TryParse(input, out int recordID))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "delete from [dbo].[bankAcc] where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", recordID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Deletion Failed");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
