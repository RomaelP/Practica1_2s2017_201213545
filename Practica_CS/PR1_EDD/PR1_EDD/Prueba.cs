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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                using (var cliente = new WebClient())
                {
                    var RespuestaIp = cliente.DownloadString("http://192.168.0.21:5000/operarExpresion");
                    Console.WriteLine(RespuestaIp);
                    EtiquetaPrueba.Text = RespuestaIp;
                }
            }
            catch (Exception z) { 
                Console.WriteLine(z); }
        }
    }
}
