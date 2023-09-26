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
    public partial class Gestionale : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM T_Dipendenti", conn);
                    SqlDataReader sqlData;
                    sqlData = cmd.ExecuteReader();
                    while (sqlData.Read())
                    {
                        Dipendenti dipendente = new Dipendenti
                        {
                            Nome = sqlData["Nome"].ToString(),
                            Cognome = sqlData["Cognome"].ToString(),
                            Indirizzo = sqlData["Indirizzo"].ToString(),
                            CodiceFiscale = sqlData["CodiceFiscale"].ToString(),
                            Coniugato = Convert.ToBoolean(sqlData["Coniugato"]),
                            NumeroFigli = Convert.ToInt32(sqlData["NumeroFigli"]),
                            Mansione = sqlData["Mansione"].ToString(),
                            Id = Convert.ToInt32(sqlData["IDDipendente"])
                        };

                        dipendentiList.Add(dipendente);

                    }
                    repeaterDipendenti.DataSource = dipendentiList;
                    repeaterDipendenti.DataBind();
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
    public class Dipendenti
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CodiceFiscale { get; set; }
        public bool Coniugato { get; set; }
        public int NumeroFigli { get; set; }
        public string Mansione { get; set; }
        public int Id { get; set; }


    }
}