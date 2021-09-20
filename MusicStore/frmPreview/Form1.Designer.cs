
namespace frmPreview
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtbVolumen = new XComponent.SliderBar.MACTrackBar();
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.mtbDuracion = new XComponent.SliderBar.MACTrackBar();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.timerDuracion = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCanciones = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lbCarrito = new System.Windows.Forms.ListBox();
            this.cmbAlbumes = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.mtbVolumen);
            this.panel2.Controls.Add(this.wmPlayer);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Controls.Add(this.mtbDuracion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 374);
            this.panel2.TabIndex = 3;
            // 
            // mtbVolumen
            // 
            this.mtbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtbVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtbVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtbVolumen.IndentHeight = 6;
            this.mtbVolumen.Location = new System.Drawing.Point(110, 335);
            this.mtbVolumen.Maximum = 100;
            this.mtbVolumen.Minimum = 0;
            this.mtbVolumen.Name = "mtbVolumen";
            this.mtbVolumen.Size = new System.Drawing.Size(117, 22);
            this.mtbVolumen.TabIndex = 10;
            this.mtbVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtbVolumen.TickHeight = 4;
            this.mtbVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbVolumen.TrackerColor = System.Drawing.Color.LightGray;
            this.mtbVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtbVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtbVolumen.TrackLineHeight = 3;
            this.mtbVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtbVolumen.Value = 0;
            this.mtbVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtbVolumen_ValueChanged);
            // 
            // wmPlayer
            // 
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(42, 67);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(172, 76);
            this.wmPlayer.TabIndex = 3;
            this.wmPlayer.Visible = false;
            this.wmPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmPlayer_PlayStateChange);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(191, 299);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmPreview.Properties.Resources.defaultView;
            this.pictureBox1.Location = new System.Drawing.Point(42, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(41, 296);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 33);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Image = global::frmPreview.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(110, 286);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(54, 53);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbltitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lbltitulo.Location = new System.Drawing.Point(38, 227);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(45, 17);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = "Titulo.";
            // 
            // mtbDuracion
            // 
            this.mtbDuracion.BackColor = System.Drawing.Color.Transparent;
            this.mtbDuracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtbDuracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtbDuracion.IndentHeight = 6;
            this.mtbDuracion.Location = new System.Drawing.Point(41, 258);
            this.mtbDuracion.Maximum = 100;
            this.mtbDuracion.Minimum = 0;
            this.mtbDuracion.Name = "mtbDuracion";
            this.mtbDuracion.Size = new System.Drawing.Size(185, 22);
            this.mtbDuracion.TabIndex = 9;
            this.mtbDuracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbDuracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtbDuracion.TickHeight = 4;
            this.mtbDuracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbDuracion.TrackerColor = System.Drawing.Color.LightGray;
            this.mtbDuracion.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtbDuracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtbDuracion.TrackLineHeight = 3;
            this.mtbDuracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.mtbDuracion.Value = 100;
            this.mtbDuracion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mtbDuracion_MouseDown);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDuracion
            // 
            this.timerDuracion.Enabled = true;
            this.timerDuracion.Interval = 1;
            this.timerDuracion.Tick += new System.EventHandler(this.timerDuracion_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(269, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 450);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFecha);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 102);
            this.panel4.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(64, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 30);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.lblHora.Location = new System.Drawing.Point(61, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(136, 45);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbCanciones, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(525, 336);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbCanciones
            // 
            this.lbCanciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCanciones.FormattingEnabled = true;
            this.lbCanciones.Location = new System.Drawing.Point(3, 3);
            this.lbCanciones.Name = "lbCanciones";
            this.lbCanciones.Size = new System.Drawing.Size(256, 329);
            this.lbCanciones.TabIndex = 2;
            this.lbCanciones.SelectedIndexChanged += new System.EventHandler(this.lstArtistas_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Controls.Add(this.btnFinalizar);
            this.panel5.Controls.Add(this.lbCarrito);
            this.panel5.Controls.Add(this.cmbAlbumes);
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(265, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 330);
            this.panel5.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotal.Location = new System.Drawing.Point(16, 172);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label1";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(162, 286);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lbCarrito
            // 
            this.lbCarrito.FormattingEnabled = true;
            this.lbCarrito.Location = new System.Drawing.Point(3, 35);
            this.lbCarrito.Name = "lbCarrito";
            this.lbCarrito.Size = new System.Drawing.Size(251, 95);
            this.lbCarrito.TabIndex = 3;
            // 
            // cmbAlbumes
            // 
            this.cmbAlbumes.FormattingEnabled = true;
            this.cmbAlbumes.Location = new System.Drawing.Point(3, 8);
            this.cmbAlbumes.Name = "cmbAlbumes";
            this.cmbAlbumes.Size = new System.Drawing.Size(254, 21);
            this.cmbAlbumes.TabIndex = 2;
            this.cmbAlbumes.SelectedIndexChanged += new System.EventHandler(this.cmbAlbumes_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer horaFecha;
        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private XComponent.SliderBar.MACTrackBar mtbVolumen;
        private XComponent.SliderBar.MACTrackBar mtbDuracion;
        private System.Windows.Forms.Timer timerDuracion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox lbCanciones;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbAlbumes;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListBox lbCarrito;
        private System.Windows.Forms.Label lblTotal;
    }
}

