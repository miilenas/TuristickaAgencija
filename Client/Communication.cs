
using Common.Communication;
using Common.Domain;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text.Json;

namespace Client
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private JsonNetworkSerializer serializer;

        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                    instance = new Communication();
                return instance;
            }
        }

        public void Connect()
        {
            Close();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            serializer = new JsonNetworkSerializer(socket);
        }

        private T ReadResponseResult<T>(Response response) where T : class
        {
            if (!response.IsSuccess ||
                response.Result == null ||
                response.Result is JsonElement element && element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return serializer.ReadType<T>(response.Result);
        }

        private void EnsureConnected()
        {
            if (socket != null && serializer != null)
            {
                return;
            }

            try
            {
                Connect();
            }
            catch
            {
                Close();
                throw new Exception("Neuspesno povezivanje sa serverom");
            }
        }

        private Response SendRequest<T>(Operation operation, object argument = null) where T : class
        {
            EnsureConnected();

            try
            {
                Request request = new Request()
                {
                    Operation = operation,
                    Argument = argument
                };

                serializer.Send(request);
                Response response = serializer.Receive<Response>();
                response.Result = ReadResponseResult<T>(response);
                return response;
            }
            catch
            {
                Close();
                throw new Exception("Veza sa serverom je prekinuta. Pokrenite server i pokusajte ponovo.");
            }
        }

        public void Close()
        {
            try
            {
                socket?.Shutdown(SocketShutdown.Both);
            }
            catch
            {
            }

            try
            {
                socket?.Close();
            }
            catch
            {
            }

            socket = null;
            serializer = null;
        }

        internal Response Login(Agent agent)
        {
            return SendRequest<Agent>(Operation.Login, agent);
        }

        internal Response CreateRezervacija(Rezervacija rezervacija)
        {
            return SendRequest<Rezervacija>(Operation.CreateRezervacija, rezervacija);
        }

        internal Response SearchRezervacija(KriterijumiRezervacija kriterijum)
        {
            return SendRequest<List<Rezervacija>>(Operation.SearchRezervacija, kriterijum);
        }

        internal Response UpdateRezervacija(Rezervacija rezervacija)
        {
            return SendRequest<Rezervacija>(Operation.UpdateRezervacija, rezervacija);
        }

        internal Response UpdatePutnik(Putnik putnik)
        {
            return SendRequest<Putnik>(Operation.UpdatePutnik, putnik);
        }

        internal Response CreatePutnik(Putnik putnik)
        {
            return SendRequest<Putnik>(Operation.CreatePutnik, putnik);
        }

        internal Response DeletePutnik(Putnik putnik)
        {
            return SendRequest<Putnik>(Operation.DeletePutnik, putnik);
        }

        internal Response SearchPutnik(KriterijumPutnik kriterijum)
        {
            return SendRequest<List<Putnik>>(Operation.SearchPutnik, kriterijum);
        }

        internal Response UbaciLicenca(Licenca licenca)
        {
            return SendRequest<Licenca>(Operation.UbaciLicenca, licenca);
        }

        internal List<Putnik> VratiListuSviPutnik()
        {
            Response response = SendRequest<List<Putnik>>(Operation.VratiListuSviPutnik);
            return (List<Putnik>)response.Result;
        }

        internal List<Agent> VratiListuSviAgent()
        {
            Response response = SendRequest<List<Agent>>(Operation.VratiListuSviAgent);
            return (List<Agent>)response.Result;
        }

        internal List<Smestaj> VratiListuSviSmestaj()
        {
            Response response = SendRequest<List<Smestaj>>(Operation.VratiListuSviSmestaj);
            return (List<Smestaj>)response.Result;
        }

        internal List<Mesto> VratiListuSviMesto()
        {
            Response response = SendRequest<List<Mesto>>(Operation.VratiListuSviMesto);
            return (List<Mesto>)response.Result;
        }

        internal List<Rezervacija> VratiListuSviRezervacija()
        {
            Response response = SendRequest<List<Rezervacija>>(Operation.VratiListuSviRezervacija);
            return (List<Rezervacija>)response.Result;
        }
    }
}
