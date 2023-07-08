namespace Panel_AppClosureUtility
{
    partial class Panel_AppClosureUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_AppClosureUtility));
            this.CXP_Timer = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.curvostylePictureBox1 = new AppClosureUtility.CurvostylePictureBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curvostylePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(204, 26);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::AppClosureUtility.Properties.Resources.pngwing_com__34_;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(171, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 26);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // curvostylePictureBox1
            // 
            this.curvostylePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.curvostylePictureBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.curvostylePictureBox1.BackgroundImage = global::AppClosureUtility.Properties.Resources.pngwing_com__33_;
            this.curvostylePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.curvostylePictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.curvostylePictureBox1.BorderRadius = 70;
            this.curvostylePictureBox1.BorderSize = 0;
            this.curvostylePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curvostylePictureBox1.ForeColor = System.Drawing.Color.White;
            this.curvostylePictureBox1.Location = new System.Drawing.Point(30, 30);
            this.curvostylePictureBox1.Name = "curvostylePictureBox1";
            this.curvostylePictureBox1.Size = new System.Drawing.Size(140, 140);
            this.curvostylePictureBox1.TabIndex = 0;
            this.curvostylePictureBox1.TabStop = false;
            this.curvostylePictureBox1.TextColor = System.Drawing.Color.White;
            this.curvostylePictureBox1.Click += new System.EventHandler(this.curvostylePictureBox1_Click);
            // 
            // Panel_AppClosureUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.curvostylePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Panel_AppClosureUtility";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Panel_AppClosureUtility";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Panel_AppClosureUtility_Load);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curvostylePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CXP_Timer;
        private System.Windows.Forms.Panel panelTitleBar;
        private AppClosureUtility.CurvostylePictureBox curvostylePictureBox1;
        private System.Windows.Forms.Button btnCerrar;
    }
}

