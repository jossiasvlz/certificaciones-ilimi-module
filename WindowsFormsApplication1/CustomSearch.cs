using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CustomSearch : MaterialForm 
    {

        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        SqlDataAdapter adap;
        DataBase db;
        DataSet dataset;
        DataTable tabla;

        public CustomSearch()
        {
            InitializeComponent();
            


            db = new DataBase();
            
            conexion = db.obtenerConexion();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void poblarDataGrid(DataGridView datagrid) {
            try
            {
                conexion.Open();
                adap = new SqlDataAdapter("Select rne, nombres, apellidos, numeroOrden, Sabanas.seccion as seccion, Sabanas.convocatoria as convocatoria, Sabanas.añoAcademico as añoAcademico FROM Certificados JOIN Sabanas ON Certificados.idSabana = Sabanas.idSabana", conexion);
                tabla = new DataTable();
                adap.Fill(tabla);
                datagrid.DataSource = tabla;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexion.Close();
            }
            
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                if (namerBtn.Checked == true)
                {
                    MessageBox.Show("SSA");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conexion.Close();

            }
        }

        private void CustomSearch_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBTrDataSet.Certificados' Puede moverla o quitarla según sea necesario.

            poblarDataGrid(registrosDG);
            
           
        }
    }
}
