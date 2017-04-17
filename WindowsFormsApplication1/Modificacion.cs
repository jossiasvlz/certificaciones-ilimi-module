using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Modificacion : Form
    {
        private int ty;
        public Modificacion(int tipo)
        {
            InitializeComponent();
            nombreTb.CharacterCasing = CharacterCasing.Upper;
            apellidosTb.CharacterCasing = CharacterCasing.Upper;
            rneTb.MaxLength = 13;
            numeroTb.CharacterCasing = CharacterCasing.Upper;
            rneTb.CharacterCasing = CharacterCasing.Upper;
            rneBuscar.CharacterCasing = CharacterCasing.Upper;
            rneBuscar.MaxLength = 13;
            ty = tipo;

            if (tipo == 1) {
                rnePanel.Hide();
            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            if ((char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("No se permite caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void borrarCampos()
        {
            nombreTb.Text = "";
            apellidosTb.Text = "";
            rneTb.Text = "";
            numeroTb.Text = "";
            nombreTb.Focus();
           
            printChk.Checked = false;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string l = numeroTb.Text;
            int num = Convert.ToInt32(l);
            ImpresionSabana com = new ImpresionSabana();
            OperacionesCertificados op = new OperacionesCertificados();
            if (nombreTb.Text == "" || apellidosTb.Text == "" || rneTb.Text == ""// || ConvocatoriaComboBox.Text == "" 
                || numeroTb.Text == "" )//|| seccionTb.Text == "" || anioAcaTb.Text == "")
                MessageBox.Show("Debes llenar todos los campos para continuar");
            else if (num < 1 || num > 40)
                {
                   MessageBox.Show("El número debe estar entre 1 y 40", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //else if (op.numeroOcupadoEnSeccion(rneTb.Text, numeroTb.Text, seccionTb.Text, ConvocatoriaComboBox.Text) == false)
            //    MessageBox.Show("El número que ha digitado corresponde a otro estudiante.\nRevise e intente de nuevo", "Error en número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else if (com.formatoAnio("") == false)
            //{
            //    MessageBox.Show("El año escolar introducido no es correcto", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}


            else
            {
                OperacionesCertificados mod = new OperacionesCertificados();
                int i = mod.updateCertificado(rneTb.Text,
                                        nombreTb.Text,
                                        apellidosTb.Text,
                                        numeroTb.Text,
                                        idSabanaTb.Text
                                        );
               
                if (printChk.Checked == true && i == 1) {
                    Printing p = new Printing();
                    p.progress.Maximum = 1;
                    p.progress.Value = 1;
                    p.all.Text = "1";
                    p.current.Text = "1";
                    p.Show();
                    WordDocument doc = new WordDocument();
                   // doc.generarDocumento(nombreTb.Text, seccionTb.Text, numeroTb.Text, anioAcaTb.Text, ConvocatoriaComboBox.Text, rneTb.Text);

                    p.Visible = false; 

                    borrarCampos();
                }
            }
            
           

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            if (ty != 1)
                nombreTb.Focus();
            else
                rneBuscar.Focus();
        }

        public void call()
        {
            ImpresionUnica i = new ImpresionUnica();
            if (rneBuscar.Text.Length < 13)
                MessageBox.Show("Rne incompleto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                rneTb.Text.ToUpper();
                string estudiante = i.comprobarDatos(rneBuscar.Text);
                if (estudiante != "")
                {
                    rnePanel.Hide();
                    nombreTb.Text = i.currentNombre;
                    apellidosTb.Text = i.currentApell;
                    

                }
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            call();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ElegirSabana choser = new ElegirSabana();
            choser.Show();
        }
    }
}
