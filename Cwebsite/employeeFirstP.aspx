<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employeeFirstP.aspx.cs" Inherits="Cwebsite.employeeFirstP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div  style="background-color: rgb(0,175,239);">
          <div>
            <p></p>
              <p><asp:Label ID="accNum" runat="server" Text="<b>Enter account number (you can also enter a name)</b>" ForeColor="White"></asp:Label></p>
              <p> <asp:TextBox ID="accountNum" runat="server"></asp:TextBox></p>
              <p><asp:Label ID="balancetxt" runat="server" Text="<b>Enter initial balance</b>" ForeColor="White"></asp:Label></p>
              <p> <asp:TextBox ID="balance" runat="server"></asp:TextBox></p>
              <p><asp:Label ID="ownerMailtxt" runat="server" Text="<b>Enter the mail of the account owner</b>" ForeColor="White"></asp:Label></p>
              <p> <asp:TextBox ID="ownerMail" runat="server" Text="not necessary"></asp:TextBox></p>
              <p><asp:Label ID="equitytxt" runat="server" Text="<b>Enter your equity</b>" ForeColor="White"></asp:Label></p>
              <p> <asp:TextBox ID="equity" runat="server"></asp:TextBox></p>
              <p><asp:Label ID="kind" runat="server" Text="<b>Enter kind of account</b>" ForeColor="White"></asp:Label></p>
              <p> 
                  <asp:DropDownList ID="kindlist" runat="server">
                      <asp:ListItem>company account</asp:ListItem>
                      <asp:ListItem>owner account</asp:ListItem>
                  </asp:DropDownList>
              </p>
              <p><asp:Button ID="create" runat="server" Text="create" BackColor="Transparent" ForeColor="White" Font-Size="Large" BorderColor="Transparent" Width="106px" OnClick="create_Click" />
              
                  <asp:Label ID="coment" runat="server" Text="" ForeColor="White"></asp:Label>
              </p>
           </div>


           
            <div>
                <p>
                   <asp:Label ID="fromL" runat="server" Text="From" ForeColor="White"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                   <asp:Label ID="toL" runat="server" Text=" To" ForeColor="White"></asp:Label>
                </p>
                <p>
                   <asp:TextBox ID="fromtxt" runat="server" Width="182px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                   <asp:TextBox ID="totxt" runat="server" Width="182px"></asp:TextBox>
                </p>
                <p>
                   <asp:Label ID="dateL" runat="server" Text="Date" ForeColor="White"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                   <asp:Label ID="AmountL" runat="server" Text="Amount" ForeColor="White"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="datetxt" runat="server"  Width="182px" ></asp:TextBox>
                    <asp:CheckBox ID="datecb" runat="server" Text="current date" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="amounttxt" runat="server" Width="182px"></asp:TextBox>
                </p>
                 <p>
                   <asp:Label ID="comentL" runat="server" Text="Coment" ForeColor="White"></asp:Label></p>
                <p>
                     <asp:TextBox ID="comenttxt" runat="server" Height="80px" Width="500px"></asp:TextBox>
                </p>
                <p><asp:Button ID="Addb" runat="server" Text="Add" BackColor="Transparent" ForeColor="White" Font-Size="Large" BorderColor="Transparent" Width="106px" OnClick="Addb_Click"  />
                    <asp:Label ID="addsSuccessfully" runat="server" Text="The addition was made successfully" ForeColor="White"></asp:Label>
                </p>
                
                <p>
                    &nbsp;</p>
            </div>
        </div>
    </form>
</body>
</html>
