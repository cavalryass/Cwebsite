using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Configuration;

namespace Cwebsite
{
    public partial class Start : System.Web.UI.Page
    {
        
        
        
        Random r = new Random();
       
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\webDB.mdf;Integrated Security=True");// connection to the database
        protected void Page_Load(object sender, EventArgs e)
        {

            cookie.Visible = false;
            
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            clearF();
            



        }
        public void clearF()
        {
            Label1.Visible = false;
            
            Label4.Visible = false;
            Label12.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label13.Visible = false;
            mail.Visible = false;
            cookie.Visible = false;
            password.Visible = false;
            confirmP.Visible = false;
            cookie.Visible = false;
            forget.Visible = false;
            name.Visible = false;
            phone.Visible = false;
            address.Visible = false;
            code.Visible = false;
            change.Visible = false;
            save.Visible = false;
            loginB.Visible = false;
            create.Visible = false;

        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            clearF();
            Label12.Visible = true;
            Label13.Visible = true;
            
            mail.Text = "Enter your mail";
            mail.Visible = true;
            password.Text = "Enter your password";
            password.Visible = true;
            confirmP.Visible = true;
            
            name.Visible = true;
            phone.Visible = true;
            address.Visible = true;
            Label1.Visible = true;
            Label1.Text = "<b>Enter your details</b>";
            Label1.Visible = true;
            create.Visible = true;
            
           
            
        }

        protected void log_Click(object sender, EventArgs e)
        {
            clearF();
            mail.Text = "Enter your mail";
            mail.BorderColor = Color.Black;
            password.BorderColor = Color.Black;
            Label12.Visible = true;
            forget.Visible = true;       
            Label1.Visible = true;
           // Label2.Visible = false;
            Label1.Text = "<b>Log in:</b>";
            Label1.Visible = true;
            mail.Visible = true;
            password.Visible = true;
            loginB.Visible = true;
          
           
        }

        protected void loginB_Click(object sender, EventArgs e)
        {
            
             SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select status from MyUsers where mail = '"+mail.Text+"' AND password ='"+password.Text+"'";
                string s = "";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                            s = reader["status"].ToString();
                   

                }

            // cmd.ExecuteNonQuery();

            if (s == "client")
                System.Diagnostics.Process.Start("https://www.cavalryassociates.com/");// Response.Redirect("~/ClientFirstPage.aspx");
            else
            if (s == "admin" || s == "executive" || s == "ProjectM" || s == "secretary")
                Response.Redirect("~/employeeFirstP.aspx");
            else
            {
                Label1.Text = "Your mail or password are not correct";
                Label1.Visible = true;
            }




            }

        protected void create_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            
            if (password.Text == confirmP.Text)
            {
                try
                {


                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into MyUsers values('" + mail.Text + "','" + password.Text + "','" + "client" + "')";
                    
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into Client values('" + mail.Text + "','" + name.Text+ "','" + address.Text + "','" + phone.Text + "')";
                    cmd.ExecuteNonQuery();
                    System.Diagnostics.Process.Start("https://www.cavalryassociates.com/");
                }
                catch
                {
                    clearF();
                    mail.Text = "Enter your mail";
                    mail.Visible = true;
                    password.Text = "Enter you password";
                    password.Visible = true;
                    confirmP.Visible = true;                    
                    name.Visible = true;
                    phone.Visible = true;
                    address.Visible = true;
                    Label1.Visible = true;
                    Label1.Text = "<b>Enter your details</b>";
                    Label1.Visible = true;
                    create.Visible = true;
                    mail.BorderColor = Color.Red;
                    mail.Text = "Sorry that mail is taken. Try another";
                    Label13.Visible = true;
                    Label12.Visible = true;
                }

            }
            else
            {
                clearF();
                mail.Text = "Enter your mail";
                mail.Visible = true;
                password.Text = "Enter your password";
                password.Visible = true;
                confirmP.Visible = true;                
                name.Visible = true;
                phone.Visible = true;
                address.Visible = true;
                Label1.Visible = true;
                Label1.Text = "<b>Enter your details</b>";
                Label1.Visible = true;
                create.Visible = true;
                password.BorderColor = Color.Red;
                confirmP.BorderColor = Color.Red;
                Label14.ForeColor = Color.Red;
                Label14.Visible = true;
                Label14.Text = "Those password didn't match. Try again";

            
            
            }



        }
        //send mail not working
        protected void send_Click(object sender, EventArgs e)
        {
            cmail.BorderColor = Color.Black;
            cphone.BorderColor = Color.Black;
            Fname.BorderColor = Color.Black;
            Lname.BorderColor = Color.Black;
            message.BorderColor = Color.Black;
            if (cmail.Text == "" || cmail.Text == "Company email")
            {
                Label4.Visible = true;
                cmail.BorderColor = Color.Red;
            }
            else
            {
                if (cphone.Text == "" || cphone.Text == "Company phone")
                {
                    Label5.Visible = true;
                    cphone.BorderColor = Color.Red;
                }
                else
                {
                    if (Fname.Text == "" || Fname.Text == "First name")
                    {
                        Label6.Visible = true;
                        Fname.BorderColor = Color.Red;
                    }
                    else
                    {
                        if (Lname.Text == "" || Lname.Text == "Last name")
                        {
                            Label7.Visible = true;
                            Lname.BorderColor = Color.Red;
                        }
                        else
                        {
                            if (message.Text == "message" || message.Text == "")
                            {
                                Label8.Text = "This field is required";
                                Label8.Visible = true;

                                message.BorderColor = Color.Red;
                            }
                            else
                            {
                                // have to change



                                string to = "cavalryassociatesmailbox@gmail.com"; //To address    
                                string from = "cavalryassociatesmailbox@gmail.com"; //From address    
                                MailMessage mes = new MailMessage(from, to);


                                mes.Subject = "Cotact us message from" + Fname.Text + " " + Lname.Text;
                                mes.Body = Fname.Text + " " + Lname.Text + " Phone: " + cphone.Text + " mail: " + cmail.Text + "<br/>" + message.Text; ;
                                mes.BodyEncoding = Encoding.UTF8;
                                mes.IsBodyHtml = true;
                                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                                System.Net.NetworkCredential basicCredential1 = new
                                System.Net.NetworkCredential("cavalryassociatesmailbox@gmail.com", "aqaq1234");
                                client.EnableSsl = true;
                                client.UseDefaultCredentials = false;
                                client.Credentials = basicCredential1;
                                try
                                {
                                    client.Send(mes);
                                    Label8.Visible = true;
                                    Label8.Text = "the message sent";
                                    cmail.Text = "Company mail";
                                    cphone.Text = "Company phone";
                                    Lname.Text = "Last name";
                                    Fname.Text = "First name";
                                    message.Text = "Message";



                                }

                                catch (Exception ex)
                                {
                                    throw ex;
                                }


                                /*














                                using (MailMessage sendMail = new MailMessage())
                                {
                                    /*sendMail.From = new MailAddress(cmail.Text);
                                    sendMail.To.Add("avital@cavalrassociates.com");
                                    sendMail.Subject = "Cotact us message from" + Fname.Text + " " + Lname.Text;
                                    sendMail.Body = Fname.Text + " " + Lname.Text + " Phone: " + cphone.Text + " mail: " + cmail.Text + "<br/>" + message.Text;
                                    sendMail.IsBodyHtml = true;
                                    
                                    
                                       
                                    MailMessage msg = new MailMessage();

                                    msg.From = new MailAddress("cavalryassociatesmailbox@gmail.com");
                                    msg.To.Add("cavalryassociatesmailbox@gmail.com");
                                    msg.Subject = "test";
                                    msg.Body = "Test Content";
                                    msg.Priority = MailPriority.High;

                                    SmtpClient client = new SmtpClient("172.16.5.0");

                                  //  client.Credentials = new NetworkCredential("cavalryassociatesmailbox@gmail.com", "aqaq1234", "smtp.gmail.com");
                                    
                                    client.Port = 587;
                                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                    client.UseDefaultCredentials = false;
                                    client.Credentials = new System.Net.NetworkCredential("cavalryassociatesmailbox@gmail.com", "aqaq1234");
                                    client.EnableSsl = false;
                                    client.Timeout = 4000;
                                    
                                    //client.UseDefaultCredentials = true;

                                  // client.Send(msg);

                                }*/
                            }
                        }
                    }
                }
            }
        }

        protected void forget_Click(object sender, EventArgs e)
        {
            
            int x = 0;
            password.Visible = false;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MyUsers";
            string s = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = reader["mail"].ToString();
                if (s == mail.Text)
                {
                    x++;

                    //code.Visible = true;

                }
            }
            if (x == 0)
            {
                Label13.Text = "Sorry your mail doesn't exist in the system";
                Label13.Visible = true;
            }
            else
            {
                clearF();
                cookie.Text = r.Next().ToString();
                change.Visible = true;
                code.Visible = true;
               
                string to = mail.Text; //To address    
                string from = "cavalryassociatesmailbox@gmail.com"; //From address    
                MailMessage mes = new MailMessage(from, to);


                mes.Subject = "code fornew password";
                mes.Body = "the code is "+cookie.Text;
                mes.BodyEncoding = Encoding.UTF8;
                mes.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("cavalryassociatesmailbox@gmail.com", "aqaq1234");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(mes);
                   

                }

                catch (Exception ex)
                {
                    throw ex;
                }
                //rand++;
            }
        }

        protected void change_Click(object sender, EventArgs e)
        {
            //  rand--;
            try
            {
                if (code.Text== cookie.Text)
                {
                    clearF();
                    password.Visible = true;
                    confirmP.Visible = true;
                    save.Visible = true;
                    Label13.Text = "Confirm your password";
                    Label13.Visible = true;
                    Label12.Visible = true;
                    save.Visible = true;
               
                }

                else
                {
                    Label13.Visible = true;
                    Label13.Text = "Worng code";
                }
            }
            catch
            {
                Label13.Visible = true;
                Label13.Text = "Worng code";
            }

        }

        protected void save_Click(object sender, EventArgs e)
        {

            // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("update MyUsers Set password = '" + password.Text + "' where mail = '" + mail.Text+"'", con);
            cmd.Parameters.AddWithValue("password", password.Text);

            cmd.Parameters.AddWithValue("mail", mail.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            try
            {


                int rowsAffected = cmd.ExecuteNonQuery();
            }
            finally
            {
               //if (conn != null) { conn.Close(); }
            }




        }

        }
    }
    

        /*     

  }

  protected void Button2_Click(object sender, EventArgs e)
  {
      SqlCommand cmd = con.CreateCommand();
      cmd.CommandType = CommandType.Text;
      cmd.CommandText = "select * from MyUsers";
      string s="";
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
          s += reader[0]+"<br/>";
      // cmd.ExecuteNonQuery();
      Label1.Text = s;


  }*/


    
