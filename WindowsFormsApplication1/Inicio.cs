using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        ImpresionUnica impresionUnica;
        DigitacionUnica digitacionUnica;
        ImpresionSabana impresionSabana;
        DigitacionSabana digitacionSabana;
        Modificacion modifificacion; //No es un Control de usuario; es un form
        public Inicio(string usuario)
        {
            InitializeComponent();
            UserLabl.Text =  usuario;
            //BORRAR MAS ADELANTE
            impresionUnica = new ImpresionUnica();
            digitacionUnica = new DigitacionUnica();
            impresionSabana = new ImpresionSabana();
            digitacionSabana = new DigitacionSabana();
            modifificacion = new Modificacion(0);
            //
            nombre.CharacterCasing = CharacterCasing.Upper;
            apellidos.CharacterCasing = CharacterCasing.Upper;
            rne.MaxLength = 13;

            // seccionTb.CharacterCasing = CharacterCasing.Upper;
            rne.CharacterCasing = CharacterCasing.Upper;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir realmente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string word = result.ToString(); ;


            Console.WriteLine(result);
            if (word == "Yes")
            {

                Application.Exit();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = tab1.Width;
            bunifuSeparator1.Left = tab1.Left;
            digitacionUnica.Show();
            digitacionUnica.Dock = DockStyle.None;
            digitacionUnica.Location = new Point(125, 0);
            panelContenedor.Controls.Add(digitacionUnica);

            digitacionSabana.Hide();
            impresionSabana.Hide();
            impresionUnica.Hide();
            modifificacion.Hide();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = tab2.Width;
            bunifuSeparator1.Left = tab2.Left;
            digitacionSabana.Show();
            digitacionSabana.seccion = "";
            digitacionSabana.anioAca = "";
            digitacionSabana.convocatoria = "";
            
            digitacionSabana.workPanel.Visible = false;
            digitacionSabana.firstPanel.Visible = true;
            digitacionSabana.Dock = DockStyle.None;
            digitacionSabana.Location = new Point(125, 0);
            panelContenedor.Controls.Add(digitacionSabana);
            impresionUnica.Hide();
            digitacionUnica.Hide();
            impresionSabana.Hide();
            modifificacion.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = tab4.Width;
            bunifuSeparator1.Left = tab4.Left;
            impresionUnica.Show();
            impresionUnica.rneTb.Text = "";
            impresionUnica.estudentFound.Text = "";
            impresionUnica.printBtn.Visible = false;
            impresionUnica.editBtn.Visible = false;
            impresionUnica.Dock = DockStyle.None;
            impresionUnica.Location = new Point(125, 0);
            panelContenedor.Controls.Add(impresionUnica);

            digitacionSabana.Hide();
            digitacionUnica.Hide();
            impresionSabana.Hide();
            modifificacion.Hide();


        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = tab5.Width;
            bunifuSeparator1.Left = tab5.Left;
            impresionSabana.Show();
            impresionSabana.Dock = DockStyle.None;
            impresionSabana.Location = new Point(125, 0);
            panelContenedor.Controls.Add(impresionSabana);

            modifificacion.Hide();
            impresionUnica.Hide();
            digitacionUnica.Hide();
            digitacionSabana.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string word = result.ToString(); ;


            Console.WriteLine(result);
            if (word == "Yes") {

                Application.Restart();
            }
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = tab3.Width;
            bunifuSeparator1.Left = tab3.Left;
            modifificacion.rnePanel.BringToFront();
            modifificacion.rnePanel.Visible = true;
            modifificacion.Show();
            digitacionSabana.Hide();
            digitacionUnica.Hide();
            impresionSabana.Hide();
            impresionUnica.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Printing p = new Printing();
            p.Show();
        }
        
        private void logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("{SETTINGS } Working on this");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tab6_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = tab6.Width;
            bunifuSeparator1.Left = tab6.Left;
            CustomSearch search = new CustomSearch();
            search.Show();
        }


        public void borrarCampos()
        {
            nombre.Text = "";
            apellidos.Text = "";
            rne.Text = "";

        }

        private void nombreTb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("No se permite caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void numeroTb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ElegirSabana choser = new ElegirSabana();
            choser.Show();
        }

       

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            //ImpresionSabana com = new ImpresionSabana();

            OperacionesCertificados operacionesC = new OperacionesCertificados();

            string secc;
            string convo;
            string anio;
            object[] infoSabana;

            if (codigoSabana.Text != "") {
                //MessageBox.Show("LKSJLKSJ");
                infoSabana = operacionesC.consultarSabana(codigoSabanTb.Text);
                //secc       = infoSabana[0].ToString();
                //convo      = infoSabana[1].ToString();
                //anio       = infoSabana[2].ToString();
                //MessageBox.Show(infoSabana[0].ToString());
            }
            ////pictureBox1.Image = (Image)infoSabana[3];
            
           
           


            //if (nombre.Text == "" || apellidos.Text == "" || rne.Text == "" || idSabana.Text == "" || numero.Text == "")
            //    MessageBox.Show("Debes llenar todos los campos para continuar");
            //else
            //{
            //    string l = numero.Text;
            //    int num = Convert.ToInt32(l);
            //    if (num < 1 || num > 40)
            //    {
            //        MessageBox.Show("El número debe estar entre 1 y 40", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //    //else if (infoSabana != null)
            //    //{
            //    //    if (op.numeroOcupadoEnSeccion(numero.Text, idSabana.Text) == false)
            //    //    {
            //    //        MessageBox.Show("El número que ha digitado corresponde a otro estudiante.\nRevise e intente de nuevo",
            //    //            "Error en número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    //    }
            //    //    else if (com.formatoAnio(anio) == false)
            //    //    {
            //    //        MessageBox.Show("El año escolar introducido no es correcto",
            //    //            "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    //    }
            //    //}


            //    else
            //    {
            //        OperacionesCertificados nuevo = new OperacionesCertificados();

            //        if (nuevo.comprobarRedundancia(rne.Text) == 0)
            //        {
            //            int i = nuevo.insertarCertficado(rne.Text,
            //                            nombre.Text,
            //                            apellidos.Text,
            //                            numero.Text,
            //                            idSabana.Text
            //            );
            //            MessageBox.Show("Estudiante agregado", "Insercción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            borrarCampos();
            //            if (printChk.Checked == true && i == 1)
            //            {
            //                Printing p = new Printing();
            //                p.progress.Maximum = 1;
            //                p.progress.Value = 1;
            //                p.all.Text = "1";
            //                p.current.Text = "1";
            //                p.Show();
            //                WordDocument doc = new WordDocument();
            //                doc.generarDocumento(nombre.Text, secc, numero.Text, anio, convo, rne.Text);

            //                p.Hide();

            //            }
            //            else
            //                MessageBox.Show("Este estudiante ya se encuentra digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //        }

            //    }

            //}
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            borrarCampos();
        }
    }
}
