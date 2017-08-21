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
using System.Net;
using System.Collections.Specialized;
using System.Management;

namespace PR1_EDD
{
    public partial class FormDashboard : Form
    {
        static List<Nodo> listaNodos;
        static int Ncontador;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void BotonCJ_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
            
        }

        private void AbrirArchivo()//metodo para abrir el archivo JSON, llama al analizador y obtienen los valores del archivo
        {
            etiqueta1.Text = "CARGANDO DATOS...";
            listaNodos = new List<Nodo>();
            Ncontador = 1; 

            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Archivos de Texto (*.txt) | *.txt";
            opd.InitialDirectory = "Escritorio";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AnalizadorJS js = new AnalizadorJS();
                AnalizadorJS.Analizador(File.ReadAllText(opd.FileName));  
            }
            else {
                MessageBox.Show("Ocurrio un Error al Abrir el Archivo", "EDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                etiqueta1.Text = "NO SE CARGARON LOS DATOS";
            }
            
            LLenarIPS();//llamada al metod llenarIPS
            //aqui la llamada al timer
            MostrarLista();//llamada al metodo para mostrar datos en el dashboard
            MetodoPOSTLista();//manda los elementos al WS para guardar en una lista en Python   
            EtiquetaIp.Text = "Nodo Actual: "+varGlobales.IpACambiar+" - 201213545";
            setIP(varGlobales.IpACambiar,"255.255.255.0");

            timer1.Start();
            etiqueta1.Text = "DATOS CARGADOS";
        }

        public void MetodoPOSTLista()//metodo POST manda parametros a guardar a la lista Python
        {
            try
            {
                foreach (var nod in listaNodos)
                {
                    using (var cliente = new WebClient())
                    {
                        var vEnviar = new NameValueCollection();
                        vEnviar["carnet"] = nod.carnet;
                        vEnviar["ip"] = nod.ip;
                        vEnviar["mascara"] = nod.mascara;
                        //Console.WriteLine(nod.carnet +"");    
                    }
                }
            }
            catch (Exception y) 
            {
                Console.WriteLine(y);
            }
        }

        public static void CargarDatos(string Carnet, string Ip, string mask)//manda a cargar lista de datos a la lista en C# 
        {
            Nodo nodo = new Nodo();
            nodo.carnet = Carnet;
            nodo.ip = Ip;
            nodo.mascara = mask;
            nodo.nodo = "Nodo"+Ncontador;
            nodo.id = Ncontador;
            if ((Ncontador % 2) == 0)
            {
                nodo.estado = "si";
            }
            else {
                nodo.estado = "no";
            }
            listaNodos.Add(nodo);
            Ncontador++;
        }
        private void Btrs_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void MostrarLista()//Metodo para mandar al dataviewg... y manda a guardar a la lista en python
        {
            int contador = 1;
            dgv1.Rows.Clear();
            
            foreach (var nod in listaNodos) 
            {
                contador = dgv1.Rows.Add();
                dgv1.Rows[contador].Cells["Nodo"].Value = nod.nodo;
                dgv1.Rows[contador].Cells["ip"].Value = nod.ip;
                dgv1.Rows[contador].Cells["carnet"].Value = nod.carnet;
                dgv1.Rows[contador].Cells["estado"].Value = nod.estado;  
            }
        }

        private static string conGet(string ip)//metodo GET llamada al WS de todos los nodos para obtener las ip
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var RespuestaIp = cliente.DownloadString("http://" + ip + ":5000/conectado");
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

        public static void LLenarIPS() //metod que llama a conGet (arriba) y devuelve al estado On u Off depende del carnet
        {
            foreach (var nod in listaNodos)
            {
                string valuar = conGet(nod.ip);
                nod.carnet = valuar;
                Console.WriteLine(nod.carnet +" agregado al nodo ");
                if (nod.carnet != "")
                {
                    nod.estado = "ON";
                }
                else 
                {
                    nod.estado = "OFF";
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)//timer para ejecutar la llamada a cada 20 segundos
        {
            LLenarIPS();
            MostrarLista();//llamada al metodo para mostrar datos en el dashboard
            MetodoPOSTLista();
        }

        public static void setIP(string ip_add, string subnet_mask)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP = objMO.GetMethodParameters("EnabledStatic");
                        newIP["IPAddress"] = new string[] { ip_add };
                        newIP["SubnetMask"] = new string[] {subnet_mask};
                        setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                    }
                    catch (Exception exp) {
                        Console.WriteLine(exp);
                    }
                }
            }
        }
    }

    public class Nodo//clase nodo local, C#
    {
        public string nodo { get; set; }
        public string ip { get; set; }
        public string carnet { get; set; }
        public string mascara { get; set; }
        public string estado { get; set; }
        public int id { get; set; }
    }
}
