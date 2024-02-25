using System.Data;
using System.Data.SqlClient;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
namespace ADO.NETCon
{
    internal class Program
    {

        static void Main(string[] args)
        {

            SqlConnection con = null ;
            
            String conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";
            try
            {
                using (con = new SqlConnection(conStr))
                {

                    int ch;
                    
                    while(true)
                    {
                        Console.WriteLine("1) Insertion \n2) Updation \n3) Deletion \n4) Display \n5) Exit");
                        Console.WriteLine("Enter Your Choice:");
                        ch = Convert.ToInt32(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                insert(con);
                                break;
                            case 2:
                                update(con);
                                break;
                            case 3:
                                delete(con);
                                break;
                            case 4:
                                display(con);

                                break;
                                case 5:
                                Environment.Exit(0);
                                break;
                           

                        } 
                    } 


                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            string c = Console.ReadLine();
        }
        static void createTable(SqlConnection con)
        {
            string query = @"Create table employee(
                                     id int NOT NULL IDENTITY(1,1), 
                                     name nchar(20) NULL,
                                     address nchar(40) NULL,
                                     CONSTRAINT pk_id PRIMARY KEY (id)
                                     );";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Table Created Successfully");
            }
            else
            {
                Console.WriteLine("Table Creation Fialed");
            }
            con.Close();
        }
        static void insert(SqlConnection con)
        {
            Console.WriteLine("Enter Student Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Address :");
            string address = Console.ReadLine();
            string query = "INSERT INTO [dbo].[student] values(@name , @address) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Data Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Data Insertion Fialed");
            }
            con.Close();    
        }
        static void update(SqlConnection con)
        {
            Console.WriteLine("Enter Student Id :");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Student Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Address :");
            string address = Console.ReadLine();
            string query = "update [dbo].[student] set name=@name,address=@address where id=@id;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            int d = cmd.ExecuteNonQuery();
            if (d > 0)
            {
                Console.WriteLine("Data Updated Successfully");
            }
            else
            {
                Console.WriteLine("Data Updation Fialed");
            }
            con.Close();

        }
        static void delete(SqlConnection con)
        {
            Console.WriteLine("Enter Student Id :");
            string id = Console.ReadLine();
            string query = "DELETE from [dbo].[student] where id=@id;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Data Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Data Deletion Fialed");
            }
            con.Close();

        }
        static void display(SqlConnection con)
        {
            string query = "select * from [dbo].[student]";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Id = " + dr[0] + " Name = " + dr[1] + " Address : " + dr[2]);
                // Console.WriteLine("{0}, {1}, {2} ",dr[0] , dr[1] , dr[2]);

            }
            con.Close();
        }
        
    }
}
