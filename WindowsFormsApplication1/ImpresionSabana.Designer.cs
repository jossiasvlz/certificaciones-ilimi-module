namespace WindowsFormsApplication1
{
    partial class ImpresionSabana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionSabana));
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.sdsadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoSabana = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "                    Imprimir";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconZoom = 50D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(333, 154);
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
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdsadToolStripMenuItem,
            this.asdToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // sdsadToolStripMenuItem
            // 
            this.sdsadToolStripMenuItem.Name = "sdsadToolStripMenuItem";
            this.sdsadToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sdsadToolStripMenuItem.Text = "sdsad";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdasdToolStripMenuItem});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // sdasdToolStripMenuItem
            // 
            this.sdasdToolStripMenuItem.Name = "sdasdToolStripMenuItem";
            this.sdasdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sdasdToolStripMenuItem.Text = "sdasd";
            // 
            // codigoSabana
            // 
            this.codigoSabana.Depth = 0;
            this.codigoSabana.Hint = "";
            this.codigoSabana.Location = new System.Drawing.Point(333, 109);
            this.codigoSabana.MouseState = MaterialSkin.MouseState.HOVER;
            this.codigoSabana.Name = "codigoSabana";
            this.codigoSabana.PasswordChar = '\0';
            this.codigoSabana.SelectedText = "";
            this.codigoSabana.SelectionLength = 0;
            this.codigoSabana.SelectionStart = 0;
            this.codigoSabana.Size = new System.Drawing.Size(291, 23);
            this.codigoSabana.TabIndex = 17;
            this.codigoSabana.Text = "Código de la sábana";
            this.codigoSabana.UseSystemPasswordChar = false;
            this.codigoSabana.Click += new System.EventHandler(this.codigoSabana_Click);
            // 
            // ImpresionSabana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codigoSabana);
            this.Controls.Add(this.bunifuFlatButton6);
            this.MaximumSize = new System.Drawing.Size(969, 474);
            this.MinimumSize = new System.Drawing.Size(969, 474);
            this.Name = "ImpresionSabana";
            this.Size = new System.Drawing.Size(969, 474);
            this.Load += new System.EventHandler(this.ImpresionSabana_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdsadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdasdToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField codigoSabana;
    }
}
