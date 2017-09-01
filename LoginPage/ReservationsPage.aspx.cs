using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class ReservationsPage : System.Web.UI.Page
{

    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["customerIds"] == null)
        {
            Response.Redirect("Loginform.aspx");
        }
       
        

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ListItem romtype = (ListItem)dropdownRoom.SelectedItem;
        string roomBed = romtype.Value.ToString();
        bedNo.Text = "0";

        if (roomBed.Equals("1"))
        {
            bedNo.Text = "1";
            sizeNo.Text = "40";
            rateNo.Text = "700";
        }
        else if (roomBed.Equals("2"))
        {
            bedNo.Text = "2";
            sizeNo.Text = "80";
            rateNo.Text = "1500";
        }
        else if  (roomBed.Equals("3"))
        {
            bedNo.Text = "4";
            sizeNo.Text = "150";
            rateNo.Text = "2300";
        }
    }
    protected void resvButton_Click(object sender, EventArgs e)
    {
        ListItem romtype = (ListItem)dropdownRoom.SelectedItem;
        string roomBed = romtype.Value.ToString();
        string arvDate = checkIncal.SelectedDate.ToString();
        string levDate = checkOutcal.SelectedDate.ToString();
        string coments = comentsec.Text + "";

        conn.Open();
        string roomNumber = "select TOP 1 roomnumber from [room], [booking] where room.roomtypeid= @roomids AND NOT (room.roomnumber = booking.roomid)";
        SqlCommand com = new SqlCommand(roomNumber, conn);
        com.Parameters.AddWithValue("@roomids", roomBed);
        SqlDataReader dat =  com.ExecuteReader();

        int romnum = 0;

        if (dat.HasRows){        
        
             while (dat.Read())
        {
            romnum = int.Parse(dat[0].ToString());
        }

        }
        else
        {
            string roomber = "select TOP 1 roomnumber from [booking] where booking.roomid= @roomids AND (booking.arriveDate > @arivedate AND booking.arriveDate > @leavedate) OR (booking.leaveDate < @arivedate)";
            SqlCommand kom = new SqlCommand(roomber, conn);
            kom.Parameters.AddWithValue("@roomids", roomBed);
            kom.Parameters.AddWithValue("@arivedate", arvDate);
            kom.Parameters.AddWithValue("@leavedate", levDate);
            SqlDataReader sed = kom.ExecuteReader();

            if (sed.HasRows)
            {

                while (sed.Read())
                {
                    romnum = int.Parse(dat[0].ToString());
                }

            }
        }

        conn.Close();

        if (romnum != 0)
        {
            conn.Open();
            Response.Write(romnum);
            int sedata = (int)(Session["customerIds"]);
            int doe = int.Parse(roomBed);
            string insertQuery = "insert into [reservationapplication] (cusId,roomChoice,roomNo,arriveDate,leaveDate,comment) values (@cusids,@romtyid,@romids,@arives,@leves,@coment)";
            SqlCommand scomw = new SqlCommand(insertQuery, conn);
            scomw.Parameters.AddWithValue("@cusids", sedata);
            scomw.Parameters.AddWithValue("@romtyid", roomBed);
            scomw.Parameters.AddWithValue("@romids", romnum);
            scomw.Parameters.AddWithValue("@arives", arvDate);
            scomw.Parameters.AddWithValue("@leves", levDate);            
            scomw.Parameters.AddWithValue("@coment", coments);

            scomw.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("HomePage.aspx");
            Response.Write("Reservation is successful");


        }          

        conn.Close();
        Response.Redirect("HomePage.aspx");
        

        
        
    }
    protected void cancelButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}