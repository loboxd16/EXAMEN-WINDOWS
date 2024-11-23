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
    public partial class CREAR : Form
    {
        public CREAR()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
         
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;


            Producto producto = new Producto
            {
                Nombre = txtNOMBRE.Text,
                Precio = Convert.ToInt32(txtPRECIO.Text),
                Stock = Convert.ToInt32(txtSTOCK.Text)
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_INSERTAR2", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    

                    sqlParameterNombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    sqlParameterNombre.Value = producto.Nombre;

                    sqlParameterPrecio = new SqlParameter("@Precio", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = producto.Precio;

                    sqlParameterStock = new SqlParameter("@Stock", SqlDbType.Int);
                    sqlParameterStock.Value = producto.Stock;

                    
                    sqlCommand.Parameters.Add(sqlParameterNombre);
                    sqlCommand.Parameters.Add(sqlParameterPrecio);
                    sqlCommand.Parameters.Add(sqlParameterStock);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Registro del producto satisfatoriamente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

