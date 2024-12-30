using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;


public partial class login : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\ADITYACM\\AspNet\\Database\\AdityaDB.accdb");
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        con.Open();

        bool isUserExist = false;

        OleDbCommand cmd = new OleDbCommand("SELECT * FROM myusers WHERE user_email = '"+ txtemail.Text +"'" , con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            if(txtpass.Text == dr["user_pass"].ToString()) {
                isUserExist = true;
                Session["uemail"] = txtemail.Text;
                Session["uname"] = dr["user_name"].ToString();

                OleDbCommand cmd2 = new OleDbCommand("UPDATE myusers SET log_in = 'Online' WHERE user_email='"+ txtemail.Text +"'" , con);
                cmd2.ExecuteNonQuery();
                Response.Redirect("home.aspx?runame="+ dr["user_name"].ToString() +"");

            }
            else {

                lblresult.Visible = true;

                lblresult.Text = "Invalid Credentials !!!";
            }
        }

        if(isUserExist == false) {


            lblresult.Visible = true;

            lblresult.Text = "Invalid Credentials (Email or Password) !!!";
        
        }

        con.Close();
    }
}