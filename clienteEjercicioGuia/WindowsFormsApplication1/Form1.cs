using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Necesario para hacer operaciones cross-thread que se supone que son illegales, hay una funcion y todo para desactivarla que guapo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void AtenderServidor ()
        {
            while (true) {

                //Recibimos mensage del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]); //Conseguimos la cabezera que nos identificara
                string mensaje = trozos[1].Split('\0')[0];

                switch (codigo) {

                    case 1:    //Respuesta a longitud
                        MessageBox.Show("La longitud de tu nombre es: " + mensaje);
                        break;

                    case 2:     //Respuesta a si mi nombre es bonito
                        if (mensaje == "SI")
                            MessageBox.Show("Tu nombre ES bonito.");
                        else
                            MessageBox.Show("Tu nombre NO es bonito. Lo siento.");
                        break;

                    case 3:     //Quiere saber si es alto
                        MessageBox.Show(mensaje);
                        break;
                          
                    case 4:    //REspuesta a si es palindromo
                        if (mensaje == "SI")
                            MessageBox.Show("Tu nombre ES Palindromo.");
                        else
                            MessageBox.Show("Tu nombre NO es Palindromo. Lo siento.");
                        break;

                    case 5:   //Quiere saber su nomber en mayusculas
                        MessageBox.Show(mensaje);
                        break;

                    case 6:  //Notificacion de cuantos servicios llevamos
                        contlbl.Text = mensaje;
                        break;
                }
            }
        }
        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
            }

            catch (SocketException )
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //Poner en marcha el thread que atiende mensajes del servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitud.Checked)
            {
                // Quiere saber la longitud
                string mensaje = "1/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (Bonito.Checked)
            {
                    // Quiere saber si el nombre es bonito
                    string mensaje = "2/" + nombre.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);                 
            }
            else if (Alto.Checked)
            {
                    //Quiere saber si es alto
                    string mensaje = "3/" + nombre.Text + "/" + Altura.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
            }
            else if (Palindromo.Checked)
            {
                //Quiere saber si su nombre es palindromo
                string mensaje = "4/" + nombre.Text;
                //Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if(mayusculas.Checked)
            {
                //Quiere devolver su nomber en mayuscula
                string mensaje = "5/" + nombre.Text;
                //Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
         }

        private void desconectar_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexion
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            
            //Nos deconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
    }
}
 
