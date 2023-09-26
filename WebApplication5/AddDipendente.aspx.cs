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
    public partial class AddDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO T_Dipendenti VALUES(@Nome, @Cognome, @Indirizzo, @CodiceFiscale, @Coniugato, @NumeroFigli, @Mansione)";
                cmd.Parameters.AddWithValue("Nome", Nome.Text);
                cmd.Parameters.AddWithValue("Cognome", Cognome.Text);
                cmd.Parameters.AddWithValue("Indirizzo", Indirizzo.Text);
                cmd.Parameters.AddWithValue("CodiceFiscale", CodiceFisc.Text);
                cmd.Parameters.AddWithValue("Coniugato", bool.Parse(ConiugatoDropDown.SelectedValue));
                int numeroFigli;
                if (int.TryParse(NumeroFigli.Text, out numeroFigli))
                {
                    cmd.Parameters.AddWithValue("NumeroFigli", numeroFigli);
                }

                cmd.Parameters.AddWithValue("Mansione", Mansione.Text);

                int inserimentoEffettuato = cmd.ExecuteNonQuery();
                if (inserimentoEffettuato > 0)
                {
                    Response.Write("inserimento effettuato con successo");

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
}