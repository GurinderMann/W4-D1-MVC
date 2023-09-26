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
    public partial class Storico1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
                SqlConnection conn = new SqlConnection(connectionString);
                List<Pagamenti> listaPagamenti = new List<Pagamenti>();

                try
                {
                    conn.Open();
                    int idDipendenteFiltrato = Convert.ToInt32(Request.QueryString["ID"]); // ID del dipendente dalla query string

                    SqlCommand cmd = new SqlCommand("SELECT * FROM T_Pagamenti WHERE IdDipendente = @IdDipendente", conn);
                    cmd.Parameters.AddWithValue("@IdDipendente", idDipendenteFiltrato);

                    SqlDataReader sqlData;
                    sqlData = cmd.ExecuteReader();
                    while (sqlData.Read())
                    {
                        Pagamenti pagamenti = new Pagamenti
                        {
                            DataPagamento = (DateTime)sqlData["DataPagamento"],
                            Ammontare = (decimal)sqlData["Ammontare"],
                            TipoPagamento = sqlData["TipoPagamento"].ToString(),
                            IdDipendente = Convert.ToInt32(sqlData["IdDipendente"]),
                        };
                        listaPagamenti.Add(pagamenti);
                    }

                    repeaterStorico.DataSource = listaPagamenti;
                    repeaterStorico.DataBind();
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
       
    }
    public class Pagamenti
    {
        public DateTime DataPagamento { get; set; }
        public decimal Ammontare { get; set; }
        public string TipoPagamento { get; set; }

        public int IdDipendente { get; set; }
    }
}