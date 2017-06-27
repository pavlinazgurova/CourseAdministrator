using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseAdministrator
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string UserName = userNameTxt.Text;
            string Password = passwordTxt.Text;
            SqlCommand cmd = new SqlCommand
                ("select UserName, Password from Login where UserName ='" + userNameTxt.Text + "'and Password ='" + passwordTxt.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {              
                Menu srch = new Menu();
                srch.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невалидни данни!");
            }
            con.Close();            
        }
    }
}
