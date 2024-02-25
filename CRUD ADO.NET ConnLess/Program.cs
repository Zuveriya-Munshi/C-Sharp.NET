using System.Data;
using System.Data.SqlClient;
using System;
using System.Data.Common;
namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";
            SqlDataAdapter sda = null;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string query = "Select * from [dbo].[employee]";
                     sda= new SqlDataAdapter(query, con);
                    SqlCommandBuilder scd = new SqlCommandBuilder(sda);
                    DataTable employee = new DataTable("employee");
                    employee.PrimaryKey = new DataColumn[] { employee.Columns["id"] };
                    sda.MissingSchemaAction = MissingSchemaAction.AddWithKey; 

                    sda.Fill(employee);
                   // employee.PrimaryKey = new DataColumn[] { employee.Columns["id"] };

                    /*DataColumn id = new DataColumn("id");
                     DataSet ds = new DataSet();
                     sda.Fill(ds);
                     foreach(DataRow row in ds.Tables[0].Rows)
                     {
                         Console.WriteLine("{0} , {1}, {2}",row[0], row[1], row[2]);
                     }
                    id.ColumnName = "ID";
                    id.AllowDBNull = false;
                    id.DataType = typeof(int);
                    id.AutoIncrement = true;
                    id.AutoIncrementSeed = 1;
                    id.AutoIncrementStep = 1;
                    employee.Columns.Add(id);

                    DataColumn name = new DataColumn("name");
                    name.ColumnName = "Name";
                    name.AllowDBNull = false;
                    name.DataType = typeof(string);
                    name.MaxLength = 30;
                    employee.Columns.Add(name);


                    DataColumn salary = new DataColumn("salary");
                    salary.ColumnName = "Salary";
                    salary.AllowDBNull = true;
                    salary.DataType = typeof(int);
                    employee.Columns.Add(salary);


                    DataRow row1 = employee.NewRow();
                    row1["id"] = 1;
                    row1["name"] = "Zuveriya";
                    row1["salary"] = 100000;
                    employee.Rows.Add(row1);
                    employee.Rows.Add(2, "Safiya", 95000);
                    
                    DataSet ds = new DataSet();
                    ds.Tables.Add(employee);    
                    foreach (DataRow row in employee.Rows)
                    {
                        Console.WriteLine("{0} {1} {2}", row[0], row[1], row[2]);

                    }*/
                    while (true)
                    {
                        Console.WriteLine("Choose an operation:");
                        Console.WriteLine("1. Insert Record");
                        Console.WriteLine("2. Read Records");
                        Console.WriteLine("3. Update Record");
                        Console.WriteLine("4. Delete Record");
                        Console.WriteLine("5. Exit");
                        Console.WriteLine("Enter Your Choice : ");
                        int ch = Convert.ToInt32(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                insert(employee,sda);
                                break;
                            case 2:
                                read(employee, sda);
                                break;
                            case 3:
                                update(employee,sda);
                                break;
                            case 4:
                                delete(employee,sda);
                                break;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please select a valid operation.");
                                break;

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            static void insert(DataTable employee, SqlDataAdapter sda)
            {
                DataRow dataRow = employee.NewRow();
                Console.WriteLine("Enter Name : ");
                string name = Console.ReadLine();
                dataRow["name"] = name;
                Console.WriteLine("Enter Salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());
                dataRow["salary"] = salary;
                employee.Rows.Add(dataRow);
                sda.Update(employee);
                Console.WriteLine("Record Inserted Successfully");
            }

            static void read(DataTable employee, SqlDataAdapter sda)
            {

            Console.WriteLine("Employee Table Details");
                foreach (DataRow row in employee.Rows) {
                    Console.WriteLine(row["id"] + " " + row["name"] + " " + row["salary"]);
                }

            }
            static void update(DataTable employee, SqlDataAdapter sda)
            {

            Console.WriteLine("Enter the Id : ");
            int id = Convert.ToInt32(Console.ReadLine());   
            DataRow upRow = employee.Rows.Find(id);
            if(upRow != null)
            {
                Console.WriteLine("Enter the Name : ");
                string upName = Console.ReadLine();
                upRow["name"] = upName;
                Console.WriteLine("Enter Salary : ");
                int upSalary = Convert.ToInt32(Console.ReadLine());
                upRow["salary"] = upSalary;
                sda.Update(employee);
                Console.WriteLine("Row Updated Successfully");

            }
            else
            {
                Console.WriteLine($"Record with id {id} not found");
            }


            }
            static void delete(DataTable employee, SqlDataAdapter sda)
            {

            Console.WriteLine("Enter the Id : ");
            int id = Convert.ToInt32(Console.ReadLine());   
            DataRow rowDelete = employee.Rows.Find(id); 
            if(rowDelete != null)
            {
                rowDelete.Delete();
                sda.Update(employee);
                Console.WriteLine("Record Deleted Successfully");
            }
            else
            {
                Console.WriteLine($"Record with id {id} not found.");

            }

        }

        }
    }

