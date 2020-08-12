<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="Cwebsite.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
  
          
</head>
<body >
   

    <form id="form1" runat="server">
   <div style="background-color: rgb(0,175,239);">
       <div>
        <div style="margin-bottom: 72px">
             <asp:Button ID="log" runat="server" Text="Login"  CssClass="centeredButton" OnClick="log_Click"/>
              <asp:Button ID="Signup" runat="server" Text="Create new user"  CssClass="centeredButton" OnClick="Signup_Click" Width="116px"/>  
        <p>

        </p>
      &nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Label ID="Label3" runat="server" Text="<b>COMING SOON</b>" ForeColor="White" BorderColor="White" CssClass="frontT"></asp:Label>
        
       <p> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            </p>

            <p>


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            
            </p>
            <p>

       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                       

            </p>
            <p>

          &nbsp;
            </p>
           
        </div>
          
            
<div style="padding:0 16px;">
     <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
    <p>
              <asp:TextBox ID="mail" runat="server" Text="Enter your mail"   Width="250px" CssClass="textbox"></asp:TextBox>
       </p> 


             <p>

                 <asp:Label ID="Label12" runat="server" Text="Enter your password"></asp:Label>
             </p>

              <asp:TextBox ID="password" runat="server"  Text="Enter your password" TextMode="Password" Width="250px" CssClass="textbox"></asp:TextBox>
           
            <p>

          &nbsp;
                <asp:Label ID="Label13" runat="server" Text="Confirm your password "></asp:Label>
            </p>

          <p>

          &nbsp;<asp:TextBox ID="confirmP" runat="server" CssClass="createTB2" Text="Confirm password" TextMode="Password" Width="250px"></asp:TextBox>

            

            
        

            
          </p>
        <p>

          &nbsp;
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            </p>
          <p>

              <asp:TextBox ID="phone" runat="server" CssClass="createTB" Text="Enter phone number" Width="250px"></asp:TextBox>

         
          </p>
    
     
           <p>   &nbsp;</p>
          <p>
        
                    <asp:TextBox ID="name" runat="server" CssClass="createTB" Text="Enter full name" Width="250px" ></asp:TextBox>
        

          </p>
           <p>   &nbsp;</p>
    <p>     


        <asp:TextBox ID="address" runat="server" CssClass="createTB" Text="Enter address" Width="250px"></asp:TextBox>
        

           </p>
   <p>
         <asp:TextBox ID="code" runat="server" CssClass="createTB" Text="Enter the code sent to your email" Width="250px"></asp:TextBox>
   </p>
      <p>  
    <asp:Button ID="loginB" runat="server" Text="log in" CssClass="button1" OnClick="loginB_Click" Height="33px" Width="77px"/>




            <asp:Button ID="create" runat="server" Text="create" CssClass="button1" OnClick="create_Click" Height="32px" Width="79px"/>
          <asp:Button ID="forget" runat="server" Text="forget your password" BackColor="Transparent" ForeColor="White" BorderColor="Transparent" OnClick="forget_Click" />
          <asp:Button ID="change" runat="server" Text="Change"  BackColor="Transparent" ForeColor="White" BorderColor="Transparent" OnClick="change_Click" />
       <asp:Button ID="save" runat="server" Text="Save"  BackColor="Transparent" ForeColor="White" BorderColor="Transparent" OnClick="save_Click"  />
  
      </p>


 <style>
    .frontT{
        color:rgb(10, 32, 43);
        font-size:100px;
        
    }
    .frontT2{
        color:rgb(10, 32, 43);
        font-size:30px;
       
    }
 
    
     .createTB{
        margin-top:10px;
         margin-left: 0px;
         direction: ltr;
         border-color:black;
     }
     .createLabel{
         margin-left:195px;
     }
              .centeredButton {
                  margin-top:20px;
                  margin-left:1300px;
                
                color:white;
                background-color:transparent;
                font-weight:bold;
                border-color:transparent;
                border-style:solid;
                
                }
              .createLabel2{
        
     }
              .centeredButton {
                  margin-top:20px;

                
                color:white;
                background-color:transparent;
                font-weight:bold;
                border-color:transparent;
                border-style:solid;
                
                }
             
              .textbox{
                  margin-top:0px;
         margin-left: 0px;
         border-color:black;
     }
       
    .button1{
        
        margin-top:10px;
        border-style:solid;
        background-color:white;
        font-size:large;
     
        
       
        
    }
    .label1{
      
    }
    .info{
        background-color:rgb(0,175,239);
    }
    
     .auto-style1 {
         width: 1136px;
         height: 456px;
         margin-left: 387px;
     }
    
     .createTB2 {         margin-left: 0px;
     }
    
     </style>  


        <p>
                    &nbsp;</p>
        

        <p>
            &nbsp;</p>
        
</div>
        

        <div>
            <p>
                
                <asp:Label ID="Label9" runat="server" Text="Contact Us:" CssClass="frontT2"></asp:Label>
                
            </p>
            <p>
                <asp:TextBox ID="cmail" runat="server" Width="210px" Text="Company email" ></asp:TextBox>
                <asp:TextBox ID="cphone" runat="server" Width="210px" Text="Company phone" style="margin-left: 43px"></asp:TextBox>
            </p>
            <p>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label4" runat="server" Text="This field is required" ></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server"  Text="This field is required"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </p>
            <p>
                <asp:TextBox ID="Fname" runat="server" Width="210px" Text="First name"></asp:TextBox>
                <asp:TextBox ID="Lname" runat="server" Width="210px" Text="Last name" style="margin-left: 43px"></asp:TextBox>
            </p>
            <p>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label6" runat="server" Text="This field is required"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="This field is required"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </p>
            <p>
                <asp:TextBox ID="message" runat="server" Width="659px" Text="message" Height="148px"></asp:TextBox>
               
            </p>
             <p>

                <asp:Label ID="Label8" runat="server" Text="This field is required"></asp:Label></p>
             <asp:Label ID="cookie" runat="server" Text=""></asp:Label></p>
        </div>

       </div>
        <asp:Button ID="send" runat="server" Text="send" CssClass="button1" Height="42px" Width="107px" OnClick="send_Click" />


        <div id="info">
            <img alt="" class="auto-style1" src="img/footer.png" /></div>

        </div>
    </form>




</body>

</html>
