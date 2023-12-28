using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLC01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void AdicionarFicheiroPlaylist(ListBox listaFicheiros)
        {
            axVLCPlugin21.playlist.items.clear();

            for (int i = 0; i < listaFicheiros.Items.Count; i++)
            {
                string s = listaFicheiros.Items[i].ToString();
                var uri = new Uri(s);
                var convertedURI = uri.AbsoluteUri;
                axVLCPlugin21.playlist.add(convertedURI);
            }
        }


        public void Iniciar()
        {
            axVLCPlugin21.playlist.play();
        }

        public void Pausa()
        {
            axVLCPlugin21.playlist.pause();
        }

        public void Anterior()
        {
            axVLCPlugin21.playlist.prev();
        }

        public void Seguinte()
        {
            axVLCPlugin21.playlist.next();
        }

        public void Parar()
        {
            axVLCPlugin21.playlist.stop();
        }


    }
}
