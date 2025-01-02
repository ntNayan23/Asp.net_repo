using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        string connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }
        protected void btn_click(object sender, EventArgs e)
        {
            string query = "select * from user where email = @value and pass = @value2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string emailid = email_id.Value;
                    string pass = pwd.Value;
                    // Open the connection
                    connection.Open();

                    // Create the command object

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value", emailid);
                        command.Parameters.AddWithValue("@value2", pass);
                        // Execute the query and fetch the data
                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        // Loop through the data
                        if (userCount > 0)
                        {
                            
                            Session["Username"] = emailid;
                            Response.Redirect("DashBoard.aspx", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Cardentials");
                        }
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}