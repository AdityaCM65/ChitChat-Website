using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Web.UI.HtmlControls;


public partial class home : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\ADITYACM\\AspNet\\Database\\AdityaDB.accdb");


    protected void Page_Load(object sender, EventArgs e)
    {

        if(Session["uemail"] == null) {
            Response.Redirect("login.aspx");
        }
        else {
        con.Open();

        lblusername.Text = Session["uname"].ToString();
        send_msg();
        receive_msg();
           OleDbCommand cmd = new OleDbCommand("SELECT * FROM myusers" , con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {


            if (Session["uemail"].ToString() == dr["user_email"].ToString())
            {

            }

            else
            {
                var a1 = new HtmlGenericControl("a") { InnerHtml = dr["user_name"].ToString() + " " + dr["log_in"].ToString()};
                a1.Attributes.Add("style", "text-decoration:none; margin:5px 8px; padding:4px 10px; background-color:#854097; color:yellow; border-radius:10px;");
                a1.Attributes.Add("href", "home.aspx?runame=" + dr["user_name"].ToString() + "");
                usersList.Controls.Add(a1);

                var br = new HtmlGenericControl("br");
                usersList.Controls.Add(br);
            }
        }

            lblruname.Text = Request.QueryString["runame"].ToString();

        con.Close();

 
        }

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {

        con.Open();
        OleDbCommand cmd2 = new OleDbCommand("UPDATE myusers SET log_in = 'Offline' WHERE user_email='" + Session["uemail"].ToString() + "'", con);
        cmd2.ExecuteNonQuery();
        con.Close();
        Session["uemail"] = null;
        Session["uname"] = null;
        Session.Abandon();
        Response.Redirect("login.aspx");

    }



    public void send_msg() {

        
        OleDbCommand cmd = new OleDbCommand("SELECT * FROM users_chat WHERE sender_username='" + Session["uname"].ToString() + "' AND receiver_username='"+ Request.QueryString["runame"].ToString() +"'" , con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            var h2 = new HtmlGenericControl("h2") { InnerHtml = dr["msg_content"].ToString()};
            h2.Attributes.Add("style", "color:purple; background-color:yellow; border-radius:20px; padding-left:5px; padding:4px 0px; margin:5px 0px; background-position:center; text-align:center; ");
            sendmsglist.Controls.Add(h2);
        }
    
    
    }

    public void receive_msg()
    {


        OleDbCommand cmd = new OleDbCommand("SELECT * FROM users_chat WHERE sender_username='" + Request.QueryString["runame"].ToString() +"' AND receiver_username='" + Session["uname"].ToString() + "'", con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            var h2 = new HtmlGenericControl("h2") { InnerHtml = dr["msg_content"].ToString() };
            h2.Attributes.Add("style", "color:yellow; background-color:purple; border-radius:20px; padding-left:5px; padding:4px 0px; margin:5px 0px; background-position:center; text-align:center; ");

            receivemsglist.Controls.Add(h2);
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        OleDbCommand cmd = new OleDbCommand("INSERT INTO users_chat (sender_username , receiver_username , msg_content) VALUES('"+ Session["uname"].ToString() +"' , '"+ Request.QueryString["runame"].ToString() +"' , '"+ txtmsgbox.Text +"')" , con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}