namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.bnfprincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bnfvigilancia = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRegistrarCandidato = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVotos = new System.Windows.Forms.Button();
            this.bnfclima = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfrecordatorio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfconsejos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfactivacion = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnfprincipal
            // 
            this.bnfprincipal.ElipseRadius = 46;
            this.bnfprincipal.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(226, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Volver";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(254, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "User";
            // 
            // bnfvigilancia
            // 
            this.bnfvigilancia.ElipseRadius = 20;
            this.bnfvigilancia.TargetControl = this.btnRegistrarCandidato;
            // 
            // btnRegistrarCandidato
            // 
            this.btnRegistrarCandidato.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarCandidato.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnRegistrarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCandidato.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCandidato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarCandidato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCandidato.Location = new System.Drawing.Point(54, 291);
            this.btnRegistrarCandidato.Name = "btnRegistrarCandidato";
            this.btnRegistrarCandidato.Size = new System.Drawing.Size(196, 57);
            this.btnRegistrarCandidato.TabIndex = 12;
            this.btnRegistrarCandidato.Text = "Registrar Candidatos";
            this.btnRegistrarCandidato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCandidato.UseVisualStyleBackColor = false;
            this.btnRegistrarCandidato.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Transparent;
            this.btnVotar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVotar.FlatAppearance.BorderSize = 0;
            this.btnVotar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVotar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotar.Location = new System.Drawing.Point(114, 354);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(70, 45);
            this.btnVotar.TabIndex = 11;
            this.btnVotar.Text = "Votar";
            this.btnVotar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVotos
            // 
            this.btnVotos.BackColor = System.Drawing.Color.Transparent;
            this.btnVotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVotos.FlatAppearance.BorderSize = 0;
            this.btnVotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnVotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVotos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVotos.Location = new System.Drawing.Point(74, 405);
            this.btnVotos.Name = "btnVotos";
            this.btnVotos.Size = new System.Drawing.Size(154, 49);
            this.btnVotos.TabIndex = 13;
            this.btnVotos.Text = "Votos Obtenidos";
            this.btnVotos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotos.UseVisualStyleBackColor = false;
            this.btnVotos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnfclima
            // 
            this.bnfclima.ElipseRadius = 20;
            // 
            // bnfrecordatorio
            // 
            this.bnfrecordatorio.ElipseRadius = 20;
            this.bnfrecordatorio.TargetControl = this.btnVotar;
            // 
            // bnfconsejos
            // 
            this.bnfconsejos.ElipseRadius = 20;
            this.bnfconsejos.TargetControl = this.btnVotos;
            // 
            // bnfactivacion
            // 
            this.bnfactivacion.ElipseRadius = 20;
            this.bnfactivacion.TargetControl = this;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.LightGray;
            this.pnlmenu.Controls.Add(this.pictureBox2);
            this.pnlmenu.Controls.Add(this.label2);
            this.pnlmenu.Controls.Add(this.btnVotar);
            this.pnlmenu.Controls.Add(this.btnRegistrarCandidato);
            this.pnlmenu.Controls.Add(this.btnVotos);
            this.pnlmenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlmenu.Location = new System.Drawing.Point(0, 161);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(296, 461);
            this.pnlmenu.TabIndex = 16;
            this.pnlmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmenu_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "BIENVENID@";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(296, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bnfprincipal;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bnfvigilancia;
        private System.Windows.Forms.Button btnVotos;
        private System.Windows.Forms.Button btnRegistrarCandidato;
        private System.Windows.Forms.Button btnVotar;
        private Bunifu.Framework.UI.BunifuElipse bnfclima;
        private Bunifu.Framework.UI.BunifuElipse bnfrecordatorio;
        private Bunifu.Framework.UI.BunifuElipse bnfconsejos;
        private Bunifu.Framework.UI.BunifuElipse bnfactivacion;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}