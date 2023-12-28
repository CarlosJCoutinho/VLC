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
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnStartVLC32Player = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPauseVLC32Player = new System.Windows.Forms.Button();
            this.btnStopVLC32Player = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadFile1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPauseVLC64Player = new System.Windows.Forms.Button();
            this.btnStopVLC64Player = new System.Windows.Forms.Button();
            this.btnLoadFile2 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnAbrirPlayerVideo = new System.Windows.Forms.Button();
            this.btnFecharPlayerVideo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(12, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(351, 236);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnStartVLC32Player
            // 
            this.btnStartVLC32Player.Location = new System.Drawing.Point(12, 282);
            this.btnStartVLC32Player.Name = "btnStartVLC32Player";
            this.btnStartVLC32Player.Size = new System.Drawing.Size(75, 23);
            this.btnStartVLC32Player.TabIndex = 1;
            this.btnStartVLC32Player.Text = "Start";
            this.btnStartVLC32Player.UseVisualStyleBackColor = true;
            this.btnStartVLC32Player.Click += new System.EventHandler(this.btnStartVLC32Player_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnPauseVLC32Player
            // 
            this.btnPauseVLC32Player.Location = new System.Drawing.Point(93, 282);
            this.btnPauseVLC32Player.Name = "btnPauseVLC32Player";
            this.btnPauseVLC32Player.Size = new System.Drawing.Size(75, 23);
            this.btnPauseVLC32Player.TabIndex = 3;
            this.btnPauseVLC32Player.Text = "Pause";
            this.btnPauseVLC32Player.UseVisualStyleBackColor = true;
            this.btnPauseVLC32Player.Click += new System.EventHandler(this.btnPauseVLC32Player_Click);
            // 
            // btnStopVLC32Player
            // 
            this.btnStopVLC32Player.Location = new System.Drawing.Point(174, 282);
            this.btnStopVLC32Player.Name = "btnStopVLC32Player";
            this.btnStopVLC32Player.Size = new System.Drawing.Size(75, 23);
            this.btnStopVLC32Player.TabIndex = 4;
            this.btnStopVLC32Player.Text = "Stop";
            this.btnStopVLC32Player.UseVisualStyleBackColor = true;
            this.btnStopVLC32Player.Click += new System.EventHandler(this.btnStopVLC32Player_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 605);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadFile1
            // 
            this.btnLoadFile1.Location = new System.Drawing.Point(403, 282);
            this.btnLoadFile1.Name = "btnLoadFile1";
            this.btnLoadFile1.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile1.TabIndex = 6;
            this.btnLoadFile1.Text = "Load file 1";
            this.btnLoadFile1.UseVisualStyleBackColor = true;
            this.btnLoadFile1.Click += new System.EventHandler(this.btnLoadFile1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(467, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(287, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPauseVLC64Player
            // 
            this.btnPauseVLC64Player.Location = new System.Drawing.Point(565, 281);
            this.btnPauseVLC64Player.Name = "btnPauseVLC64Player";
            this.btnPauseVLC64Player.Size = new System.Drawing.Size(75, 23);
            this.btnPauseVLC64Player.TabIndex = 9;
            this.btnPauseVLC64Player.Text = "Pause";
            this.btnPauseVLC64Player.UseVisualStyleBackColor = true;
            this.btnPauseVLC64Player.Click += new System.EventHandler(this.btnPauseVLC64Player_Click);
            // 
            // btnStopVLC64Player
            // 
            this.btnStopVLC64Player.Location = new System.Drawing.Point(646, 281);
            this.btnStopVLC64Player.Name = "btnStopVLC64Player";
            this.btnStopVLC64Player.Size = new System.Drawing.Size(75, 23);
            this.btnStopVLC64Player.TabIndex = 10;
            this.btnStopVLC64Player.Text = "Stop";
            this.btnStopVLC64Player.UseVisualStyleBackColor = true;
            this.btnStopVLC64Player.Click += new System.EventHandler(this.btnStopVLC64Player_Click);
            // 
            // btnLoadFile2
            // 
            this.btnLoadFile2.Location = new System.Drawing.Point(403, 311);
            this.btnLoadFile2.Name = "btnLoadFile2";
            this.btnLoadFile2.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile2.TabIndex = 11;
            this.btnLoadFile2.Text = "Load file 2";
            this.btnLoadFile2.UseVisualStyleBackColor = true;
            this.btnLoadFile2.Click += new System.EventHandler(this.btnLoadFile2_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.Location = new System.Drawing.Point(484, 281);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(75, 23);
            this.btnPlay1.TabIndex = 13;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlayVLC64Player_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(403, 340);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 121);
            this.listBox1.TabIndex = 14;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(760, 340);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 15;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(760, 369);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearListBox.TabIndex = 16;
            this.btnClearListBox.Text = "Clear";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add to Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtVideoFilePlaying
            // 
            this.txtVideoFilePlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoFilePlaying.Location = new System.Drawing.Point(841, 226);
            this.txtVideoFilePlaying.Name = "txtVideoFilePlaying";
            this.txtVideoFilePlaying.ReadOnly = true;
            this.txtVideoFilePlaying.Size = new System.Drawing.Size(39, 22);
            this.txtVideoFilePlaying.TabIndex = 18;
            this.txtVideoFilePlaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Items count:";
            // 
            // txtItemsCount
            // 
            this.txtItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsCount.Location = new System.Drawing.Point(841, 198);
            this.txtItemsCount.Name = "txtItemsCount";
            this.txtItemsCount.ReadOnly = true;
            this.txtItemsCount.Size = new System.Drawing.Size(39, 22);
            this.txtItemsCount.TabIndex = 21;
            this.txtItemsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(760, 12);
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
            this.btnGravar.Location = new System.Drawing.Point(760, 41);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(760, 70);
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
            this.btnLimpar.Location = new System.Drawing.Point(760, 99);
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
            this.btnConfirmar.Location = new System.Drawing.Point(760, 128);
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
            this.btnIniciar.Location = new System.Drawing.Point(841, 12);
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
            this.btnPausa.Location = new System.Drawing.Point(841, 41);
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
            this.btnAnterior.Location = new System.Drawing.Point(841, 70);
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
            this.btnProximo.Location = new System.Drawing.Point(841, 99);
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
            this.btnParar.Location = new System.Drawing.Point(841, 128);
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
            this.btnNovaPlaylist.Location = new System.Drawing.Point(760, 157);
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
            this.listBox2.Location = new System.Drawing.Point(403, 488);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(351, 82);
            this.listBox2.TabIndex = 33;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnAdicionar2
            // 
            this.btnAdicionar2.Location = new System.Drawing.Point(760, 488);
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
            this.btnPlayClip.Location = new System.Drawing.Point(760, 517);
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
            this.btnStopClip.Location = new System.Drawing.Point(841, 517);
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
            this.btnLimpar2.Location = new System.Drawing.Point(841, 488);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar2.TabIndex = 37;
            this.btnLimpar2.Text = "Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // btnAbrirPlayerVideo
            // 
            this.btnAbrirPlayerVideo.Location = new System.Drawing.Point(322, 340);
            this.btnAbrirPlayerVideo.Name = "btnAbrirPlayerVideo";
            this.btnAbrirPlayerVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirPlayerVideo.TabIndex = 38;
            this.btnAbrirPlayerVideo.Text = "Abrir";
            this.btnAbrirPlayerVideo.UseVisualStyleBackColor = true;
            this.btnAbrirPlayerVideo.Click += new System.EventHandler(this.btnAbrirPlayerVideo_Click);
            // 
            // btnFecharPlayerVideo
            // 
            this.btnFecharPlayerVideo.Location = new System.Drawing.Point(322, 369);
            this.btnFecharPlayerVideo.Name = "btnFecharPlayerVideo";
            this.btnFecharPlayerVideo.Size = new System.Drawing.Size(75, 23);
            this.btnFecharPlayerVideo.TabIndex = 39;
            this.btnFecharPlayerVideo.Text = "Fechar";
            this.btnFecharPlayerVideo.UseVisualStyleBackColor = true;
            this.btnFecharPlayerVideo.Click += new System.EventHandler(this.btnFecharPlayerVideo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "End reached:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(841, 546);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(39, 22);
            this.textBox3.TabIndex = 41;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(403, 12);
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
            this.label4.Location = new System.Drawing.Point(400, 258);
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
            this.ClientSize = new System.Drawing.Size(964, 640);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFecharPlayerVideo);
            this.Controls.Add(this.btnAbrirPlayerVideo);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.btnLoadFile2);
            this.Controls.Add(this.btnStopVLC64Player);
            this.Controls.Add(this.btnPauseVLC64Player);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.btnLoadFile1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStopVLC32Player);
            this.Controls.Add(this.btnPauseVLC32Player);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStartVLC32Player);
            this.Controls.Add(this.vlcControl1);
            this.Name = "frmVLC";
            this.Text = "VLC test";
            this.Load += new System.EventHandler(this.frmVLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnStartVLC32Player;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPauseVLC32Player;
        private System.Windows.Forms.Button btnStopVLC32Player;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoadFile1;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPauseVLC64Player;
        private System.Windows.Forms.Button btnStopVLC64Player;
        private System.Windows.Forms.Button btnLoadFile2;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnClearListBox;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button btnAbrirPlayerVideo;
        private System.Windows.Forms.Button btnFecharPlayerVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

