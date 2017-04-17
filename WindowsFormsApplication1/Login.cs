using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Login : MaterialForm
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        DataSet datos;
        
       

        public Login()
        {
            InitializeComponent();
            Console.WriteLine(Application.StartupPath);
            datos = new DataSet();
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();
        }


       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          
            
        }

        public void login() {
            if (utb.Text == "" || ptb.Text == "")
                MessageBox.Show("Debe escribir un usuario y contrasena");
            else
            {
                if (comprobarDatos(utb.Text, ptb.Text))
                {
                    this.Hide();
                    Printing p = new Printing();
                    p.Show();
                    p.panelPrintState.Visible = false;
                    p.starting.Visible = true;
                    p.Refresh();
                    p.progress.Maximum = 3;
                    p.progress.Value = 0;


                    p.logo.Hide();
                    Thread.Sleep(600);
                    p.logo.Show();

                    p.Refresh();
                    p.progress.Value = 1;
                    Thread.Sleep(600);
                    p.logo.Hide();

                    p.Refresh();
                    p.progress.Value = 2;
                    Thread.Sleep(600);
                    p.logo.Show();
                    p.Refresh();
                    p.progress.Value = 3;
                    Thread.Sleep(600);
                    p.Refresh();

                    //this.Hide();
                    //p.Show();
                    //Thread.Sleep(3000);

                    
                    p.Hide();
                    
                    Inicio uiApplication = new Inicio(utb.Text);
                    uiApplication.Show();
                    


                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    
                }
            }
        }
       
        public bool comprobarDatos(string usuario, string pass)
        {
            string password = string.Empty;
            string user = string.Empty;
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT * FROM Usuarios where usuario='" + usuario + "' and contrasena ='"+ pass +"' ", conexion);
                dataReader = comando.ExecuteReader();
            }

            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            if (dataReader.Read() == true)
            {

                user = Convert.ToString(dataReader["usuario"]);
                password = Convert.ToString(dataReader["contrasena"]);
                Console.WriteLine(user);
                Console.WriteLine(pass);

            }

            dataReader.Close();
            conexion.Close();

            if (usuario == user && pass == password)
                return true;
            else 
                return false;
            
                
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            utb.Focus();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void utb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (utb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
               
                SendKeys.Send("{TAB}");
                e.Handled = true;
                return;
            }
        }

        private void ptb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ptb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                login();
                e.Handled = true;
                return;
            }
        }

        private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nameTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                return;
            }

        }

        private void userNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (userNameTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                return;
            }
        }

        private void passTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (passTb.Text != "" && (e.KeyChar == (char)Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                return;
            }
        }
    }
}
