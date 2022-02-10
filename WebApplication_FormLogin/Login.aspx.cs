using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_FormLogin
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=FormLoginDetails;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(con.State== System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           display_Data();
           

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Login values('" + txtFirstName.Text + " ','" + txtLastName.Text + "','" + txtCity.Text + "')",con);
            cmd.ExecuteNonQuery();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";

           display_Data();
        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Login set FirstName= '" + txtFirstName.Text + " ', LastName='" + txtLastName.Text + "', City='" + txtCity.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "" ,con);
            cmd.ExecuteNonQuery();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";

           display_Data();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Login where FirstName= '" + txtFirstName.Text + " '";
            cmd.ExecuteNonQuery();

            txtFirstName.Text = "";
        
           display_Data();


        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            display_Data();

        }
         public void display_Data()
        {
            
             SqlCommand cmd = new SqlCommand("select * from Login",con) ;

             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             adapter.Fill(dt);
             GridView1.DataSource = dt;
             GridView1.DataBind();


        }  
    }
}