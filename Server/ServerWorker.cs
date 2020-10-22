using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class ServerWorker
    {
        public void Start()
        {
            TcpListener server = new TcpListener(5001);


            String path = @" << some location on the disk >> ";

            if (Directory.Exists(path))
            {
                foreach (string filename in Directory.GetFiles(path))
                {
                    
                }
            }
            

            
        }
    }
}
