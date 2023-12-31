using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms.Xaml;

namespace VLC01
{
    public partial class frmVLC : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        Form2 playerVideo = new Form2();

        public frmVLC()
        {
            InitializeComponent();

            this.axVLCPlugin21.AutoLoop = true;
        }

        private void frmVLC_Load(object sender, EventArgs e)
        {
            
            //textBox2.Text = "https://www.learningcontainer.com/wp-content/uploads/2020/05/sample-mp4-file.mp4";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (playerVideo != null) playerVideo.Close();    
            this.Close();
        }

        // VLC Player 64 bits
        private void axVLCPlugin21_MediaPlayerPositionChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerPositionChangedEvent e)
        {
            txtVideoFilePlaying.Text = axVLCPlugin21.playlist.currentItem.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir ficheiros de video";
            openFileDialog1.Filter = "Todos os ficheiros de video (*.avi;*.mp4;*.wmv)|*.avi;*.mp4;*.wmv";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var ficheiroVideo in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(ficheiroVideo);
                }
            }

            if (listBox1.Items.Count > 0)
            {
                // Botões Playlist
                btnGravar.Enabled = true;
                btnLimpar.Enabled = true;
                btnConfirmar.Enabled = true;

                // Botões painel gráfico
                //buttonPainelPublicidadeAbrir.Enabled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                saveFileDialog1.Title = "Gravar playlist";
                saveFileDialog1.Filter = "Ficheiro texto|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(saveFileDialog1.FileName, false);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        file.WriteLine(listBox1.Items[i].ToString());
                    }
                    file.Close();
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir o ficheiro da playlist";
            openFileDialog1.Filter = "Ficheiro texto (*.txt)|*.txt";
            openFileDialog1.Multiselect = false;

            // colocar os ficheiros na listbox
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader ficheiro = new StreamReader(openFileDialog1.FileName);
                while (ficheiro.Peek() != -1)
                {
                    listBox1.Items.Add(ficheiro.ReadLine());
                }
                ficheiro.Close();
            }

            if (listBox1.Items.Count > 0)
            {
                // Botões da playlist
                btnLimpar.Enabled = true;
                btnConfirmar.Enabled = true;

                // Botões do painel gráfico
                //buttonPainelPublicidadeAbrir.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Botões Playlist
            btnGravar.Enabled = false;
            btnLimpar.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Painel grágico

            //4. Assign the delegate
            //this.painelPlaylist += new PainelPlaylist(painelPublicidade.Subscription);

            //5. Call the delegate
            //painelPlaylist(listBoxPlaylist);


            // axWindowsMediaPlayer embutido no Painel de Comando
            if (listBox1 != null)
            {
                //axVideoPlaylist = axWindowsMediaPlayer.playlistCollection.newPlaylist("Lista de Vídeos");
                //for (int i = 0; i < listBoxPlaylist.Items.Count; i++)
                //{
                //    axVideoPlaylist.appendItem(axWindowsMediaPlayer.newMedia(listBoxPlaylist.Items[i].ToString()));
                //    axWindowsMediaPlayer.currentPlaylist = axVideoPlaylist;
                //}

                txtItemsCount.Text = listBox1.Items.Count.ToString();

                axVLCPlugin21.playlist.items.clear();

                axVLCPlugin21.AutoPlay = true;

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string s = listBox1.Items[i].ToString();
                    var uri = new Uri(s);
                    var convertedURI = uri.AbsoluteUri;
                    axVLCPlugin21.playlist.add(convertedURI);
                }

                playerVideo.AdicionarFicheiroPlaylist(listBox1);
            }

            // Button status
            btnConfirmar.Enabled = false;
            btnAdicionar.Enabled = false;
            btnGravar.Enabled = false;
            btnCarregar.Enabled = false;
            btnLimpar.Enabled = false;
            btnIniciar.Enabled = true;
            btnNovaPlaylist.Enabled = true;

            // Mudança da cor de fundo da listbox
            listBox1.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer.Ctlcontrols.play();
            //axWindowsMediaPlayer.settings.playCount = 10000;

            //timer1.Start();

            // Player do painel de comando
            axVLCPlugin21.playlist.play();

            // Player do painel gráfico
            if (playerVideo != null)
            {
                playerVideo.Iniciar();
            }

            // Atualização do estado dos botões
            btnPausa.Enabled = true;
            
            btnProximo.Enabled = true;
            btnParar.Enabled = true;
            btnIniciar.Enabled = false;
            btnNovaPlaylist.Enabled = false;

            if (axVLCPlugin21.playlist.currentItem == 0)
            {
                btnAnterior.Enabled = false;
            }
            else
            {
                btnAnterior.Enabled = true;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            //painelPublicidade.Parar();

            axVLCPlugin21.playlist.stop();

            // Player do painel gráfico
            if (playerVideo != null)
            {
                playerVideo.Parar();
            }

            btnIniciar.Enabled = true;
            btnPausa.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnParar.Enabled = false;
            btnNovaPlaylist.Enabled = true;

            //timer1.Stop();

            // inicializar a barra de progesso do vídeo
            //lbl_track_start.Text = "00:00";
            //lbl_track_end.Text = "00:00";
            //progressBar1.Value = 0;
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.pause();

            // Player do painel gráfico
            if (playerVideo != null)
            {
                playerVideo.Pausa();
            }

            btnIniciar.Enabled = true;
            btnPausa.Enabled = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.prev();

            // Player do painel gráfico
            if (playerVideo != null)
            {
                playerVideo.Anterior();
            }

            if (axVLCPlugin21.playlist.currentItem == 0)
            {
                btnAnterior.Enabled = false;
            }
            else
            {
                btnAnterior.Enabled = true;
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.next();

            // Player do painel gráfico
            if (playerVideo != null)
            {
                playerVideo.Seguinte();
            }
        }
    
        private void btnNovaPlaylist_Click(object sender, EventArgs e)
        {
            //buttonPainelPublicidadeAbrir.Enabled = false;
            btnNovaPlaylist.Enabled = false;
            btnGravar.Enabled = false;
            btnLimpar.Enabled = false;

            listBox1.Enabled = true;
            listBox1.Items.Clear();

            btnAdicionar.Enabled = true;
            btnCarregar.Enabled = true;
            btnIniciar.Enabled = false;

            // Mudança da cor de fundo da listbox
            listBox1.BackColor = Color.White;

            axVLCPlugin21.playlist.items.clear();
        }

        private void btnAdicionar2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir ficheiros de video";
            openFileDialog1.Filter = "Todos os ficheiros de video (*.avi;*.mp4;*.wmv)|*.avi;*.mp4;*.wmv";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var videoFile in openFileDialog1.FileNames)
                {
                    listBox2.Items.Add(videoFile);
                }

                btnLimpar2.Enabled = true;
            }

            textBox3.Text = "";
        }

        private void btnPlayClip_Click(object sender, EventArgs e)
        {
            // Play the selected video in the Control Panel window
            if (listBox2.Text != "")
            {
                // Carrega no "player" o ficheiro selecionado na listbox
                //axWindowsMediaPlayer.URL = lsbPlayList2.SelectedItem.ToString();

                axVLCPlugin21.playlist.items.clear();

                textBox3.Text = "";

                this.axVLCPlugin21.AutoLoop = false;
               

                string s = listBox2.SelectedItem.ToString();
                var uri = new Uri(s);
                var convertedURI = uri.AbsoluteUri;
                axVLCPlugin21.playlist.add(convertedURI);

                // Exibe o ficheiro selecionado no player
                //axWindowsMediaPlayer.Ctlcontrols.play();

                axVLCPlugin21.AutoPlay = false;
                axVLCPlugin21.playlist.playItem(0);
                
                // Exibe o vídeo uma só vez
                //axWindowsMediaPlayer.settings.playCount = 1;

                // Iniciar o Timer1
                //timer1.Start();

                //Minimia o layout da modalidade
                //if (textBoxDesporto.Text == "Andebol - 01") andebol_01.WindowState = FormWindowState.Minimized;
                //if (textBoxDesporto.Text == "Basquetebol - 01") basquetebol_01.WindowState = FormWindowState.Minimized;
                //if (textBoxDesporto.Text == "Basquetebol - 02") basquetebol_02.WindowState = FormWindowState.Minimized;
                //if (textBoxDesporto.Text == "Basquetebol - 03") basquetebol_03.WindowState = FormWindowState.Minimized;
                //if (textBoxDesporto.Text == "Futsal - 01") futsal_01.WindowState = FormWindowState.Minimized;
                //if (textBoxDesporto.Text == "Hóquei em Patins - 01") hoquei_01.WindowState = FormWindowState.Minimized;

                // Verifica se há mais do que um monitor, para localizar a projeção dos videos
                //if (screens.Length > 1)
                //{
                //    painelPublicidade.Location = Screen.AllScreens[1].WorkingArea.Location;
                //}

                // Mostra o layout dos vídeos
                //painelPublicidade.Show();

                // Abre o layout dos vídeos
                //painelPublicidade.WindowState = FormWindowState.Normal;

                //Exibe o video que foi selecionado para ser exibido no player do Painel de Comando
                //painelPublicidade.PlaySelectedVideo(axWindowsMediaPlayer.URL);

                //buttonPainelDesportoAbrir.Enabled = true;
                //buttonPainelDesportoFechar.Enabled = false;

                //buttonPainelPublicidadeAbrir.Enabled = false;
                //buttonPainelPublicidadeFechar.Enabled = true;

                btnStopClip.Enabled = true;

                if (listBox2.Items.Count > 0)
                {
                    listBox1.BackColor = Color.White;
                    if(listBox1.Items.Count > 0) btnConfirmar.Enabled = true;
                    btnIniciar.Enabled = false;
                    btnPausa.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnParar.Enabled = false;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ativar o botão PlayClip
            btnPlayClip.Enabled = true;
        }

        private void btnStopClip_Click(object sender, EventArgs e)
        {
            // Stop video in the Control Panel window
            //axWindowsMediaPlayer.Ctlcontrols.stop();

            axVLCPlugin21.playlist.stop();

            textBox3.Text = "";

            // Stop video in the Graphic Display
            //painelPublicidade.StopVideo();

            // Bptões Playlist
            if (listBox1.Items.Count > 0)
            {
                //buttonConfirmarPlaylist.Enabled = true;

                this.btnConfirmar_Click(sender, e);

                this.axVLCPlugin21.AutoLoop = true;
            }

            //painelPublicidade.WindowState = FormWindowState.Minimized;

            // inicializar a barra de progesso do vídeo
            //lbl_track_start.Text = "00:00";
            //lbl_track_end.Text = "00:00";
            //progressBar1.Value = 0;

            // Voltar a exibir o layout 
            //if (textBoxDesporto.Text == "Andebol - 01")
            //{
            //    if (andebol_01.WindowState != FormWindowState.Normal) andebol_01.WindowState = FormWindowState.Normal;
            //}

            //if (textBoxDesporto.Text == "Basquetebol - 01")
            //{
            //    if (basquetebol_01.WindowState != FormWindowState.Normal) basquetebol_01.WindowState = FormWindowState.Normal;
            //}

            //if (textBoxDesporto.Text == "Basquetebol - 02")
            //{
            //    if (basquetebol_02.WindowState != FormWindowState.Normal) basquetebol_02.WindowState = FormWindowState.Normal;
            //}

            //if (textBoxDesporto.Text == "Basquetebol - 03")
            //{
            //    if (basquetebol_03.WindowState != FormWindowState.Normal) basquetebol_03.WindowState = FormWindowState.Normal;
            //}

            //if (textBoxDesporto.Text == "Futsal - 01")
            //{
            //    if (futsal_01.WindowState != FormWindowState.Normal) futsal_01.WindowState = FormWindowState.Normal;
            //}

            //if (textBoxDesporto.Text == "Hóquei em Patins - 01")
            //{
            //    if (hoquei_01.WindowState != FormWindowState.Normal) hoquei_01.WindowState = FormWindowState.Normal;
            //}

            // Botões de comando do painel
            //buttonPainelPublicidadeAbrir.Enabled = true;
            //buttonPainelPublicidadeFechar.Enabled = false;

            //buttonPainelDesportoAbrir.Enabled = false;
            //buttonPainelDesportoFechar.Enabled = true;

            btnPlayClip.Enabled = true;
            btnStopClip.Enabled = false;
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            btnLimpar2.Enabled = false;
            btnPlayClip.Enabled = false;
            btnStopClip.Enabled = false;
        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            textBox3.Text = "Yes";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axVLCPlugin21.input.state == 0) textBox2.Text = "IDLE";
            else if (axVLCPlugin21.input.state == 1) textBox2.Text = "OPENING";
            else if (axVLCPlugin21.input.state == 2) textBox2.Text = "BUFFERING";
            else if (axVLCPlugin21.input.state == 3) textBox2.Text = "PLAYING";
            else if (axVLCPlugin21.input.state == 4) textBox2.Text = "PAUSED";
            else if (axVLCPlugin21.input.state == 5) textBox2.Text = "STOPPING";
            else if (axVLCPlugin21.input.state == 6) textBox2.Text = "ENDED";
            else if (axVLCPlugin21.input.state == 7) textBox2.Text = "ERROR";
        }
    }
}
