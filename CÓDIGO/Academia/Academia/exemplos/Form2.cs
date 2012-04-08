using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;

namespace Academia.exemplos
{
    public partial class Form2 : Form
    {
        private bool existem_dispositivos = false;
        private FilterInfoCollection dispositivos_video;
        private VideoCaptureDevice fonte_video = null;

        public Form2()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void CarregaDispositivos(FilterInfoCollection dispositivos)
        {
            for (int i = 0; i < dispositivos.Count; i++)
            {
                comboBox_dispositivo.Items.Add(dispositivos[i].Name.ToString());
            }

            comboBox_dispositivo.Text = comboBox_dispositivo.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            dispositivos_video = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivos_video.Count == 0)
            {
                existem_dispositivos = false;
            }
            else
            {
                existem_dispositivos = true;
            }
        }

        public void TerminarFonteVideo()
        {
            if (!(fonte_video == null))
            {
                if (fonte_video.IsRunning)
                {
                    fonte_video.SignalToStop();
                    fonte_video = null;
                }
            }
        }

        private void VideoNovoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagem = (Bitmap)eventArgs.Frame.Clone();
            imagem.SetResolution(250,400);
            pictureBox_foto.Image = imagem;
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            if (button_iniciar.Text.Equals("Iniciar"))
            {
                if (existem_dispositivos)
                {
                    fonte_video = new VideoCaptureDevice(dispositivos_video[comboBox_dispositivo.SelectedIndex].MonikerString);
                    fonte_video.NewFrame += new NewFrameEventHandler(VideoNovoFrame);
                    fonte_video.Start();
                    //statusStrip_barra.Text = "Executando dispositivo";
                    button_iniciar.Text = "Parar";
                    comboBox_dispositivo.Enabled = false;
                    //label_nome.Text = dispositivos_video[comboBox_camera.SelectedIndex].ToString();

                }
                else
                {
                    //statusStrip_barra.Text = "Error: Não encontrado dispositivo";
                }

            }
            else
            {
                if (fonte_video != null)// || fonte_video.IsRunning)
                {
                    TerminarFonteVideo();
                    //statusStrip_barra.Text = "Dispositivo Terminado";
                    //button_iniciar.Text = "Iniciar";
                    comboBox_dispositivo.Enabled = true;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button_iniciar.Text == "Parar")
            {
                button_iniciar_Click(sender, e);
            }
        }

        void button_salvar_Click(object sender, EventArgs e)
        {
            this.pictureBox_foto.Image.Save("D:/imagem.jpeg");

            //using (Bitmap b = new Bitmap(this.pictureBox_imagem.Width, this.pictureBox_imagem.Height))
            //{
            //    this.pictureBox_imagem.DrawToBitmap(b, this.pictureBox_imagem.Bounds);
            //    b.Save("D:/imagem.bmp");
            //}
        }
    }
}
