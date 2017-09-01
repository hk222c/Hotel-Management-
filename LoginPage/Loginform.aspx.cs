using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Loginform : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = "select count(*) from customer where email= '" + emailuserBox.Text + "'";

        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();

        if (temp == 1)
        {
            conn.Open();
            string checkPass = "select passWords from customer where email= '" + emailuserBox.Text + "'";
            string custerId = "select cusId from customer where email= '" + emailuserBox.Text + "'";
            SqlCommand passcom = new SqlCommand(checkPass, conn);            

            string password = passcom.ExecuteScalar().ToString().Replace(" ", "");

            conn.Close();

            conn.Open();

            SqlCommand cuscom = new SqlCommand(custerId, conn);
            SqlDataReader dat = cuscom.ExecuteReader();

            int romnum = 0;

            if (dat.HasRows)
            {

                while (dat.Read())
                {
                    romnum = int.Parse(dat[0].ToString());
                }
            }

            if (password == passuserBox.Text)
            {
                Session["customerIds"] = romnum;
                conn.Close();
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Response.Write("Password is Not correct");
            }

        }
        else
        {
            Response.Write("Email not correct");
        }

        conn.Close();

    }
}