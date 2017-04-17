namespace WindowsFormsApplication1
{
    partial class ElegirSabana
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.anioTb1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.seccTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.convocatoriaComb1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageContainer = new System.Windows.Forms.PictureBox();
            this.anioTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.codSab = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.seccionTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConvocatoriaComboBox = new System.Windows.Forms.ComboBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(16, 110);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(887, 482);
            this.materialTabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.anioTb1);
            this.tabPage1.Controls.Add(this.seccTb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.convocatoriaComb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Existente";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(162, 134);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(417, 46);
            this.materialRaisedButton2.TabIndex = 55;
            this.materialRaisedButton2.Text = "Buscar sábana";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // anioTb1
            // 
            this.anioTb1.Depth = 0;
            this.anioTb1.Hint = "";
            this.anioTb1.Location = new System.Drawing.Point(281, 84);
            this.anioTb1.MouseState = MaterialSkin.MouseState.HOVER;
            this.anioTb1.Name = "anioTb1";
            this.anioTb1.PasswordChar = '\0';
            this.anioTb1.SelectedText = "";
            this.anioTb1.SelectionLength = 0;
            this.anioTb1.SelectionStart = 0;
            this.anioTb1.Size = new System.Drawing.Size(96, 23);
            this.anioTb1.TabIndex = 53;
            this.anioTb1.UseSystemPasswordChar = false;
            // 
            // seccTb
            // 
            this.seccTb.Depth = 0;
            this.seccTb.Hint = "";
            this.seccTb.Location = new System.Drawing.Point(162, 84);
            this.seccTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.seccTb.Name = "seccTb";
            this.seccTb.PasswordChar = '\0';
            this.seccTb.SelectedText = "";
            this.seccTb.SelectionLength = 0;
            this.seccTb.SelectionStart = 0;
            this.seccTb.Size = new System.Drawing.Size(96, 23);
            this.seccTb.TabIndex = 54;
            this.seccTb.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(159, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Sección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(409, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Convocatoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(278, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Año escolar";
            // 
            // convocatoriaComb1
            // 
            this.convocatoriaComb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.convocatoriaComb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.convocatoriaComb1.FormattingEnabled = true;
            this.convocatoriaComb1.Items.AddRange(new object[] {
            "GENERAL",
            "COMPLETIVA",
            "REPOSICION"});
            this.convocatoriaComb1.Location = new System.Drawing.Point(412, 84);
            this.convocatoriaComb1.Name = "convocatoriaComb1";
            this.convocatoriaComb1.Size = new System.Drawing.Size(167, 24);
            this.convocatoriaComb1.TabIndex = 49;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.imageContainer);
            this.tabPage2.Controls.Add(this.anioTb);
            this.tabPage2.Controls.Add(this.materialRaisedButton1);
            this.tabPage2.Controls.Add(this.codSab);
            this.tabPage2.Controls.Add(this.seccionTb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ConvocatoriaComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nueva";
            // 
            // imageContainer
            // 
            this.imageContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imageContainer.Image = global::WindowsFormsApplication1.Properties.Resources.IMG_20161109_WA0006;
            this.imageContainer.Location = new System.Drawing.Point(13, 111);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(852, 334);
            this.imageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageContainer.TabIndex = 49;
            this.imageContainer.TabStop = false;
            // 
            // anioTb
            // 
            this.anioTb.Depth = 0;
            this.anioTb.Hint = "";
            this.anioTb.Location = new System.Drawing.Point(530, 14);
            this.anioTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.anioTb.Name = "anioTb";
            this.anioTb.PasswordChar = '\0';
            this.anioTb.SelectedText = "";
            this.anioTb.SelectionLength = 0;
            this.anioTb.SelectionStart = 0;
            this.anioTb.Size = new System.Drawing.Size(96, 23);
            this.anioTb.TabIndex = 47;
            this.anioTb.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(13, 59);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(300, 36);
            this.materialRaisedButton1.TabIndex = 50;
            this.materialRaisedButton1.Text = "Escanear sábana";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // codSab
            // 
            this.codSab.Depth = 0;
            this.codSab.Hint = "";
            this.codSab.Location = new System.Drawing.Point(124, 13);
            this.codSab.MouseState = MaterialSkin.MouseState.HOVER;
            this.codSab.Name = "codSab";
            this.codSab.PasswordChar = '\0';
            this.codSab.SelectedText = "";
            this.codSab.SelectionLength = 0;
            this.codSab.SelectionStart = 0;
            this.codSab.Size = new System.Drawing.Size(135, 23);
            this.codSab.TabIndex = 48;
            this.codSab.UseSystemPasswordChar = false;
            // 
            // seccionTb
            // 
            this.seccionTb.Depth = 0;
            this.seccionTb.Hint = "";
            this.seccionTb.Location = new System.Drawing.Point(333, 13);
            this.seccionTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.seccionTb.Name = "seccionTb";
            this.seccionTb.PasswordChar = '\0';
            this.seccionTb.SelectedText = "";
            this.seccionTb.SelectionLength = 0;
            this.seccionTb.SelectionStart = 0;
            this.seccionTb.Size = new System.Drawing.Size(96, 23);
            this.seccionTb.TabIndex = 48;
            this.seccionTb.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Código sábana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(265, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Sección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(629, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Convocatoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(437, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Año escolar";
            // 
            // ConvocatoriaComboBox
            // 
            this.ConvocatoriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ConvocatoriaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ConvocatoriaComboBox.FormattingEnabled = true;
            this.ConvocatoriaComboBox.Items.AddRange(new object[] {
            "GENERAL",
            "COMPLETIVA",
            "REPOSICION"});
            this.ConvocatoriaComboBox.Location = new System.Drawing.Point(732, 18);
            this.ConvocatoriaComboBox.Name = "ConvocatoriaComboBox";
            this.ConvocatoriaComboBox.Size = new System.Drawing.Size(134, 24);
            this.ConvocatoriaComboBox.TabIndex = 43;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(16, 81);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(879, 23);
            this.materialTabSelector1.TabIndex = 36;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // ElegirSabana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 621);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "ElegirSabana";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElegirSabana";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField anioTb1;
        private MaterialSkin.Controls.MaterialSingleLineTextField seccTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox convocatoriaComb1;
        private System.Windows.Forms.PictureBox imageContainer;
        private MaterialSkin.Controls.MaterialSingleLineTextField anioTb;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField seccionTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox ConvocatoriaComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField codSab;
        private System.Windows.Forms.Label label4;
    }
}