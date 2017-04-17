using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DigitacionUnica : UserControl
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;

        public DigitacionUnica()
        {
            InitializeComponent();
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();

            nombreTb.CharacterCasing = CharacterCasing.Upper;
            apellidosTb.CharacterCasing = CharacterCasing.Upper;
            rneTb.MaxLength = 13;
           
           // seccionTb.CharacterCasing = CharacterCasing.Upper;
            rneTb.CharacterCasing = CharacterCasing.Upper;
        }

       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string l = numeroTb.Text;
            int num = Convert.ToInt32(l);

            ImpresionSabana com = new ImpresionSabana();
            OperacionesCertificados op = new OperacionesCertificados();
            if (nombreTb.Text == "" || apellidosTb.Text == "" || rneTb.Text == "" /*|| ConvocatoriaComboBox.Text == ""*/ || numeroTb.Text == ""// || seccionTb.Text == "" || anioAcaTb.Text == ""
                )
                MessageBox.Show("Debes llenar todos los campos para continuar");
            else if (num < 1 || num > 40)
            {
                    MessageBox.Show("El número debe estar entre 1 y 40", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //else if (op.numeroOcupadoEnSeccion(numeroTb.Text, seccionTb.Text, ConvocatoriaComboBox.Text) == false)
            //    MessageBox.Show("El número que ha digitado corresponde a otro estudiante.\nRevise e intente de nuevo", "Error en número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (com.formatoAnio("") == false)
                MessageBox.Show("El año escolar introducido no es correcto", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else {
                OperacionesCertificados nuevo = new OperacionesCertificados();

                if (nuevo.comprobarRedundancia(rneTb.Text) == 0)
                {
                    //int i = nuevo.insertarCertficado(rneTb.Text,
                    //                nombreTb.Text,
                    //                apellidosTb.Text,
                    //                numeroTb.Text,
                    //                seccionTb.Text,
                    //                anioAcaTb.Text,
                    //                ConvocatoriaComboBox.Text
                             //);
                    MessageBox.Show("Estudiante agregado", "Insercción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    borrarCampos();
                    if (printChk.Checked == true //&& i == 1
                        )
                    {
                        Printing p = new Printing();
                        p.progress.Maximum = 1;
                        p.progress.Value = 1;
                        p.all.Text = "1";
                        p.current.Text = "1";
                        p.Show();
                        WordDocument doc = new WordDocument();
                        //doc.generarDocumento(nombreTb.Text, seccionTb.Text, numeroTb.Text, anioAcaTb.Text, ConvocatoriaComboBox.Text, rneTb.Text);

                        p.Hide();

                    }
                    else
                        MessageBox.Show("Este estudiante ya se encuentra digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        public void borrarCampos() {
            nombreTb.Text = "";
            apellidosTb.Text = "";
            rneTb.Text = "";
            

        }
        private void numeroTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombreTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) )
            {
                MessageBox.Show("No se permite caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            borrarCampos();
            this.SendToBack();
            this.Visible = false;
        }

        private void DigitacionUnica_Load(object sender, EventArgs e)
        {
            nombreTb.Focus();
        }

        private void seccionTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("No se permite caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ElegirSabana choser = new ElegirSabana();
            choser.Show();
        }
    }
}
