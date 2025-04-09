using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryGuadalupeLunaGestionInventario
{
    public class clsConexionBD
    {
        public string cadena = $"Provider=Microsoft.ACE.OLEDB.12.0.;Data Source=./Inventario.accdb";
        public string tabla = "Inventario";

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adaptador = new OleDbDataAdapter();
        public void listarInventario(DataGridView dgv)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader dr = comando.ExecuteReader();
                dgv.Rows.Clear();
                while (dr.Read())
                {
                    dgv.Rows.Add(
                    dr["Código"].ToString(),
                    dr["Nombre"].ToString(),
                    dr["Descripción"].ToString(),
                    Convert.ToDecimal(dr["Precio"]),
                    Convert.ToInt32(dr["Stock"])
                    );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally{ }
        }

    }



}
