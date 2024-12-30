<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">



    <style type="text/css">
        .style2
        {
            height: 250px;
        }
        .style3
        {
            height: 64px;
        }
        .style4
        {
            height: 62px;
        }
        
        .ml 
        {
            margin-left:20px;
            
            }
        
        .style5
        {
            height: 62px;
          
        }
        .style6
        {
            height: 250px;
            position:fixed;
            left:0px;
       
        }
        
        .mr 
        {
            margin-right:-40px;
            }
        .size 
        {
            width:33%;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script> 
    <table class="style1" width="100%">
        <tr>
            <td class="style5 size" align="center">
              
            </td>
            <td class="style4 size" align="center" >
                
            </td>
            <td class="size" align="center">
                <asp:Button ID="btnlogout" runat="server" Text="Logout" BackColor="#854097" 
                    BorderColor="#854097" Font-Size="Medium" ForeColor="White" Height="38px" 
                    Width="103px" BorderStyle="None" onclick="btnlogin_Click" CssClass="mr" />
            </td>
        </tr>
        <tr>
            <td class="style6" id="ulist" width="30%">
                <asp:Panel ID="usersList" runat="server">
                </asp:Panel>
            </td>
            <td class="style2" width="70%" colspan="2">
                <table class="style1">
                <tr>
                
                <td width="35%">  <asp:Label ID="Label1" runat="server" Text="Sender User : " 
                    Font-Names="Arial Rounded MT Bold"></asp:Label>
                
                <asp:Label ID="lblusername" runat="server" Font-Bold="True" 
                    Font-Names="Franklin Gothic Heavy" Font-Size="X-Large" ForeColor="#854097" 
                    Text="Label" CssClass="ml"></asp:Label></td>
                   <td width="35%"><asp:Label ID="Label2" runat="server" Text="Receiver User : " 
                    Font-Names="Arial Rounded MT Bold"></asp:Label>
                <asp:Label ID="lblruname" runat="server" Font-Bold="True" 
                    Font-Names="Franklin Gothic Heavy" Font-Size="Large" ForeColor="#669900" 
                    Text="Receiver Name" CssClass="ml"></asp:Label></td>
                </tr>

                    <tr>
                        <td width="35%" id="slist">
                            <asp:Panel ID="sendmsglist" runat="server">
                                
                            </asp:Panel>
                        </td>
                        <td width="35%" id="rlist">
                           <asp:Panel ID="receivemsglist" runat="server">
                                </asp:Panel></td>
                    </tr>
                </table>
             </td>
           
        </tr>
        <tr>
            <td class="style3" colspan="3" align="center">
                <asp:TextBox ID="txtmsgbox" runat="server" placeholder="Write Message Here..." 
                    Height="50px" Width="300px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Send" Height="50px" 
                    Width="90px" BackColor="#854097" ForeColor="White" 
                    onclick="Button1_Click" />
            </td>
        </tr>
    </table>
    <script type="text/javascript">

        setInterval(function () {

            $("#ulist").load(location.href + " #ulist");
            $("#slist").load(location.href + " #slist");
            $("#rlist").load(location.href + " #rlist");

        
         },10);
    
    </script>
</asp:Content>

