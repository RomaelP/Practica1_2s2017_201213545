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
                TB1.Text = File.ReadAllText(opd.FileName);
                aXML.analizadorXML(TB1.Text);
                
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
            //etiquetaCargando.Text = "Enviando...";
            int contEntregado = 0;
            
                foreach (var cola in listaCola)
                {
                    try{
                        using(var cliente = new WebClient())
                        {
                            var vEnviar = new NameValueCollection();
                            vEnviar["inorden"] = cola.mensaje;
                    
                            var respuestaMetodo = cliente.UploadValues("http://" + cola.ip + ":5000/mensaje", vEnviar);
                            contEntregado++;
                            var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                            MessageBox.Show("Mensaje Enivado a: "+contEntregado+" Nodos","EDD",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            //etiquetaCargando.Text="";
                            Console.WriteLine("****"+respuestaConvertidaString+" "+contEntregado); 
                    }
                    } catch(Exception x){
                        Console.WriteLine(x);
                }
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
