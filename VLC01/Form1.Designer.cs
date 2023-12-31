namespace VLC01
{
    partial class frmVLC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVLC));
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtVideoFilePlaying = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemsCount = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnNovaPlaylist = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAdicionar2 = new System.Windows.Forms.Button();
            this.btnPlayClip = new System.Windows.Forms.Button();
            this.btnStopClip = new System.Windows.Forms.Button();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(478, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(91, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(287, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(27, 315);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 121);
            this.listBox1.TabIndex = 14;
            // 
            // txtVideoFilePlaying
            // 
            this.txtVideoFilePlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoFilePlaying.Location = new System.Drawing.Point(465, 239);
            this.txtVideoFilePlaying.Name = "txtVideoFilePlaying";
            this.txtVideoFilePlaying.ReadOnly = true;
            this.txtVideoFilePlaying.Size = new System.Drawing.Size(39, 22);
            this.txtVideoFilePlaying.TabIndex = 18;
            this.txtVideoFilePlaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Items count:";
            // 
            // txtItemsCount
            // 
            this.txtItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsCount.Location = new System.Drawing.Point(465, 211);
            this.txtItemsCount.Name = "txtItemsCount";
            this.txtItemsCount.ReadOnly = true;
            this.txtItemsCount.Size = new System.Drawing.Size(39, 22);
            this.txtItemsCount.TabIndex = 21;
            this.txtItemsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(384, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(384, 54);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(384, 83);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 24;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(384, 112);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(384, 141);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Location = new System.Drawing.Point(465, 25);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 27;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Enabled = false;
            this.btnPausa.Location = new System.Drawing.Point(465, 54);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(75, 23);
            this.btnPausa.TabIndex = 28;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(465, 83);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 29;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.Location = new System.Drawing.Point(465, 112);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 30;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(465, 141);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 31;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnNovaPlaylist
            // 
            this.btnNovaPlaylist.Enabled = false;
            this.btnNovaPlaylist.Location = new System.Drawing.Point(384, 170);
            this.btnNovaPlaylist.Name = "btnNovaPlaylist";
            this.btnNovaPlaylist.Size = new System.Drawing.Size(156, 23);
            this.btnNovaPlaylist.TabIndex = 32;
            this.btnNovaPlaylist.Text = "Nova Playlist";
            this.btnNovaPlaylist.UseVisualStyleBackColor = true;
            this.btnNovaPlaylist.Click += new System.EventHandler(this.btnNovaPlaylist_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(27, 453);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(351, 82);
            this.listBox2.TabIndex = 33;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnAdicionar2
            // 
            this.btnAdicionar2.Location = new System.Drawing.Point(384, 453);
            this.btnAdicionar2.Name = "btnAdicionar2";
            this.btnAdicionar2.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar2.TabIndex = 34;
            this.btnAdicionar2.Text = "Adicionar";
            this.btnAdicionar2.UseVisualStyleBackColor = true;
            this.btnAdicionar2.Click += new System.EventHandler(this.btnAdicionar2_Click);
            // 
            // btnPlayClip
            // 
            this.btnPlayClip.Enabled = false;
            this.btnPlayClip.Location = new System.Drawing.Point(384, 482);
            this.btnPlayClip.Name = "btnPlayClip";
            this.btnPlayClip.Size = new System.Drawing.Size(75, 23);
            this.btnPlayClip.TabIndex = 35;
            this.btnPlayClip.Text = "Play Clip";
            this.btnPlayClip.UseVisualStyleBackColor = true;
            this.btnPlayClip.Click += new System.EventHandler(this.btnPlayClip_Click);
            // 
            // btnStopClip
            // 
            this.btnStopClip.Enabled = false;
            this.btnStopClip.Location = new System.Drawing.Point(465, 482);
            this.btnStopClip.Name = "btnStopClip";
            this.btnStopClip.Size = new System.Drawing.Size(75, 23);
            this.btnStopClip.TabIndex = 36;
            this.btnStopClip.Text = "Stop Clip";
            this.btnStopClip.UseVisualStyleBackColor = true;
            this.btnStopClip.Click += new System.EventHandler(this.btnStopClip_Click);
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Enabled = false;
            this.btnLimpar2.Location = new System.Drawing.Point(465, 453);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar2.TabIndex = 37;
            this.btnLimpar2.Text = "Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "End reached:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(465, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(39, 22);
            this.textBox3.TabIndex = 41;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(27, 25);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(351, 235);
            this.axVLCPlugin21.TabIndex = 7;
            this.axVLCPlugin21.MediaPlayerEndReached += new System.EventHandler(this.axVLCPlugin21_MediaPlayerEndReached);
            this.axVLCPlugin21.MediaPlayerPositionChanged += new AxAXVLC.DVLCEvents_MediaPlayerPositionChangedEventHandler(this.axVLCPlugin21_MediaPlayerPositionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "VLC status:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmVLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar2);
            this.Controls.Add(this.btnStopClip);
            this.Controls.Add(this.btnPlayClip);
            this.Controls.Add(this.btnAdicionar2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnNovaPlaylist);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtItemsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVideoFilePlaying);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.btnClose);
            this.Name = "frmVLC";
            this.Text = "VLC test";
            this.Load += new System.EventHandler(this.frmVLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtVideoFilePlaying;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemsCount;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnNovaPlaylist;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdicionar2;
        private System.Windows.Forms.Button btnPlayClip;
        private System.Windows.Forms.Button btnStopClip;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

