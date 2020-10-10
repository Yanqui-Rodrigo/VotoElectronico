namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    partial class FrmVotaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVotaciones));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.cbSecretario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbPresidente = new System.Windows.Forms.ComboBox();
            this.btnVigilancia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTesorero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.VOTANTE = new System.Windows.Forms.Label();
            this.lblVotante = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picCam = new System.Windows.Forms.PictureBox();
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, -6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(-5, 838);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 103);
            this.panel4.TabIndex = 98;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(90)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(317, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "Volver";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVotar.Enabled = false;
            this.btnVotar.FlatAppearance.BorderSize = 0;
            this.btnVotar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVotar.Location = new System.Drawing.Point(37, 566);
            this.btnVotar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(265, 55);
            this.btnVotar.TabIndex = 102;
            this.btnVotar.Text = "VOTAR";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // cbSecretario
            // 
            this.cbSecretario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecretario.Enabled = false;
            this.cbSecretario.FormattingEnabled = true;
            this.cbSecretario.Location = new System.Drawing.Point(144, 485);
            this.cbSecretario.Margin = new System.Windows.Forms.Padding(4);
            this.cbSecretario.Name = "cbSecretario";
            this.cbSecretario.Size = new System.Drawing.Size(171, 25);
            this.cbSecretario.TabIndex = 101;
            this.cbSecretario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(28, 490);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "SECRETARIO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(39, 168);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(263, 47);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbPresidente
            // 
            this.cbPresidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresidente.Enabled = false;
            this.cbPresidente.FormattingEnabled = true;
            this.cbPresidente.Location = new System.Drawing.Point(144, 454);
            this.cbPresidente.Margin = new System.Windows.Forms.Padding(4);
            this.cbPresidente.Name = "cbPresidente";
            this.cbPresidente.Size = new System.Drawing.Size(171, 25);
            this.cbPresidente.TabIndex = 65560;
            this.cbPresidente.SelectedIndexChanged += new System.EventHandler(this.cbPresidente_SelectedIndexChanged);
            // 
            // btnVigilancia
            // 
            this.btnVigilancia.BackColor = System.Drawing.Color.SlateGray;
            this.btnVigilancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVigilancia.FlatAppearance.BorderSize = 0;
            this.btnVigilancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnVigilancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVigilancia.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVigilancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVigilancia.ImageKey = "(ninguno)";
            this.btnVigilancia.Location = new System.Drawing.Point(27, 8);
            this.btnVigilancia.Margin = new System.Windows.Forms.Padding(4);
            this.btnVigilancia.Name = "btnVigilancia";
            this.btnVigilancia.Size = new System.Drawing.Size(111, 76);
            this.btnVigilancia.TabIndex = 65561;
            this.btnVigilancia.Text = "VOTAR";
            this.btnVigilancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVigilancia.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 65562;
            this.label1.Text = "PRESIDENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 165);
            this.panel1.TabIndex = 65563;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(246, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 14;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbTesorero
            // 
            this.cbTesorero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTesorero.Enabled = false;
            this.cbTesorero.FormattingEnabled = true;
            this.cbTesorero.Location = new System.Drawing.Point(144, 521);
            this.cbTesorero.Margin = new System.Windows.Forms.Padding(4);
            this.cbTesorero.Name = "cbTesorero";
            this.cbTesorero.Size = new System.Drawing.Size(171, 25);
            this.cbTesorero.TabIndex = 65565;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 520);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 65564;
            this.label2.Text = "TESORERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 65566;
            this.label3.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(124, 102);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 25);
            this.txtDNI.TabIndex = 65567;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // VOTANTE
            // 
            this.VOTANTE.AutoSize = true;
            this.VOTANTE.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOTANTE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VOTANTE.Location = new System.Drawing.Point(28, 135);
            this.VOTANTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VOTANTE.Name = "VOTANTE";
            this.VOTANTE.Size = new System.Drawing.Size(71, 17);
            this.VOTANTE.TabIndex = 65568;
            this.VOTANTE.Text = "VOTANTE";
            // 
            // lblVotante
            // 
            this.lblVotante.AutoSize = true;
            this.lblVotante.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVotante.Location = new System.Drawing.Point(120, 135);
            this.lblVotante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVotante.Name = "lblVotante";
            this.lblVotante.Size = new System.Drawing.Size(53, 17);
            this.lblVotante.TabIndex = 65569;
            this.lblVotante.Text = "---------";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // picCam
            // 
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCam.Image = ((System.Drawing.Image)(resources.GetObject("picCam.Image")));
            this.picCam.Location = new System.Drawing.Point(77, 251);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(163, 158);
            this.picCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam.TabIndex = 65573;
            this.picCam.TabStop = false;
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(167, 224);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(135, 25);
            this.cbxDispositivo.TabIndex = 65571;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.Location = new System.Drawing.Point(34, 226);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(137, 17);
            this.lblCamera.TabIndex = 65570;
            this.lblCamera.Text = "Seleccione Camera :";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(109, 415);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(98, 28);
            this.btnIniciar.TabIndex = 65572;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 46;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmVotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(340, 690);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.cbxDispositivo);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblVotante);
            this.Controls.Add(this.VOTANTE);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTesorero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVigilancia);
            this.Controls.Add(this.cbPresidente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.cbSecretario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVotaciones";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecordatorio";
            this.Load += new System.EventHandler(this.FrmVotaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.ComboBox cbSecretario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbPresidente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVigilancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTesorero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label VOTANTE;
        private System.Windows.Forms.Label lblVotante;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}