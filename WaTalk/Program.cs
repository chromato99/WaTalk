using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaTalk
{
    internal static class Program
    {
        internal static Socket server = null;
        internal static bool loop = true;
        private static Form1 mainForm = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Task.Run(receiveWork);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm = new Form1());
        }

        static void receiveWork()
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.0.209"), 12345);

            string message;


            server.Connect(ipep);
            Console.WriteLine("sent");

            while (loop)
            {
                using (Socket client = server.Accept())
                {
                    using (var stream = new NetworkStream(client))
                    using (var reader = new StreamReader(stream))
                    {
                        message = reader.ReadLine();
                        System.Diagnostics.Debug.WriteLine(message);
                        mainForm.outputWindow.Text = message;
                    }

                    client.Disconnect(false);
                }

                using (var delay = Task.Delay(100))
                    delay.Wait();

            }

            server.Disconnect(false);
            server.Dispose();

        }
    }
}
