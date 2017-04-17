namespace WindowsFormsApplication1
{
    partial class Modificacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificacion));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.rneTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.apellidosTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nombreTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rneBuscar = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.rnePanel = new System.Windows.Forms.Panel();
            this.printChk = new MaterialSkin.Controls.MaterialCheckBox();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idSabanaTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.rnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(407, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Número de orden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(78, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(78, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(78, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombres";
            // 
            // numeroTb
            // 
            this.numeroTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.numeroTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTb.ForeColor = System.Drawing.Color.Tomato;
            this.numeroTb.Location = new System.Drawing.Point(411, 70);
            this.numeroTb.Name = "numeroTb";
            this.numeroTb.Size = new System.Drawing.Size(120, 29);
            this.numeroTb.TabIndex = 23;
            this.numeroTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTb_KeyPress);
            // 
            // rneTb
            // 
            this.rneTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.rneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rneTb.ForeColor = System.Drawing.Color.Tomato;
            this.rneTb.Location = new System.Drawing.Point(82, 214);
            this.rneTb.Name = "rneTb";
            this.rneTb.Size = new System.Drawing.Size(291, 29);
            this.rneTb.TabIndex = 21;
            // 
            // apellidosTb
            // 
            this.apellidosTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.apellidosTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTb.ForeColor = System.Drawing.Color.Tomato;
            this.apellidosTb.Location = new System.Drawing.Point(82, 142);
            this.apellidosTb.Name = "apellidosTb";
            this.apellidosTb.Size = new System.Drawing.Size(291, 29);
            this.apellidosTb.TabIndex = 20;
            this.apellidosTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTb_KeyPress);
            // 
            // nombreTb
            // 
            this.nombreTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.nombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTb.ForeColor = System.Drawing.Color.Tomato;
            this.nombreTb.Location = new System.Drawing.Point(82, 70);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(291, 29);
            this.nombreTb.TabIndex = 19;
            this.nombreTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTb_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 28);
            this.panel1.TabIndex = 35;
            // 
            // rneBuscar
            // 
            this.rneBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rneBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rneBuscar.BorderColor = System.Drawing.Color.SeaGreen;
            this.rneBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rneBuscar.ForeColor = System.Drawing.Color.Tomato;
            this.rneBuscar.Location = new System.Drawing.Point(172, 27);
            this.rneBuscar.Name = "rneBuscar";
            this.rneBuscar.Size = new System.Drawing.Size(291, 29);
            this.rneBuscar.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(116, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rne:";
            // 
            // rnePanel
            // 
            this.rnePanel.Controls.Add(this.label8);
            this.rnePanel.Controls.Add(this.bunifuFlatButton6);
            this.rnePanel.Controls.Add(this.rneBuscar);
            this.rnePanel.Location = new System.Drawing.Point(43, 343);
            this.rnePanel.Name = "rnePanel";
            this.rnePanel.Size = new System.Drawing.Size(615, 56);
            this.rnePanel.TabIndex = 36;
            // 
            // printChk
            // 
            this.printChk.AutoSize = true;
            this.printChk.Depth = 0;
            this.printChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.printChk.Location = new System.Drawing.Point(260, 276);
            this.printChk.Margin = new System.Windows.Forms.Padding(0);
            this.printChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.printChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.printChk.Name = "printChk";
            this.printChk.Ripple = true;
            this.printChk.Size = new System.Drawing.Size(82, 30);
            this.printChk.TabIndex = 37;
            this.printChk.Text = "Imprimir";
            this.printChk.UseVisualStyleBackColor = true;
            this.printChk.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "                     Editar";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconZoom = 50D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(172, 62);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(291, 45);
            this.bunifuFlatButton6.TabIndex = 15;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(749, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 36;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 30;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(400, 343);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Snow;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(301, 45);
            this.bunifuFlatButton2.TabIndex = 26;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
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
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(82, 343);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 45);
            this.bunifuFlatButton1.TabIndex = 27;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(542, 134);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 31);
            this.materialRaisedButton1.TabIndex = 40;
            this.materialRaisedButton1.Text = "Elegir";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // idSabanaTb
            // 
            this.idSabanaTb.Depth = 0;
            this.idSabanaTb.Hint = "";
            this.idSabanaTb.Location = new System.Drawing.Point(411, 142);
            this.idSabanaTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.idSabanaTb.Name = "idSabanaTb";
            this.idSabanaTb.PasswordChar = '\0';
            this.idSabanaTb.SelectedText = "";
            this.idSabanaTb.SelectionLength = 0;
            this.idSabanaTb.SelectionStart = 0;
            this.idSabanaTb.Size = new System.Drawing.Size(120, 23);
            this.idSabanaTb.TabIndex = 39;
            this.idSabanaTb.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(408, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Código de sábana";
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 416);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.idSabanaTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rnePanel);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.printChk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(290, 250);
            this.Name = "Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.panel1.ResumeLayout(false);
            this.rnePanel.ResumeLayout(false);
            this.rnePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox numeroTb;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox rneTb;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox apellidosTb;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox nombreTb;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox rneBuscar;
        public System.Windows.Forms.Panel rnePanel;
        private MaterialSkin.Controls.MaterialCheckBox printChk;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField idSabanaTb;
        private System.Windows.Forms.Label label5;
    }
}