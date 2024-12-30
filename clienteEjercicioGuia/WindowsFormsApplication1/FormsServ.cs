using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormsServ : Form
    {
        public FormsServ()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitud.Checked)
           {
                //Quiere saber la longitud
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
    }
}
