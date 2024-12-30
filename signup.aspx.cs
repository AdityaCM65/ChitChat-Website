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
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        con.Open();
        bool isUserExist = false;

        OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM myusers WHERE user_email = '"+ txtemail.Text +"'" , con);
        OleDbDataReader dr = cmd2.ExecuteReader();
        while(dr.Read()) {
            isUserExist = true;
        }

        if (isUserExist == true)
        {

            lblresult.Visible = true;

            lblresult.Text = "Email Already Registered !!!";
        }
        else
        {

            if (txtpass.Text == txtcpass.Text)
            {


                OleDbCommand cmd = new OleDbCommand("INSERT INTO myusers (user_name , user_pass , user_email , log_in) VALUES('" + txtname.Text + "' , '" + txtpass.Text + "' , '" + txtemail.Text + "' , 'Offline')", con);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    lblresult.Visible = true;
                    lblresult.ForeColor = System.Drawing.Color.Yellow;
                    lblresult.Text = "User Account Created";
                }
                else
                {

                    lblresult.Visible = true;

                    lblresult.Text = "User Account Not Created !!!";


                }
            }
            else {

                lblresult.Visible = true;

                lblresult.Text = "Password and Confirm Password Not Matched !!!";
            
            }
        }

        con.Close();
    }
}