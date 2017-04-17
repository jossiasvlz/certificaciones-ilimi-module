using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ElegirSabana : MaterialForm
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader dataReader;


        public ElegirSabana()
        {
            InitializeComponent();
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();



        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            if (seccionTb.Text == "" || anioTb.Text == "" || ConvocatoriaComboBox.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                MessageBox.Show("Working on this", "NICE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public string buscarSabana() {
            string idSabana = string.Empty;
            try
            {
                conexion.Open();
               // comando = new SqlCommand("SELECT idSabana FROM Sabanas where seccion = '" + seccionTb.Text + "' " +
                //                       "and añoAcademico = '" + anioTb.Text + "'and convocatoria = '" + ConvocatoriaComboBox.Text + "' ", conexion);
                comando = new SqlCommand("SELECT * FROM Sabanas where seccion = 'A' and añoAcademico = '2009-2010' and convocatoria = 'GENERAL';", conexion);
                dataReader = comando.ExecuteReader();
                idSabana = dataReader["idSabana"].ToString();
                MessageBox.Show(idSabana);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRROOOR: " + ex.Message);
            }
            finally {
                conexion.Close();
            }

            MessageBox.Show(idSabana);
            return idSabana;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (seccTb.Text == "" || anioTb1.Text == "" || convocatoriaComb1.Text == "")
            {
                MessageBox.Show("Debes completar todos los campos");
            }
            else {
                DigitacionUnica p = new DigitacionUnica();
                p.idSabana.Text = buscarSabana();
               
            }
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

            //antes de todo configura un metodo que compruebe que la sabana no existe
            if (seccionTb.Text != "" && anioTb.Text != "" && ConvocatoriaComboBox.Text != "")
            {
                try
                {
                   // byte[] imgData = System.IO.File.ReadAllBytes(ruta);
                    
                    conexion.Open();
                    comando = new SqlCommand("Insert into Sabanas (codigoSabana, seccion, " +
                                              "convocatoria, añoAcademico, imagenSabana) values ('" +
                                              codSab.Text + "','" + seccionTb.Text.ToUpper() + "','" + ConvocatoriaComboBox.Text + "', '" + anioTb.Text +
                                              "', '" + null + "' );", conexion);
                    //Cuando tengas configurado el scann cambia el Img a su valor de imagen, esta null actualmente.
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Sábana agregada con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Complete todos los campos", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
