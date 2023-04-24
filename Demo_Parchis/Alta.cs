using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;


namespace Demo_Parchis
{
    public partial class Alta : Form
    {
        Socket server;
        public Alta()
        {
            InitializeComponent();
        }

        int logged = 0;
        private void Alta_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DarseAlta_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            if (logged == 0)
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("192.168.56.101");
                IPEndPoint ipep = new IPEndPoint(direc, 9051);


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.LightGreen;
                    MessageBox.Show("Conectado");


                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
                logged = 1;
            }
            
            else if (nuevo_usuario != null && nuevo_contra != null)
            {
                string mensaje_nuevo = "1/" + nuevo_usuario.Text + "/" + nuevo_contra.Text;
                // Enviamos al servidor el nombre el user y la contraseña
                byte[] msg_nuevo = System.Text.Encoding.ASCII.GetBytes(mensaje_nuevo);
                server.Send(msg_nuevo);

                //Recibimos la respuesta del servidor
                byte[] msg2_nuevo = new byte[80];
                server.Receive(msg2_nuevo);
                mensaje_nuevo = Encoding.ASCII.GetString(msg2_nuevo).Split('\0')[0];
                MessageBox.Show(mensaje_nuevo);

                string mensaje = "6/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[100];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                menu.MuestraConectados(mensaje);
                
            }
            //Una vez registrados accedemos al juego 
            Demo demo = new Demo();
            demo.Show();
        }
    }
}
