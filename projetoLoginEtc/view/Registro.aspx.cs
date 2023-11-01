using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace projetoLoginEtc.view
{
    public partial class Registro : System.Web.UI.Page
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
                dataShowUser();
            }
        }
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "INSERT INTO usuarios(nome, sobrenome, idade, email, senha)VALUES('" + txbNome.Text.ToString() + "', '" + txbSobrenome.Text.ToString() + "', '" + txbIdade.Text.ToString() + "', '" + txbEmail.Text.ToString() + "', '" + txbSenha.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dataShowUser();

            txbNome.Text = txbSobrenome.Text = txbIdade.Text = txbEmail.Text = txbSenha.Text = String.Empty;
        }
        public void dataShowUser()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM usuarios WHERE email='" + txbEmail.Text + "'";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            grvUsuarios.DataSource = ds;
            grvUsuarios.DataBind();
            con.Close();
        }
    }
}