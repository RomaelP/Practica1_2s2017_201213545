using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace PR1_EDD
{
    class AnalizadorJS
    {
        
        public static void Analizador(String CadenaTexto)
        {
            int EsInicio = 0; //el que va moviendo los hilos 
            int EsPrincipal = 0;
            char ConCadena;
            string Ip = "";
            string mask = "";
            string Nip = "";
            string Nmask = "";
            
            for (EsInicio = 0; EsInicio < CadenaTexto.Length; EsInicio++)
            {
                ConCadena = CadenaTexto[EsInicio];

                switch (EsPrincipal)
                {
                    case 0: 
                        switch (ConCadena)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                EsPrincipal = 0;
                                break;

                            case '{':
                                EsPrincipal = 0;
                                break;

                            case '}':
                                EsPrincipal = 6;
                                EsInicio = EsInicio - 1;
                                break;

                            case '"':
                                EsPrincipal = 1;
                                break;
                        }
                        break;//caso 0

                    case 1://nueva Ip
                        if (char.IsLetter(ConCadena) || ConCadena.Equals(':') || ConCadena.Equals('"') || ConCadena.Equals('{'))
                        {
                            EsPrincipal = 1;
                        }
                        else if (char.IsNumber(ConCadena) || ConCadena.Equals('.'))
                        {
                            Nip += ConCadena;
                            EsPrincipal = 1;
                        }
                        else if (ConCadena.Equals(','))
                        {
                            FormDashboard.CargarDatos("Vacio",Nip,"255.255.255.0");
                            Console.WriteLine("*****estoy probando y funciono la IP ES" + Nip);
                            varGlobales.IpACambiar = Nip;
                            EsPrincipal = 2;
                        }
                        break;//caso1

                    case 2://mask
                        if (char.IsLetter(ConCadena) || ConCadena.Equals(':') || ConCadena.Equals('"'))
                        {
                            EsPrincipal = 2;
                        }
                        else if (char.IsNumber(ConCadena) || ConCadena.Equals('.'))
                        {
                            Nmask += ConCadena;
                            EsPrincipal = 2;
                        }
                        else if (ConCadena.Equals(','))
                        {
                            EsPrincipal = 3;
                        }
                        break;//case 2

                    case 3://ip
                        if (char.IsLetter(ConCadena) || ConCadena.Equals(':') || ConCadena.Equals('"') || ConCadena.Equals('[') || ConCadena.Equals('{'))
                        {
                            EsPrincipal = 3;
                        }
                        else if (char.IsNumber(ConCadena) || ConCadena.Equals('.'))
                        {
                            Ip += ConCadena;
                            EsPrincipal = 3;
                        }
                        else if (ConCadena.Equals(','))
                        {
                            EsPrincipal = 4;
                        }
                        break;//case 3

                    case 4://mask
                        if (char.IsLetter(ConCadena) || ConCadena.Equals(':') || ConCadena.Equals('"') || ConCadena.Equals('}'))
                        {
                            EsPrincipal = 4;
                        }
                        else if (char.IsNumber(ConCadena) || ConCadena.Equals('.'))
                        {
                            mask += ConCadena;
                            EsPrincipal = 4;
                        }
                        else if (ConCadena.Equals(','))
                        {
                            EsPrincipal = 5;
                        }
                        else if (ConCadena.Equals(']'))
                        {
                            EsPrincipal = 6;
                        }
                        break;

                    case 5://guardar en la lista
                        //MessageBox.Show(Ip,"EDD",MessageBoxButtons.OK);  //Linea de mandar a guarda en la lista
                        FormDashboard.CargarDatos("Vacio", Ip, mask);
                        Ip = "";
                        mask = "";
                        EsPrincipal = 3;
                        break;

                    case 6://estado final
                        Ip = "";
                        mask = "";
                        EsPrincipal = 0;
                        break;
                }
            }
        }

        public static void cambiarIp(string dirIP, string mascara)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach(ManagementObject objMO in objMOC)
            {
                if((bool) objMO["IPEnabled"])
                {
                    try{
                        ManagementBaseObject cambiarIP;
                        ManagementBaseObject newIP = objMO.GetMethodParameters("EnabledStatic");
                        newIP["IPAddress"] = new string[] { dirIP };
                        newIP["SubnetMask"] = new string[] { mascara };
                        cambiarIP = objMO.InvokeMethod("EnableStatic",newIP,null);
                    }catch (Exception) {throw;}
                }
            }
        }

        public void analizadorXML(string cadena)
        {
            int inicioestado = 0;
            int estadoprincipal = 0;
            char cadenaconcatenar;
            string ip = "";
            string mensaje = "";

            for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];

                switch (estadoprincipal)
                {
                    case 0:
                        switch (cadenaconcatenar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                estadoprincipal = 0;
                                break;

                            case '<':
                                estadoprincipal = 1;
                                break;
                        }
                        break;

                    case 1: //Mensaje Nodo
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('<') || cadenaconcatenar.Equals('>') || cadenaconcatenar.Equals('/'))
                        {
                            if (cadenaconcatenar.Equals('I'))
                            {
                                estadoprincipal = 2;
                            }
                            else
                            {
                                estadoprincipal = 1;
                            }
                        }
                        break;

                    case 2://Ip - Numeros
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('<') || cadenaconcatenar.Equals('>'))
                        {
                            if (cadenaconcatenar.Equals('t'))
                            {
                                estadoprincipal = 3;
                            }
                            else
                            {
                                estadoprincipal = 2;
                            }
                        }
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            ip += cadenaconcatenar;
                            estadoprincipal = 2;
                        }
                        else if (cadenaconcatenar.Equals('/'))
                        {
                            if (ip != "" || mensaje != "")
                            {
                                EnviarMensaje.AgregaraCola(ip, mensaje);
                                ip = "";
                                mensaje = "";
                            }
                            estadoprincipal = 2;
                        }
                        break;

                    case 3: //texto
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('>'))
                        {
                            estadoprincipal = 3;
                        }
                        else if (cadenaconcatenar.Equals('('))
                        {
                            mensaje += cadenaconcatenar;
                            estadoprincipal = 4;
                        }
                        break;

                    case 4: //TextoMensaje
                        if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('+') || cadenaconcatenar.Equals('/') || cadenaconcatenar.Equals('-') || cadenaconcatenar.Equals('*') || cadenaconcatenar.Equals('(') || cadenaconcatenar.Equals(')'))
                        {
                            mensaje += cadenaconcatenar;
                            estadoprincipal = 4;
                        }
                        else if (cadenaconcatenar.Equals('<'))
                        {
                            if (ip != "" || mensaje != "")
                            {
                                EnviarMensaje.AgregaraCola(ip, mensaje);
                                ip = "";
                                mensaje = "";
                            }
                            estadoprincipal = 5;
                        }
                        break;

                    case 5: //Mensajes
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('>') || cadenaconcatenar.Equals('/'))
                        {
                            estadoprincipal = 5;
                        }
                        else if (cadenaconcatenar.Equals('<'))
                        {
                            estadoprincipal = 1;
                        }
                        break;
                }
            }
        }
    }

}
