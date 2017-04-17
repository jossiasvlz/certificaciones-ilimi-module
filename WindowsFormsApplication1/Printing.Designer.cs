namespace WindowsFormsApplication1
{
    partial class Printing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printing));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPrintState = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.current = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.all = new System.Windows.Forms.Label();
            this.progress = new CircularProgressBar.CircularProgressBar();
            this.logoAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.logo = new Bunifu.Framework.UI.BunifuImageButton();
            this.starting = new System.Windows.Forms.Label();
            this.panelPrintState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelPrintState
            // 
            this.panelPrintState.BackColor = System.Drawing.Color.Transparent;
            this.panelPrintState.Controls.Add(this.label8);
            this.panelPrintState.Controls.Add(this.label4);
            this.panelPrintState.Controls.Add(this.flowLayoutPanel1);
            this.panelPrintState.Controls.Add(this.current);
            this.panelPrintState.Controls.Add(this.label6);
            this.panelPrintState.Controls.Add(this.all);
            this.logoAnimator.SetDecoration(this.panelPrintState, BunifuAnimatorNS.DecorationType.None);
            this.panelPrintState.Location = new System.Drawing.Point(76, 194);
            this.panelPrintState.Name = "panelPrintState";
            this.panelPrintState.Size = new System.Drawing.Size(532, 78);
            this.panelPrintState.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(204, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Por favor espere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "Imprimiendo certificados";
            // 
            // flowLayoutPanel1
            // 
            this.logoAnimator.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(159, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.logoAnimator.SetDecoration(this.current, BunifuAnimatorNS.DecorationType.None);
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.current.ForeColor = System.Drawing.Color.Tomato;
            this.current.Location = new System.Drawing.Point(337, 21);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(49, 36);
            this.current.TabIndex = 20;
            this.current.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(386, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 36);
            this.label6.TabIndex = 20;
            this.label6.Text = "de";
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.logoAnimator.SetDecoration(this.all, BunifuAnimatorNS.DecorationType.None);
            this.all.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.all.ForeColor = System.Drawing.Color.Tomato;
            this.all.Location = new System.Drawing.Point(430, 21);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(49, 36);
            this.all.TabIndex = 20;
            this.all.Text = "00";
            // 
            // progress
            // 
            this.progress.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progress.AnimationFunction")));
            this.progress.AnimationSpeed = 500;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.progress, BunifuAnimatorNS.DecorationType.None);
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progress.InnerColor = System.Drawing.Color.Transparent;
            this.progress.InnerMargin = 2;
            this.progress.InnerWidth = -1;
            this.progress.Location = new System.Drawing.Point(249, 24);
            this.progress.MarqueeAnimationSpeed = 2000;
            this.progress.Maximum = 10;
            this.progress.Name = "progress";
            this.progress.OuterColor = System.Drawing.Color.Gray;
            this.progress.OuterMargin = -25;
            this.progress.OuterWidth = 25;
            this.progress.ProgressColor = System.Drawing.Color.Tomato;
            this.progress.ProgressWidth = 5;
            this.progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress.Size = new System.Drawing.Size(166, 164);
            this.progress.StartAngle = 270;
            this.progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress.SubscriptText = ".23";
            this.progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress.SuperscriptText = "";
            this.progress.TabIndex = 24;
            this.progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.logoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.logoAnimator.DefaultAnimation = animation2;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::WindowsFormsApplication1.Properties.Resources.DOT_96px;
            this.logo.ImageActive = null;
            this.logo.Location = new System.Drawing.Point(297, 82);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            this.logo.Zoom = 10;
            // 
            // starting
            // 
            this.starting.AutoSize = true;
            this.starting.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.starting, BunifuAnimatorNS.DecorationType.None);
            this.starting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.starting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.starting.Location = new System.Drawing.Point(293, 138);
            this.starting.Name = "starting";
            this.starting.Size = new System.Drawing.Size(86, 24);
            this.starting.TabIndex = 20;
            this.starting.Text = "Iniciando";
            this.starting.Visible = false;
            // 
            // Printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(652, 296);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.starting);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.panelPrintState);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Printing";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printing";
            this.Load += new System.EventHandler(this.Printing_Load);
            this.panelPrintState.ResumeLayout(false);
            this.panelPrintState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label all;
        public CircularProgressBar.CircularProgressBar progress;
        public Bunifu.Framework.UI.BunifuImageButton logo;
        public BunifuAnimatorNS.Animator logoAnimator;
        public System.Windows.Forms.Panel panelPrintState;
        public System.Windows.Forms.Label starting;
    }
}