using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cwebsite
{
    public partial class employeeFirstP : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\webDB.mdf;Integrated Security=True");// connection to the database

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            coment.Text = "";
           
            addsSuccessfully.Visible = false;



        }

        protected void create_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            try
            {


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Account values('" + accountNum.Text + "','" + ownerMail.Text + "','" + balance.Text + "','" + equity.Text + "','" +"0" + "','" +kindlist.Text+ "')";

                cmd.ExecuteNonQuery();
               
            }
            catch
            {
                coment.Text = "Sorry but this account already exists in our system";
            }

        }


        public int returnd()
        {
            con.Close();
            con.Open();
            int x = 0;
            int id = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from balanceInformation";
            string mys = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                mys = reader["id"].ToString();
                if (id < Convert.ToInt32(mys))
                {
                    id=Convert.ToInt32(mys);
                }
            }
            id++;
            con.Close();
            return id;
           
        }
        protected void Addb_Click(object sender, EventArgs e)//adding new tranfer to the database and updating the system with the new balance and debts
        {
            int x = 0;
            int y = 0;
            //first level cheak if everything is writen good
            if (fromtxt.Text == "" || fromtxt.Text == "This field is empty")
            {
                fromtxt.Text = "Sorry this account doesn't exists";
                fromtxt.BorderColor = Color.Red;
            }
            else
            {
                //cheak if thoese account are exists
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Account";
                string s = "";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s = reader["accountNum"].ToString();
                    if (s == fromtxt.Text)
                    {
                        x++;
                    }
                    if (s == totxt.Text)
                    {
                        y++;
                    }
                }
                if (x == 0)
                {
                    fromtxt.Text = "Sorry this account doesn't exists";
                    fromtxt.BorderColor = Color.Red;

                }
                else
                {
                    if (y == 0)
                    {
                        totxt.Text = "Sorry this account doesn't exists";
                        totxt.BorderColor = Color.Red;

                    }
                    else
                    {
                        if (datecb.Checked)
                        {
                            
                            datetxt.Text = DateTime.Now.ToString();
                        }
                        try {
                            if (!(Convert.ToDateTime(datetxt.Text) <= DateTime.Now))
                            {
                                datetxt.Text = "This date isn't available";
                                datetxt.BorderColor = Color.Red;
                            }

                            else
                            {


                                if (Convert.ToDouble(amounttxt.Text) > 0 || amounttxt.Text != "")
                                {
                                    if (comenttxt.Text != "")
                                    {

                                     
                                        //separation between company to company and other combition
                                        //cheak from  kind

                                        con.Open();
                                        cmd.CommandType = CommandType.Text;
                                        cmd.CommandText = "select kind from Account where accountNum = '"+fromtxt.Text+"'";
                                        string accountKindF = "";
                                        
                                        SqlDataReader reader1 = cmd.ExecuteReader();
                                        while (reader1.Read())
                                        {
                                            accountKindF = reader1["kind"].ToString();
                                        }
                                        con.Close();
                                        //cheak to  kind

                                        con.Open();
                                        cmd.CommandType = CommandType.Text;
                                        cmd.CommandText = "select kind from Account where accountNum = '" + totxt.Text + "'";
                                        string accountKindT = "";

                                        reader1 = cmd.ExecuteReader();
                                        while (reader1.Read())
                                        {
                                            accountKindT = reader1["kind"].ToString();
                                        }
                                        con.Close();

                                        //company to company
                                        if(accountKindF=="company account"&&accountKindT=="company account")
                                        {
                                            //saving from balance
                                            con.Open();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "select Balance from Account where accountNum = '" + fromtxt.Text + "'";
                                            double fromBalance=0;

                                            reader1 = cmd.ExecuteReader();
                                            while (reader1.Read())
                                            {
                                                fromBalance+=Convert.ToDouble( reader1["Balance"].ToString());
                                            }
                                            con.Close();
                                            //saving to balance
                                            con.Open();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "select Balance from Account where accountNum = '" + totxt.Text + "'";
                                            double toBalance=0;

                                            reader1 = cmd.ExecuteReader();
                                            while (reader1.Read())
                                            {
                                                toBalance+= Convert.ToDouble(reader1["Balance"].ToString());
                                            }
                                            con.Close();


                                            fromBalance = fromBalance - Convert.ToDouble(amounttxt.Text);
                                            toBalance=toBalance+ Convert.ToDouble(amounttxt.Text); ;
                                            //update the database with the new balance
                                            //we are in a company to company transfer so only the balance of each account should be update. no debt to our company
                                            con.Open();
                                            cmd = new SqlCommand("update Account Set Balance = '"+fromBalance.ToString() + "' where accountNum = '" + fromtxt.Text + "'", con);
                                            cmd.Parameters.AddWithValue("Balance", fromBalance.ToString());

                                            cmd.ExecuteNonQuery();
                                            cmd.Dispose();

                                            cmd.ExecuteNonQuery();
                                            cmd = new SqlCommand("update Account Set Balance = '" + toBalance.ToString() + "' where accountNum = '" + totxt.Text + "'", con);
                                            cmd.Parameters.AddWithValue("Balance", toBalance.ToString());

                                            cmd.ExecuteNonQuery();
                                            cmd.Dispose();

                                            cmd.ExecuteNonQuery();







                                        }

                                        //other combonition
                                        else
                                        {
                                            //saving from balance
                                            con.Open();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "select Balance,debt from Account where accountNum = '" + fromtxt.Text + "'";
                                            double fromBalance = 0;
                                            double fromDebts = 0;

                                            reader1 = cmd.ExecuteReader();
                                            while (reader1.Read())
                                            {
                                                fromBalance += Convert.ToDouble(reader1["Balance"].ToString());
                                                fromDebts+= Convert.ToDouble(reader1["debt"].ToString());
                                            }
                                            con.Close();
                                            //saving to balance
                                            con.Open();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "select Balance,debt from Account where accountNum = '" + totxt.Text + "'";
                                            double toBalance = 0;
                                            double toDebts = 0;
                                            reader1 = cmd.ExecuteReader();
                                            while (reader1.Read())
                                            {
                                                toBalance += Convert.ToDouble(reader1["Balance"].ToString());
                                                toDebts+= Convert.ToDouble(reader1["debt"].ToString());
                                            }
                                            con.Close();
                                            //choosing if it is loan or return by cheacking the past debts
                                            double amountsum1 = 0;
                                            double amountsum2 = 0;
                                            con.Open();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "select amount from BalanceInformation where requestTo = '" + totxt.Text + "' AND requestFrom = '" + fromtxt.Text +"'";
                                            
                                            reader1 = cmd.ExecuteReader();
                                            while (reader1.Read())
                                            {
                                                amountsum1 += Convert.ToDouble(reader1["amount"].ToString());
                                                //toDebts += Convert.ToDouble(reader1["debt"].ToString());
                                            }
                                            con.Close();

                                            con.Open();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "select amount from BalanceInformation where requestTo = '" + fromtxt.Text + "' AND requestFrom = '" + totxt.Text + "'";

                                            reader1 = cmd.ExecuteReader();
                                            while (reader1.Read())
                                            {
                                                amountsum2 += Convert.ToDouble(reader1["amount"].ToString());
                                                //toDebts += Convert.ToDouble(reader1["debt"].ToString());
                                            }
                                            con.Close();
                                            if (amountsum2 - amountsum1 <=Convert.ToDouble(amounttxt.Text))
                                            {
                                                fromBalance -= Convert.ToDouble(amounttxt.Text);
                                                toBalance += Convert.ToDouble(amounttxt.Text);
                                                fromDebts -= Convert.ToDouble(amounttxt.Text);
                                                toDebts += Convert.ToDouble(amounttxt.Text);
                                            }
                                            else
                                            {
                                                fromBalance -= Convert.ToDouble(amounttxt.Text);
                                                toBalance += Convert.ToDouble(amounttxt.Text);
                                                fromDebts += Convert.ToDouble(amounttxt.Text);
                                                toDebts -= Convert.ToDouble(amounttxt.Text);
                                            }
                                            con.Close();

                                            con.Open();
                                            cmd = new SqlCommand("update Account Set Balance = '" + fromBalance.ToString() + "', debt = '"+fromDebts.ToString()+"' where accountNum = '" + fromtxt.Text + "'", con);
                                            cmd.Parameters.AddWithValue("Balance", fromBalance.ToString());
                                            cmd.Parameters.AddWithValue("debt", fromDebts.ToString());

                                            cmd.ExecuteNonQuery();
                                            cmd.Dispose();

                                            cmd.ExecuteNonQuery();
                                            cmd = new SqlCommand("update Account Set Balance = '" + toBalance.ToString() + "', debt = '" + toDebts.ToString() + "' where accountNum = '" + totxt.Text + "'", con);
                                            cmd.Parameters.AddWithValue("Balance", toBalance.ToString());
                                            cmd.Parameters.AddWithValue("debt", toDebts.ToString());
                                            cmd.ExecuteNonQuery();
                                            cmd.Dispose();

                                            cmd.ExecuteNonQuery();
                                            addsSuccessfully.Visible = true;


                                        }


                                        cmd.CommandType = CommandType.Text;

                                        int id = returnd();
                                        con.Open();
                                        //adding transfer to the database
                                        cmd.CommandText = "insert into balanceInformation values('" + id.ToString() + "','" + datetxt.Text + "','" + totxt.Text + "','" + fromtxt.Text + "','" + comenttxt.Text + "','" + amounttxt.Text + "')";

                                        cmd.ExecuteNonQuery();

                                        con.Close();
                                    }
                                    else
                                    {
                                        comenttxt.Text = "this field is empty";
                                        comenttxt.BorderColor = Color.Red;
                                    }
                                }

                                else
                                {
                                    amounttxt.Text = "This field is empty";
                                    amounttxt.BorderColor = Color.Red;

                                }
                            }
                        }
                        catch
                        {
                            datetxt.Text = "This date isn't available";
                            datetxt.BorderColor = Color.Red;
                        }
                    }

                    }
                }
            }
        }
    }

