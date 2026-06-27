using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class JsonNetworkSerializer
    {
        private readonly Socket s;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonNetworkSerializer(Socket s)
        {
            this.s = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
        }

        public void Send(object z)
        {
            try
            {
                writer.WriteLine(JsonSerializer.Serialize(z));
            }
            catch (IOException)
            {
                throw new Exception("IOE Neuspesno povezivanje sa serverom");
            }
            catch (SocketException)
            {
                throw new Exception("Neuspesno povezivanje sa serverom");
            }
        }

        public T Receive<T>()
        {
            try
            {
                string json = reader.ReadLine();

                if (json == null)
                    throw new Exception("Neuspesno povezivanje sa serverom");

                return JsonSerializer.Deserialize<T>(json);
            }
            catch (IOException)
            {
                throw new Exception("Neuspesno povezivanje sa serverom");
            }
            catch (SocketException)
            {
                throw new Exception("Neuspesno povezivanje sa serverom");
            }

        }

        public T ReadType<T>(object podaci) where T : class
        {
            return podaci == null ? null : JsonSerializer.Deserialize<T>((JsonElement)podaci);
        }

        public void Close()
        {
            stream.Close();
            reader.Close();
            writer.Close();
        }
    }
}
