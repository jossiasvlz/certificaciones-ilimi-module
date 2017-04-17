namespace WindowsFormsApplication1
{
    partial class DigitacionUnica
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitacionUnica));
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.apellidosTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rneTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.printChk = new MaterialSkin.Controls.MaterialCheckBox();
            this.idSabana = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(83, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombres";
            // 
            // nombreTb
            // 
            this.nombreTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.nombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTb.ForeColor = System.Drawing.Color.Tomato;
            this.nombreTb.Location = new System.Drawing.Point(87, 115);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(291, 29);
            this.nombreTb.TabIndex = 0;
            this.nombreTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTb_KeyPress);
            // 
            // apellidosTb
            // 
            this.apellidosTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.apellidosTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTb.ForeColor = System.Drawing.Color.Tomato;
            this.apellidosTb.Location = new System.Drawing.Point(87, 187);
            this.apellidosTb.Name = "apellidosTb";
            this.apellidosTb.Size = new System.Drawing.Size(291, 29);
            this.apellidosTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(83, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(431, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rne";
            // 
            // rneTb
            // 
            this.rneTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.rneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rneTb.ForeColor = System.Drawing.Color.Tomato;
            this.rneTb.Location = new System.Drawing.Point(435, 115);
            this.rneTb.Name = "rneTb";
            this.rneTb.Size = new System.Drawing.Size(163, 29);
            this.rneTb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(431, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número de orden";
            // 
            // printChk
            // 
            this.printChk.AutoSize = true;
            this.printChk.Depth = 0;
            this.printChk.Font = new System.Drawing.Font("Roboto", 10F);
            this.printChk.Location = new System.Drawing.Point(705, 186);
            this.printChk.Margin = new System.Windows.Forms.Padding(0);
            this.printChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.printChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.printChk.Name = "printChk";
            this.printChk.Ripple = true;
            this.printChk.Size = new System.Drawing.Size(82, 30);
            this.printChk.TabIndex = 7;
            this.printChk.Text = "Imprimir ";
            this.printChk.UseVisualStyleBackColor = true;
            // 
            // idSabana
            // 
            this.idSabana.BackColor = System.Drawing.SystemColors.Window;
            this.idSabana.Depth = 0;
            this.idSabana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.idSabana.Hint = "";
            this.idSabana.Location = new System.Drawing.Point(624, 121);
            this.idSabana.MouseState = MaterialSkin.MouseState.HOVER;
            this.idSabana.Name = "idSabana";
            this.idSabana.PasswordChar = '\0';
            this.idSabana.SelectedText = "";
            this.idSabana.SelectionLength = 0;
            this.idSabana.SelectionStart = 0;
            this.idSabana.Size = new System.Drawing.Size(163, 23);
            this.idSabana.TabIndex = 5;
            this.idSabana.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(621, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Código de sábana";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(807, 121);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Elegir";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "                      Cancelar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = global::WindowsFormsApplication1.Properties.Resources.cerrar;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(471, 343);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Snow;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(301, 45);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "                       Guardar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(153, 343);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 45);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(621, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "(Rne del primer estudiante en la sábana física)";
            // 
            // numeroTb
            // 
            this.numeroTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.numeroTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTb.ForeColor = System.Drawing.Color.Tomato;
            this.numeroTb.Location = new System.Drawing.Point(435, 187);
            this.numeroTb.Name = "numeroTb";
            this.numeroTb.Size = new System.Drawing.Size(163, 29);
            this.numeroTb.TabIndex = 4;
            this.numeroTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTb_KeyPress);
            // 
            // DigitacionUnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.idSabana);
            this.Controls.Add(this.printChk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroTb);
            this.Controls.Add(this.rneTb);
            this.Controls.Add(this.apellidosTb);
            this.Controls.Add(this.nombreTb);
            this.MaximumSize = new System.Drawing.Size(969, 474);
            this.MinimumSize = new System.Drawing.Size(969, 474);
            this.Name = "DigitacionUnica";
            this.Size = new System.Drawing.Size(969, 474);
            this.Load += new System.EventHandler(this.DigitacionUnica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox nombreTb;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox apellidosTb;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label3;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox rneTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private MaterialSkin.Controls.MaterialCheckBox printChk;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public MaterialSkin.Controls.MaterialSingleLineTextField idSabana;
        private System.Windows.Forms.Label label5;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox numeroTb;
    }
}
