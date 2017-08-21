using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;
using System.Net;
using System.Collections.Specialized;
using System.Net.Sockets;
using System.Management;

namespace PR1_EDD
{
    public partial class FormMN : Form
    {
        public FormMN()
        {
            InitializeComponent();
        }

        private void BotonVD_Click(object sender, EventArgs e)
        {
            FormDashboard FD1 = new FormDashboard();
            FD1.Show();
            //this.Hide();
            //codigo para llamar a la siguiente ventana
        }

        private void BotonAM_Click(object sender, EventArgs e)
        {          
            AdministradorMSJS ADM1 = new AdministradorMSJS();
            ADM1.Show();
            //this.Hide();
        }

        private void BotonVR_Click(object sender, EventArgs e)
        {
            VerReportes VR1 = new VerReportes();
            VR1.Show();
        }

        public string conGET(string ip)
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var RespuestaIp = cliente.DownloadString("http://"+ip+":5000/conectado");
                    Console.WriteLine(RespuestaIp);
                    return RespuestaIp;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prueba pb = new Prueba();
                pb.Show();
        }
    }
}