using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_WINDOWS
{
    public partial class ELIMINAR : Form
    {
        public ELIMINAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_BUSCARPRODUCTOS2", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterID.Value = Convert.ToInt32(txtID.Text);

                    sqlCommand.Parameters.Add(sqlParameterID);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        txtID.Text = Convert.ToString(reader["IdProducto"]);
                        txtNOMBRE.Text = reader["Nombre"].ToString();
                        txtPRECIO.Text = Convert.ToString(reader["precio"]);
                        txtSTOCK.Text = Convert.ToString(reader["stock"]);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_ELIMINARPRODUCTOS", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterID.Value = txtID.Text;

                    sqlCommand.Parameters.Add(sqlParameterID);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Elimación satisfatoria");
                    txtNOMBRE.Clear();txtID.Clear(); txtPRECIO.Clear(); txtSTOCK.Clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }

    }
}

    
