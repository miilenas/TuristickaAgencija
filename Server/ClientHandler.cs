using Common.Communication;
using Common.Domain;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {

        private JsonNetworkSerializer serializer;
        private Socket socket;
        private readonly Server server;

        public ClientHandler(Socket socket, Server server)
        {
            this.socket = socket;
            this.server = server;
            serializer = new JsonNetworkSerializer(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = serializer.Receive<Request>();
                    Response r = ProcessRequest(req);
                    serializer.Send(r);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>SE: "+ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>IOE: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            finally
            {
                if (socket.Connected)
                {
                    socket.Close();
                }
                server.RemoveClient(this);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controler.Instance.Login(serializer.ReadType<Agent>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.CreateRezervacija:
                        response.Result = Controler.Instance.CreateRezervacija(serializer.ReadType<Rezervacija>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.SearchRezervacija:
                        response.Result = Controler.Instance.SearchRezervacija(serializer.ReadType<KriterijumiRezervacija>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.UpdateRezervacija:
                        response.Result = Controler.Instance.UpdateRezervacija(serializer.ReadType<Rezervacija>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.UpdatePutnik:
                        response.Result = Controler.Instance.UpdatePutnik(serializer.ReadType<Putnik>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.DeletePutnik:
                        Controler.Instance.DeletePutnik(serializer.ReadType<Putnik>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.SearchPutnik:
                        response.Result = Controler.Instance.SearchPutnik(serializer.ReadType<KriterijumPutnik>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.CreatePutnik:
                        response.Result = Controler.Instance.CreatePutnik(serializer.ReadType<Putnik>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.UbaciLicenca:
                        response.Result = Controler.Instance.UbaciLicenca(serializer.ReadType<Licenca>(request.Argument));
                        response.IsSuccess = true;
                        break;
                    case Operation.VratiListuSviPutnik:
                        response.Result = Controler.Instance.VratiListuSviPutnik();
                        response.IsSuccess = true;
                        break;
                    case Operation.VratiListuSviAgent:
                        response.Result = Controler.Instance.VratiListuSviAgent();
                        response.IsSuccess = true;
                        break;
                    case Operation.VratiListuSviSmestaj:
                        response.Result = Controler.Instance.VratiListuSviSmestaj();
                        response.IsSuccess = true;
                        break;
                    case Operation.VratiListuSviMesto:
                        response.Result = Controler.Instance.VratiListuSviMesto();
                        response.IsSuccess = true;
                        break;
                    case Operation.VratiListuSviRezervacija:
                        response.Result = Controler.Instance.VratiListuSviRezervacija();
                        response.IsSuccess = true;
                        break;
                    default: throw new Exception("Nepoznat zahtev");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greska na serveru: " + ex.Message);
                response.IsSuccess = false;
                response.ExceptionMessage = ex.Message;
            }
            return response;
        }

        internal void CloseSocket()
        {
            socket.Close();
        }
    }
}

