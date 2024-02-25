using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";
            conn = new SqlConnection(str);
            conn.ConnectionString = str;
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * from [dbo].[Table]";
            //string insertStr = "Insert into [dbo].[Table] VALUES(5,'Yunus','Vadodara');";
            //SqlCommand cmd1 = new SqlCommand(insertStr, conn);
            //int added = cmd1.ExecuteNonQuery();
            //listBox1.Items.Add("Inserted Successfully");
            string query = "Update [dbo].[Table] SET name='Shabana',address = 'Vadodara' Where Id=2";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            int updated = cmd1.ExecuteNonQuery();
            listBox1.Items.Add(updated + " Updated Successfully");
            string deleteQuery = "delete from [dbo].[Table] where Id=4";
            SqlCommand cmd2 = new SqlCommand(deleteQuery, conn);
            int deleted = cmd2.ExecuteNonQuery();
            listBox1.Items.Add(deleted +  " Deleted Successfully");
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                // Console.WriteLine(rdr.GetString(0));
                listBox1.Items.Add(rdr[0] );
                listBox1.Items.Add(rdr[1]);
            }
            

        }
    }
}
