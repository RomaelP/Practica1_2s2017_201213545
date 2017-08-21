using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_EDD
{
    public partial class ColaMensajes : Form
    {
        public ColaMensajes()
        {
            InitializeComponent();
            escribirEnEtiqueta();
        }

        private void escribirEnEtiqueta()
        {
            try
            {
                using (var cliente1 = new WebClient())
                {
                    var RespuestaTam = cliente1.DownloadString("http://192.168.0.21:5000/SizeCola");
                    Console.WriteLine(RespuestaTam);
                    etiTam.Text = RespuestaTam;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BOperar_Click(object sender, EventArgs e)
        {
            
            try {
                using (var cliente = new WebClient())
                {
                    var RespuestaIp = cliente.DownloadString("http://192.168.0.21:5000/operarExpresion");
                    Console.WriteLine(RespuestaIp);
                    string[] valores = RespuestaIp.Split('$');
                    txbCarnet.Text=valores[0];
                    txbInorden.Text =valores[3];
                    txbIp.Text = valores[1];
                    txbOperacion.Text= valores[2];
                }
            }
            catch (Exception z) { 
                Console.WriteLine(z); }
        
        }
    }
}
