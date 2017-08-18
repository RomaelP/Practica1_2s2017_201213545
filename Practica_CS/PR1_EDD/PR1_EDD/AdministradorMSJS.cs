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
    }
}
