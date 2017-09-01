using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from customer where email= '" + emailBox.Text + "'";

            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already Exists");
            }

            conn.Close();
        }
    }
    protected void reges_Click(object sender, EventArgs e)
    {
        try
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into customer (firstName,lastName,email,passWords,phoneNo) values (@firstN,@lastN,@emails,@passes,@phones)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@firstN", firstBox.Text);
            com.Parameters.AddWithValue("@lastN", lastBox.Text);
            com.Parameters.AddWithValue("@emails", emailBox.Text);
            com.Parameters.AddWithValue("@passes", passBox.Text);
            com.Parameters.AddWithValue("@phones", phoneBox.Text);

            com.ExecuteNonQuery();
            Response.Redirect("Loginform.aspx");
            Response.Write("Registration is successful");

            conn.Close();

        }
        catch (Exception ex)
        {
            Response.Write("Big lll Error:" + ex.ToString());
        }
        
        
        
    }
    
}