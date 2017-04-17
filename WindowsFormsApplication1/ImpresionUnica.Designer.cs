namespace WindowsFormsApplication1
{
    partial class ImpresionUnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionUnica));
            this.label2 = new System.Windows.Forms.Label();
            this.rneTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.estudentFound = new System.Windows.Forms.Label();
            this.editBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.printBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(292, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rne:";
            // 
            // rneTb
            // 
            this.rneTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rneTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rneTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.rneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rneTb.ForeColor = System.Drawing.Color.Tomato;
            this.rneTb.Location = new System.Drawing.Point(348, 81);
            this.rneTb.Name = "rneTb";
            this.rneTb.Size = new System.Drawing.Size(291, 29);
            this.rneTb.TabIndex = 11;
            this.rneTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rneTb_KeyPress);
            // 
            // estudentFound
            // 
            this.estudentFound.AutoSize = true;
            this.estudentFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudentFound.ForeColor = System.Drawing.Color.Tomato;
            this.estudentFound.Location = new System.Drawing.Point(363, 222);
            this.estudentFound.Name = "estudentFound";
            this.estudentFound.Size = new System.Drawing.Size(0, 29);
            this.estudentFound.TabIndex = 13;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Image = global::WindowsFormsApplication1.Properties.Resources.Edit_Property_96px;
            this.editBtn.ImageActive = null;
            this.editBtn.Location = new System.Drawing.Point(517, 269);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(56, 55);
            this.editBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editBtn.TabIndex = 14;
            this.editBtn.TabStop = false;
            this.editBtn.Visible = false;
            this.editBtn.Zoom = 50;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Transparent;
            this.printBtn.Image = global::WindowsFormsApplication1.Properties.Resources.Print_96px;
            this.printBtn.ImageActive = null;
            this.printBtn.Location = new System.Drawing.Point(429, 269);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(56, 55);
            this.printBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printBtn.TabIndex = 14;
            this.printBtn.TabStop = false;
            this.printBtn.Visible = false;
            this.printBtn.Zoom = 50;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "                     Buscar";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconZoom = 50D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(348, 116);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(291, 45);
            this.bunifuFlatButton6.TabIndex = 12;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // ImpresionUnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.estudentFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.rneTb);
            this.MaximumSize = new System.Drawing.Size(969, 474);
            this.MinimumSize = new System.Drawing.Size(969, 474);
            this.Name = "ImpresionUnica";
            this.Size = new System.Drawing.Size(969, 474);
            this.Load += new System.EventHandler(this.ImpresionUnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox rneTb;
        public System.Windows.Forms.Label estudentFound;
        public Bunifu.Framework.UI.BunifuImageButton printBtn;
        public Bunifu.Framework.UI.BunifuImageButton editBtn;
    }
}
