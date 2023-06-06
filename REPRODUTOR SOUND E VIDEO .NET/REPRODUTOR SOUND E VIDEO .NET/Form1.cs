using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace REPRODUTOR_SOUND_E_VIDEO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFachar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        WMPLib.IWMPPlaylist playlist;

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ofdAbrir.Title="Abrir mídia";
            ofdAbrir.Filter = "Arquivo MP4|*.mp4|Arquivo MP3|*.mp3";

            if (ofdAbrir.ShowDialog()== DialogResult.OK)
            {
                playlist = Reprodutor.playlistCollection.newPlaylist("Lista");
              
                foreach(var arquivo in ofdAbrir.FileNames)
                {
                    playlist.appendItem(Reprodutor.newMedia(arquivo));
                    listPlayList.Items.Add(arquivo);

                    Reprodutor.currentPlaylist = playlist;
                    Reprodutor.Ctlcontrols.play();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (listPlayList.Items.Count > 0)
            {
                sfdSalvar.Title = "Salvar Playlist";
                sfdSalvar.Filter = "Arquivo texto|*.txt";
                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter arquivo = new StreamWriter(sfdSalvar.FileName, false);
                    for (int i = 0; i < listPlayList.Items.Count; i++)
                    {
                        arquivo.WriteLine(listPlayList.Items[i].ToString());
                    }
                    arquivo.Close();
                }
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            ofdAbrir.Title = "Abrir Playlist";
            ofdAbrir.Filter = "Arquivo texto|*.txt";
            ofdAbrir.Multiselect = false;
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(ofdAbrir.FileName);
                while (arquivo.Peek() !=-1)
                {
                    listPlayList.Items.Add(arquivo.ReadLine());
                }
                arquivo.Close();
            }
        }

        private void listPlayList_DoubleClick(object sender, EventArgs e)
        {
            if (listPlayList.Items.Count > 0)
            {
                Reprodutor.URL = listPlayList.SelectedItem.ToString();
                Reprodutor.Ctlcontrols.play();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Reprodutor.Ctlcontrols.stop();
            listPlayList.Items.Clear();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
   
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
