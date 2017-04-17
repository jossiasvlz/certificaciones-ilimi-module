namespace WindowsFormsApplication1
{
    partial class CustomSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomSearch));
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.seccRBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.rneRbt = new MaterialSkin.Controls.MaterialRadioButton();
            this.yearRbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.namerBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registrosDG = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.certificadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTrDataSet = new WindowsFormsApplication1.DBTrDataSet();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.certificadosTableAdapter = new WindowsFormsApplication1.DBTrDataSetTableAdapters.CertificadosTableAdapter();
            this.dBTrDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTrDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(155, 57);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(464, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // seccRBtn
            // 
            this.seccRBtn.AutoSize = true;
            this.seccRBtn.Depth = 0;
            this.seccRBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.seccRBtn.Location = new System.Drawing.Point(282, 92);
            this.seccRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.seccRBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.seccRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.seccRBtn.Name = "seccRBtn";
            this.seccRBtn.Ripple = true;
            this.seccRBtn.Size = new System.Drawing.Size(78, 30);
            this.seccRBtn.TabIndex = 1;
            this.seccRBtn.TabStop = true;
            this.seccRBtn.Text = "Sección";
            this.seccRBtn.UseVisualStyleBackColor = true;
            // 
            // rneRbt
            // 
            this.rneRbt.AutoSize = true;
            this.rneRbt.Depth = 0;
            this.rneRbt.Font = new System.Drawing.Font("Roboto", 10F);
            this.rneRbt.Location = new System.Drawing.Point(404, 92);
            this.rneRbt.Margin = new System.Windows.Forms.Padding(0);
            this.rneRbt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rneRbt.MouseState = MaterialSkin.MouseState.HOVER;
            this.rneRbt.Name = "rneRbt";
            this.rneRbt.Ripple = true;
            this.rneRbt.Size = new System.Drawing.Size(53, 30);
            this.rneRbt.TabIndex = 1;
            this.rneRbt.TabStop = true;
            this.rneRbt.Text = "Rne";
            this.rneRbt.UseVisualStyleBackColor = true;
            // 
            // yearRbtn
            // 
            this.yearRbtn.AutoSize = true;
            this.yearRbtn.Depth = 0;
            this.yearRbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.yearRbtn.Location = new System.Drawing.Point(517, 92);
            this.yearRbtn.Margin = new System.Windows.Forms.Padding(0);
            this.yearRbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.yearRbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearRbtn.Name = "yearRbtn";
            this.yearRbtn.Ripple = true;
            this.yearRbtn.Size = new System.Drawing.Size(102, 30);
            this.yearRbtn.TabIndex = 1;
            this.yearRbtn.TabStop = true;
            this.yearRbtn.Text = "Año escolar";
            this.yearRbtn.UseVisualStyleBackColor = true;
            // 
            // namerBtn
            // 
            this.namerBtn.AutoSize = true;
            this.namerBtn.Depth = 0;
            this.namerBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.namerBtn.Location = new System.Drawing.Point(155, 92);
            this.namerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.namerBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.namerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.namerBtn.Name = "namerBtn";
            this.namerBtn.Ripple = true;
            this.namerBtn.Size = new System.Drawing.Size(78, 30);
            this.namerBtn.TabIndex = 1;
            this.namerBtn.TabStop = true;
            this.namerBtn.Text = "Nombre";
            this.namerBtn.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 127);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(936, 469);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.registrosDG);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage1.Controls.Add(this.seccRBtn);
            this.tabPage1.Controls.Add(this.yearRbtn);
            this.tabPage1.Controls.Add(this.namerBtn);
            this.tabPage1.Controls.Add(this.rneRbt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Única";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // registrosDG
            // 
            this.registrosDG.AllowUserToResizeColumns = false;
            this.registrosDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrosDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.registrosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrosDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.print});
            this.registrosDG.Location = new System.Drawing.Point(26, 157);
            this.registrosDG.Name = "registrosDG";
            this.registrosDG.Size = new System.Drawing.Size(886, 150);
            this.registrosDG.TabIndex = 5;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(634, 44);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(185, 36);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Buscar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(343, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Filtrar datos";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sección";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // certificadosBindingSource
            // 
            this.certificadosBindingSource.DataMember = "Certificados";
            this.certificadosBindingSource.DataSource = this.dBTrDataSet;
            // 
            // dBTrDataSet
            // 
            this.dBTrDataSet.DataSetName = "DBTrDataSet";
            this.dBTrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 98);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(933, 23);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // certificadosTableAdapter
            // 
            this.certificadosTableAdapter.ClearBeforeFill = true;
            // 
            // dBTrDataSetBindingSource
            // 
            this.dBTrDataSetBindingSource.DataSource = this.dBTrDataSet;
            this.dBTrDataSetBindingSource.Position = 0;
            // 
            // print
            // 
            this.print.HeaderText = "Imprimir";
            this.print.Name = "print";
            this.print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.print.Width = 60;
            // 
            // edit
            // 
            this.edit.HeaderText = "Editar";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 50;
            // 
            // CustomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(960, 608);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 200);
            this.Name = "CustomSearch";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los registros";
            this.Load += new System.EventHandler(this.CustomSearch_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTrDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRadioButton seccRBtn;
        private MaterialSkin.Controls.MaterialRadioButton rneRbt;
        private MaterialSkin.Controls.MaterialRadioButton yearRbtn;
        private MaterialSkin.Controls.MaterialRadioButton namerBtn;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridView registrosDG;
        private DBTrDataSet dBTrDataSet;
        private System.Windows.Forms.BindingSource certificadosBindingSource;
        private DBTrDataSetTableAdapters.CertificadosTableAdapter certificadosTableAdapter;
        private System.Windows.Forms.BindingSource dBTrDataSetBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn print;
    }
}