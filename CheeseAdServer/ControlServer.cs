using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using CheeseAdServer.utils;  

namespace CheeseAdServer {
    class ControlServer : AbstractThread { 

        private static String TAG               = "Control Server"; 
        private static int DEFAULT_PORT         = 5678;
        private TcpListener listener            = null;

        /**
         * Use this thread to communicate with client, handle 
         * client request and response message.
         * 
         */
        public class ControlThread : AbstractThread {
            private static String TAG       = "ControlThread";
            private Socket socket           = null;

            public override void run() {
                // TODO Response client request
            }

            public ControlThread(Socket s) {
                this.socket = s;
            }
        }
        
        public override void run() {
            try {
                /* Initializes the Listener */
                listener = new TcpListener(IPAddress.Any, DEFAULT_PORT);

                // Start Listening at the specified port
                listener.Start();
                Log.d(TAG, "The server is running at port " + DEFAULT_PORT);

                // Loop accept client connect request
                while (true) {
                    Log.d(TAG, "Waiting for connection...");
                    Socket s = listener.AcceptSocket();
                    Log.d(TAG, "Connection accepted from " + s.RemoteEndPoint);
                    // TODO: Create new thread handle the new socket
                    s.Close();
                }

                /*
                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Recieved...");
                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("The string was recieved by the server."));
                Console.WriteLine("\nSent Acknowledgement");
                */
                /* clean up */
                //s.Close();

            } catch (ArgumentNullException e) {
            } catch (SocketException e) {
            } finally {
                if (listener != null)
                    listener.Stop();
            }

        }
    }
}
