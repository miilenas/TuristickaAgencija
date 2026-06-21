
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

        internal Response Login(Agent agent)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                Argument = agent
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Agent>(response);
            return response;
        }

        internal Response CreateRezervacija(Rezervacija rezervacija)
        {
            Request request = new Request()
            {
                Operation = Operation.CreateRezervacija,
                Argument = rezervacija
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Rezervacija>(response);
            return response;
        }

        internal Response SearchRezervacija(KriterijumiRezervacija kriterijum)
        {
            Request request = new Request()
            {
                Operation = Operation.SearchRezervacija,
                Argument = kriterijum
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<List<Rezervacija>>(response);
            return response;
        }

        internal Response UpdateRezervacija(Rezervacija rezervacija)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdateRezervacija,
                Argument = rezervacija
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Rezervacija>(response);
            return response;
        }

        internal Response UpdatePutnik(Putnik putnik)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdatePutnik,
                Argument = putnik
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Putnik>(response);
            return response;
        }

        internal Response CreatePutnik(Putnik putnik)
        {
            Request request = new Request()
            {
                Operation = Operation.CreatePutnik,
                Argument = putnik
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Putnik>(response);
            return response;
        }

        internal Response DeletePutnik(Putnik putnik)
        {
            Request request = new Request()
            {
                Operation = Operation.DeletePutnik,
                Argument = putnik
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Putnik>(response);
            return response;
        }

        internal Response SearchPutnik(KriterijumPutnik kriterijum)
        {
            Request request = new Request()
            {
                Operation = Operation.SearchPutnik,
                Argument = kriterijum
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<List<Putnik>>(response);
            return response;
        }

        internal Response UbaciLicenca(Licenca licenca)
        {
            Request request = new Request()
            {
                Operation = Operation.UbaciLicenca,
                Argument = licenca
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Result = ReadResponseResult<Licenca>(response);
            return response;
        }

        internal List<Putnik> VratiListuSviPutnik()
        {
            Request request = new Request()
            {
                Operation = Operation.VratiListuSviPutnik
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Putnik>>(response.Result);
        }

        internal List<Agent> VratiListuSviAgent()
        {
            Request request = new Request()
            {
                Operation = Operation.VratiListuSviAgent
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Agent>>(response.Result);
        }

        internal List<Smestaj> VratiListuSviSmestaj()
        {
            Request request = new Request()
            {
                Operation = Operation.VratiListuSviSmestaj
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Smestaj>>(response.Result);
        }

        internal List<Mesto> VratiListuSviMesto()
        {
            Request request = new Request()
            {
                Operation = Operation.VratiListuSviMesto
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Mesto>>(response.Result);
        }

        internal List<Rezervacija> VratiListuSviRezervacija()
        {
            Request request = new Request()
            {
                Operation = Operation.VratiListuSviRezervacija
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Rezervacija>>(response.Result);
        }
    }
}
