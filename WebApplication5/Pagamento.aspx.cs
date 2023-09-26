using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Pagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
                SqlConnection conn = new SqlConnection(connectionString);
                List<Dipendenti> dipendentiList = new List<Dipendenti>();

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT IDDipendente, Nome, Cognome FROM T_Dipendenti", conn);
                    SqlDataReader sqlData;
                    sqlData = cmd.ExecuteReader();
                    while (sqlData.Read())
                    {
                        Dipendenti dipendente = new Dipendenti
                        {
                            Id = Convert.ToInt32(sqlData["IDDipendente"]),
                            Nome = sqlData["Nome"].ToString(),

                        };

                        dipendentiList.Add(dipendente);
                    }



                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    int idDipendente = Convert.ToInt32(Request.QueryString["ID"]);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO T_Pagamenti VALUES(@DataPagamento, @Ammontare, @TipoPagamento, @IdDipendente)";
                    cmd.Parameters.AddWithValue("DataPagamento", DataPagamento.Text);
                    cmd.Parameters.AddWithValue("Ammontare", Ammontare.Text);
                    cmd.Parameters.AddWithValue("TipoPagamento", PagamentoDropDown.SelectedValue);
                    cmd.Parameters.AddWithValue("IdDipendente", idDipendente);





                    int inserimentoEffettuato = cmd.ExecuteNonQuery();
                    if (inserimentoEffettuato > 0)
                    {



                    }
                    else
                    {

                    }

                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Label1.Text = "Si sono verificati errori di validazione.";
            }
        }
        
    }
}