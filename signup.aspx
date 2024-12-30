<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
   
    

    <table class="style1"  style="display:flex; justify-content:center; align-items:center; margin-left:30px;  width:50%; align="center" >
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Create Account" Font-Bold="True" 
                    Font-Size="X-Large" ForeColor="#854097"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtname"  runat="server" placeholder="Enter Your Name" Height="48px" 
                    Width="522px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtemail" runat="server" placeholder="Enter Your Email" Height="48px" 
                    Width="522px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtpass" runat="server" placeholder="Enter Your Password" Height="48px" 
                    Width="522px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtcpass" runat="server" placeholder="Confirm Password" Height="48px" 
                    Width="522px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnsignup" runat="server" Text="Signup" BackColor="#854097" 
                    BorderColor="#854097" Font-Size="Medium" ForeColor="White" Height="38px" 
                    Width="103px" BorderStyle="None" Font-Names="Gadugi" 
                    onclick="btnsignup_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblresult" runat="server" Font-Bold="True" Font-Names="Gadugi" 
                    ForeColor="Red" Text="Email Already Registered !!!" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Already have an Account "></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/login.aspx">Login</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

