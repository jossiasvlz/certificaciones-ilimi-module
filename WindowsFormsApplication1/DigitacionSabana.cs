using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DigitacionSabana : UserControl
    {
        public string seccion, anioAca, convocatoria, codigoSabana;
        
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;

        public DigitacionSabana()
        {
            InitializeComponent();
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();
            
            nombreTb.CharacterCasing = CharacterCasing.Upper;
            apellidosTb.CharacterCasing = CharacterCasing.Upper;
            rneTb.MaxLength = 13;
            rneTb.CharacterCasing = CharacterCasing.Upper;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            firstPanel.Visible = false;
        }

        private void bunifuCustomTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ImpresionSabana com = new ImpresionSabana();
            
            //if (com.formatoAnio() == false)
            //{
            //    MessageBox.Show("El año escolar introducido no es correcto", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    firstPanel.SendToBack();
            //    firstPanel.Visible = false;
            //    //seccion = seccionTb.Text;
            //    //anioAca = anioAcaTb.Text;
            //    //convocatoria = convocatoriaTb.Text;


            //    workPanel.BringToFront();
            //    workPanel.Visible = true;
            //    nombreTb.Focus();
              


            //}


        }

        public void borrarCampos()
        {
            nombreTb.Text = "";
            apellidosTb.Text = "";
            rneTb.Text = "";
            numeroTb.Text = "";
            nombreTb.Focus();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DigitacionSabana_Load(object sender, EventArgs e)
        {
            sabanaCod.Focus();

        }

        private void nombreTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nombreTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                apellidosTb.Focus();
                e.Handled = true;
                return;
            }
        }

        private void apellidosTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (apellidosTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                rneTb.Focus();
                e.Handled = true;
                return;

            }
        }

        private void rneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rneTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                numeroTb.Focus();
                e.Handled = true;
                return;
            }
        }

        private void apellidosTb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (apellidosTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                rneTb.Focus();
                e.Handled = true;
                return;
            }  
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            if (nombreTb.Text == "" || apellidosTb.Text == "" || rneTb.Text == "")
            {
                DialogResult result = MessageBox.Show("¿Desea salir realmente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string word = result.ToString(); ;
                if (word == "Yes")
                {

                    workPanel.Visible = false;
                    workPanel.SendToBack();
                    firstPanel.Visible = true;
                    firstPanel.BringToFront();
                }
            }
            else
            {
                workPanel.Visible = false;
                workPanel.SendToBack();
            }
                
            
        }

        private bool buscarSabana() {
            try
            {
                conexion.Open();
                comando = new SqlCommand("Select idSabana from Sabanas where idSabana = '" + sabanaCod.Text + "'",conexion);
                dataReader = comando.ExecuteReader();
                codigoSabana = dataReader["idSabana"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            if (codigoSabana != "")
                return true;
            else
                return false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            Thread.Sleep(500);
            if (sabanaCod.Text != "")
            {
                if (buscarSabana())
                {
                    workPanel.Visible = true;
                    workPanel.BringToFront();
                    firstPanel.Visible = false;
                    firstPanel.SendToBack();
                    codigoSabana = sabanaCod.Text;
                    codigoSabana = codigoSabana.ToUpper();
                }
                else
                    MessageBox.Show("Sábana no encontrada.\nSi posee la sábana físicaProceda a agregarla");
            }
            else
            {
                MessageBox.Show("Escribe el codigo de la sabana para continuar");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ElegirSabana choos = new ElegirSabana();
            choos.Show();
           
        }

        private void seccionTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("No se permite caracteres alfabeticos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            
        }




        private void numeroTb_KeyPress(object sender, KeyPressEventArgs e)
        {

            //OperacionesCertificados nuevo = new OperacionesCertificados();
            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            //{
            //    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;

            //}
            //if (numeroTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            //{
               

            //    if ((rneTb.Text == "" || nombreTb.Text == "" || apellidosTb.Text == ""))
            //        MessageBox.Show("Completa todos los campos para continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    else if (nuevo.numeroOcupadoEnSeccion(numeroTb.Text, seccion, convocatoria) == false)
            //        MessageBox.Show("El número que ha digitado corresponde a otro estudiante.\nRevise e intente de nuevo", "Error en número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    else if (nuevo.comprobarRedundancia(rneTb.Text) == 0)
            //    {
            //        int numValid = Convert.ToInt32(numeroTb.Text);
            //        if (numValid < 1 || numValid > 45)
            //            MessageBox.Show("El número debe estar entre 1 y 45", "Error en el número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //        else
            //        {
            //            nuevo.insertarCertficado(rneTb.Text,
            //                       nombreTb.Text,
            //                       apellidosTb.Text,
            //                       numeroTb.Text,
            //                       "2"
            //                );
            //            borrarCampos();
            //        }

            //    }

            //    else
            //    {
            //        MessageBox.Show("Este estudiante ya se encuentra digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        borrarCampos();
            //    }

            //     e.Handled = true;
            //    return;

            //}


        }
    }
}
