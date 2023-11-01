using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace projetoLoginEtc.view
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=36DE250025\\SENAC;Initial Catalog=login;Integrated Security=True";
            con.Open();

            ObterRequisicaoCookie();
            if (this.Page.Request.Cookies["login"] != null)
            {
                dataShow();
            }
            else
            {
                Response.Redirect("../view/Login.aspx");
            }
        }

        public void ObterRequisicaoCookie()
        {
            if (this.Page.Request.Cookies["login"] != null)
            {
                HttpCookie cookie = this.Page.Request.Cookies["login"];
                lblUsuario.Text = cookie.Value.ToString();
            }
            else
            {
                Response.Redirect("../view/Login.aspx");
            }
        }

        public void dataShow()
        {
            ds = new DataSet();

            HttpCookie cookie = this.Page.Request.Cookies["id_user"];

            int id_user = Convert.ToInt32(cookie.Value);

            cmd.CommandText = "SELECT * FROM usuarios WHERE id_user='"+id_user+"'";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            grvUsuario.DataSource = ds;
            grvUsuario.DataBind();
            con.Close();
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = this.Page.Request.Cookies["id_user"];

            int id_user = Convert.ToInt32(cookie.Value);
            con.Open();

            dt = new DataTable();
            cmd.CommandText = "UPDATE usuarios SET nome='"+txbNome.Text.ToString()+"', sobrenome='"+txbSobrenome.Text.ToString()+"', idade='"+Convert.ToInt32(txbIdade.Text)+ "', email='"+txbEmail.Text.ToString()+"', senha='"+txbSenha.Text.ToString()+"' WHERE id_user='"+id_user+"'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dataShow();

            Response.Write("<script>alert('Atualizado para "+ txbEmail.Text.ToString() + "!');window.location='../view/Logout.aspx';</script>");
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = this.Page.Request.Cookies["id_user"];

            int id_user = Convert.ToInt32(cookie.Value);
            con.Open();

            dt = new DataTable();
            cmd.CommandText = "DELETE usuarios WHERE id_user='"+id_user+"'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dataShow();

            Response.Write("<script> alert('APAGADO!');window.location='../view/Logout.aspx';</script>");
        }
    }
}