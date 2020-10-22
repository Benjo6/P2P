using System;

namespace Peers
{
    public class FileEndPoint
    {
        private string _ipAdresss;
        private int _portNumber;

        public FileEndPoint(string ipAdresss, int portNumber)
        {
            _ipAdresss = ipAdresss;
            _portNumber = portNumber;
        }

        public FileEndPoint()
        {
        }

        public int PortNumber { get => _portNumber; set => _portNumber = value; }
        public string IPAdresss { get => _ipAdresss; set => _ipAdresss = value; }

        public override string ToString()
        {
            return $"{PortNumber},{IPAdresss}";
        }
    }
}
