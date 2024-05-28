using Productivity_Nexus.Components;
using Productivity_Nexus.Resources;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_Nexus.Helpers
{
    class DbHelper
    {
        static string conString = @"Data Source=DESKTOP-EV7IIH7\ZAEEM;Initial Catalog=newdb;Integrated Security=True";

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader reader;

        public DbHelper()
        {
            conn = new SqlConnection(conString);
            cmd = new SqlCommand();
        }

        public bool connect()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool disconnect()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public string InsertRow(string query)
        {
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        return "Row inserted successfully.";
                    }
                    else
                    {
                        return "No rows were inserted.";
                    }
                }
                else
                {
                    return "Failed to connect to database.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                disconnect();
            }
        }

        public string DeleteRow(string query)
        {
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Row deleted successfully." : "No rows were deleted.";
                }
                else
                {
                    return "Failed to connect to database.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                disconnect();
            }
        }

        public int GetTotalRowCount(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName};";
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar()); // ExecuteScalar used for single value
                    return rowCount; // Return the row count directly
                }
                else
                {
                    throw new Exception("Failed to connect to database.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed: " + ex.Message);
            }
            finally
            {
                disconnect();
            }
        }


        public string getButtons(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string id, name, description, status;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    description = reader[2].ToString();
                    status = reader[3].ToString();

                    //btnProduct btn = new btnProduct();
                    Projects_in_progress btn = new Projects_in_progress();

                   btn.ItemName = name;
                    btn.ItemDescription = description;
                    btn.ItemStatus= status;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }
        public string getButtons_for_completed(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string id, name, description, status;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    description = reader[2].ToString();
                    status = reader[3].ToString();

                    //btnProduct btn = new btnProduct();
                    Projects_completed btn = new Projects_completed();

                    btn.ItemName = name;
                    btn.ItemDescription = description;
                    btn.ItemStatuss = status;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }

        public string getButtons_for_canceled(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string id, name, description, status;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    description = reader[2].ToString();
                    status = reader[3].ToString();

                    //btnProduct btn = new btnProduct();
                   Projects_all btn = new Projects_all();

                    btn.ItemName = name;
                    btn.ItemDescription = description;
                    btn.ItemStatus = status;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }
        public string get_list(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string id, name, description, status;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    description = reader[2].ToString();


                    //btnProduct btn = new btnProduct();
                    list btn = new list();

                    btn.Title = name;
                    btn.Description = description;
                    

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }
        public string get_files(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string id, name, description, status;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                   


                    //btnProduct btn = new btnProduct();
                    files btn = new files();

                    btn.Title = name;
                    


                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }

        public bool userAuth(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM userlist WHERE name = @username AND password = @password;";
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar()); // ExecuteScalar used for single value
                    return result > 0; // If count is more than 0, credentials are correct
                }
                else
                {
                    throw new Exception("Failed to connect to the database.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed: " + ex.Message);
            }
            finally
            {
                disconnect();
                cmd.Parameters.Clear(); // Clear parameters to prevent issues on subsequent calls
            }
        }

    }
}
