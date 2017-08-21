using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_EDD
{
    public partial class AdministradorMSJS : Form
    {
        public AdministradorMSJS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RespuestasMensajes RM1 = new RespuestasMensajes();
            RM1.Show();
        }

        private void BEnviarM_Click(object sender, EventArgs e)
        {
            EnviarMensaje EnviarMsj = new EnviarMensaje();
            EnviarMsj.Show();
        }
        
        private void BAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BVerC_Click(object sender, EventArgs e)
        {
            ColaMensajes CLM1 = new ColaMensajes();
            CLM1.Show();
            ///codigo para mandar a llamar a la lista que contenga los mensajes recibidos sin mostrar ninguno
        }
    }
}
