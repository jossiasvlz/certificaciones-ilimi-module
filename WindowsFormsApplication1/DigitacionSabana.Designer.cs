namespace WindowsFormsApplication1
{
    partial class DigitacionSabana
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
            this.workPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numeroTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.rneTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.apellidosTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nombreTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sabanaCod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.workPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.firstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.workPanel.Controls.Add(this.label8);
            this.workPanel.Controls.Add(this.label9);
            this.workPanel.Controls.Add(this.label10);
            this.workPanel.Controls.Add(this.label11);
            this.workPanel.Controls.Add(this.numeroTb);
            this.workPanel.Controls.Add(this.rneTb);
            this.workPanel.Controls.Add(this.apellidosTb);
            this.workPanel.Controls.Add(this.nombreTb);
            this.workPanel.Controls.Add(this.flowLayoutPanel2);
            this.workPanel.Location = new System.Drawing.Point(15, 105);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(951, 170);
            this.workPanel.TabIndex = 10;
            this.workPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(669, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Número de orden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(509, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Rne";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(315, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Apellidos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(124, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Nombres";
            // 
            // numeroTb
            // 
            this.numeroTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.numeroTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numeroTb.ForeColor = System.Drawing.Color.Tomato;
            this.numeroTb.Location = new System.Drawing.Point(671, 93);
            this.numeroTb.Name = "numeroTb";
            this.numeroTb.Size = new System.Drawing.Size(111, 23);
            this.numeroTb.TabIndex = 6;
            this.numeroTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTb_KeyPress);
            // 
            // rneTb
            // 
            this.rneTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.rneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rneTb.ForeColor = System.Drawing.Color.Tomato;
            this.rneTb.Location = new System.Drawing.Point(511, 93);
            this.rneTb.Name = "rneTb";
            this.rneTb.Size = new System.Drawing.Size(137, 23);
            this.rneTb.TabIndex = 5;
            this.rneTb.TabStop = false;
            this.rneTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rneTb_KeyPress);
            // 
            // apellidosTb
            // 
            this.apellidosTb.AutoCompleteCustomSource.AddRange(new string[] {
            "JOSSIAS",
            "JOSSE",
            "JOSASS"});
            this.apellidosTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.apellidosTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.apellidosTb.ForeColor = System.Drawing.Color.Tomato;
            this.apellidosTb.Location = new System.Drawing.Point(318, 93);
            this.apellidosTb.Name = "apellidosTb";
            this.apellidosTb.Size = new System.Drawing.Size(173, 23);
            this.apellidosTb.TabIndex = 4;
            this.apellidosTb.TabStop = false;
            this.apellidosTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidosTb_KeyPress_1);
            // 
            // nombreTb
            // 
            this.nombreTb.AutoCompleteCustomSource.AddRange(new string[] {
            "JOSSIAS",
            "JOSSE",
            "JOSASS"});
            this.nombreTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.nombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreTb.ForeColor = System.Drawing.Color.Tomato;
            this.nombreTb.Location = new System.Drawing.Point(124, 93);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(173, 23);
            this.nombreTb.TabIndex = 3;
            this.nombreTb.TabStop = false;
            this.nombreTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTb_KeyPress);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Tomato;
            this.flowLayoutPanel2.Controls.Add(this.bunifuImageButton2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(951, 27);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApplication1.Properties.Resources.cerrar;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 21);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(340, 32);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 31;
            this.materialRaisedButton1.Text = "Elegir";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // sabanaCod
            // 
            this.sabanaCod.Depth = 0;
            this.sabanaCod.Hint = "";
            this.sabanaCod.Location = new System.Drawing.Point(173, 32);
            this.sabanaCod.MouseState = MaterialSkin.MouseState.HOVER;
            this.sabanaCod.Name = "sabanaCod";
            this.sabanaCod.PasswordChar = '\0';
            this.sabanaCod.SelectedText = "";
            this.sabanaCod.SelectionLength = 0;
            this.sabanaCod.SelectionStart = 0;
            this.sabanaCod.Size = new System.Drawing.Size(156, 23);
            this.sabanaCod.TabIndex = 30;
            this.sabanaCod.UseSystemPasswordChar = false;
            this.sabanaCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seccionTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Código de sábana";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(212, 64);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton1.TabIndex = 32;
            this.materialFlatButton1.Text = "Siguiente";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // firstPanel
            // 
            this.firstPanel.Controls.Add(this.materialFlatButton1);
            this.firstPanel.Controls.Add(this.label4);
            this.firstPanel.Controls.Add(this.materialRaisedButton1);
            this.firstPanel.Controls.Add(this.sabanaCod);
            this.firstPanel.Location = new System.Drawing.Point(248, 27);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(468, 109);
            this.firstPanel.TabIndex = 33;
            // 
            // DigitacionSabana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firstPanel);
            this.Controls.Add(this.workPanel);
            this.MaximumSize = new System.Drawing.Size(969, 474);
            this.MinimumSize = new System.Drawing.Size(969, 474);
            this.Name = "DigitacionSabana";
            this.Size = new System.Drawing.Size(969, 474);
            this.Load += new System.EventHandler(this.DigitacionSabana_Load);
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox numeroTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox rneTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nombreTb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox apellidosTb;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField sabanaCod;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        public System.Windows.Forms.Panel firstPanel;
    }
}
