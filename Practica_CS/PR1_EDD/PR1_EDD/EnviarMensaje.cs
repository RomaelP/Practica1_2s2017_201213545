using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_EDD
{
    public partial class EnviarMensaje : Form
    {
        static List<NodoCola> listaCola;
        static int contadorNodosCola;
        public EnviarMensaje()
        {
            InitializeComponent();
            
        }

        private void BCXML_Click(object sender, EventArgs e)
        {
            listaCola = new List<NodoCola>();
            contadorNodosCola=1;
            
            OpenFileDialog opd = new OpenFileDialog();//inica el codigo para abrir un archivo XML
            opd.Filter = "Archivos de texto (*.txt) | *.txt";
            opd.InitialDirectory = "Escritorio";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AnalizadorJS aXML = new AnalizadorJS();
                aXML.analizadorXML(File.ReadAllText(opd.FileName));
                TB1.Text = File.ReadAllText(opd.FileName);
            }
            else {
                MessageBox.Show("Ocurrio un Error al Abrir el Archivo", "EDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BEMSJ.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                foreach (var cola in listaCola)
                {
                    using(var cliente = new WebClient())
                    {
                    var vEnviar = new NameValueCollection();
                    vEnviar["inorden"] = cola.mensaje;
                    var respuestaMetodo = cliente.UploadValues("http://" + cola.ip + ":5000/mensaje", vEnviar);
                        var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                        Console.WriteLine(respuestaConvertidaString); 
                    }
                }
                MessageBox.Show("Mesaje Enviado", "EDD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception x)
            {
                MessageBox.Show("Mesaje No Enviado", "EDD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(x);
            }
        }

     public static void AgregaraCola(string ip, string mensaje)//agregar un nuevo nodo a la cola
        {
            NodoCola nodo = new NodoCola();
            nodo.ip = ip;
            nodo.mensaje = mensaje;

            if (mensaje != "")
            {
                foreach (var cola in listaCola)
                {
                    if (cola.mensaje == "")
                    {
                        cola.mensaje = mensaje;
                    }
                }
            }
            else
            {
                listaCola.Add(nodo);
                contadorNodosCola++;
            }
        }
    }

    public class NodoCola
    {
        public string ip { get; set; }
        public string mensaje { get; set; }
    }
}
