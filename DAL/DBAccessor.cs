using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBAccessor
    {
        string connectionString;

        public DBAccessor()
        {
            connectionString = "Data Source=osmaniauniversity.database.windows.net;Initial Catalog=osmaniauniversity;Persist Security Info=True;User ID=khalid;Password=99%isnotenough";
        }

        public string getFacultyPassword(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("select * from Faculty where FacultyId = " + "'" + loginid + "'", con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string password = reader.GetString(2);
                    return password;

                }
            }

        }

        public string getFacultyName(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("select * from Faculty where FacultyId = " + "'" + loginid + "'", con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string Name = reader.GetString(1);
                    return Name;

                }
            }

        }


        public Boolean FacultyId_Exists(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("select FacultyId from Faculty where FacultyId = " + "'" + loginid + "'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("exception at FacultyId_Exists");
                }

                return false;
            }
        }


        public string getStudentPassword(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("select * from Student where RollNo = " + "'" + loginid + "'", con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string password = reader.GetString(2);
                    return password;

                }
            }

        }

        public string getStudentName(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("select * from Student where RollNo = " + "'" + loginid + "'", con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string Name = reader.GetString(1);
                    return Name;

                }
            }

        }

        public Boolean RollNo_Exists(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("select RollNo from Student where RollNo = " + "'" + loginid + "'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("exception at RollNo_Exists");
                }

                return false;
            }
        }


        public string getAdminPassword(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("select * from Admin where AdminId = " + "'" + loginid + "'", con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string password = reader.GetString(2);
                    return password;

                }
            }

        }

        public Boolean AdminId_Exists(string loginid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("select AdminId from Admin where AdminId = " + "'" + loginid + "'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("exception at AdminId_Exists");
                }

                return false;
            }
        }


    }
}
