using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingSample_1
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection _connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            // reading connection string name from web.config in <connectionStrings>
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            // connecting to database and opening it.
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        protected void Read_All_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            try
            {
                // Query object creation.
                SqlCommand command = new SqlCommand("SELECT * FROM Contacts", _connection);

                string result = string.Empty;

                // object for reading line by line
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result += "ID = " + Convert.ToString(reader["ID"]) + "; ";
                    result += "\t Name = " + Convert.ToString(reader["FirstName"]) + Convert.ToString(reader["LastName"]) + "; ";
                    result += " \t Email = " + Convert.ToString(reader["Email"]);
                    result += " \t Phone = " + Convert.ToString(reader["Phone"]);
                    result += "<br />";
                }
                ShowContact.Text = result;
            }
            catch (Exception ex)
            {
                ShowContact.Text = "Error:<br />" + ex.Message;
                ShowContact.ForeColor = Color.Red;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
        protected void Add_Contact_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteContact_Click(object sender, EventArgs e)
        {

        }

        
    }
}