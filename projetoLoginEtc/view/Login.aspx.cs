using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace projetoLoginEtc.view
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "";
            con.Open();

            if (!Page.IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            checkUsuario();
        }

        public void checkUsuario()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM usuarios WHERE email='" + txbEmail.Text + "' AND senha='" + txbSenha.Text + "'";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            SqlDataReader check = cmd.ExecuteReader();

            if (check.HasRows)
            {
                check.Read();

                string loginCookie = check["email"].ToString();
                HttpCookie login = new HttpCookie("login", loginCookie);
                Response.Cookies.Add(login);

                string IdUserCookie = check["id_user"].ToString();
                HttpCookie idUser = new HttpCookie("id_user", IdUserCookie);
                Response.Cookies.Add(idUser);

                Response.Redirect("../view/Dashboard.aspx");
            }
            else
            {
                Response.Write("<script> alert('Email e/ou Senha incorretos!');</script>").
                lblMensagem.Text = "Email e/ou Senha incorretos!";
            }
        }
    }
}