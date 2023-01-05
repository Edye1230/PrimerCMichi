using Microsoft.AspNetCore.Mvc;
using TercerRestful.Models;

namespace TercerRestful.Controllers {

    [ApiController]/**/
    [Route("cliente")]/**/
    public class ClienteController : ControllerBase {

        [HttpGet]/**/
        [Route("getClientes")]/**/
        public dynamic getClientes() {

            List<ClienteModel> clientes = new List<ClienteModel> {
                new ClienteModel {
                    id = "1",
                    nombre = "Edye",
                    edad = "25",
                    email = "edye.1230@gmail.com"
                    },
                new ClienteModel {
                    id = "2",
                    nombre = "Rojer",
                    edad = "25",
                    email = "edye.1230@gmail.com"
                    }
            };

            return clientes;

            }

        [HttpGet]/**/
        [Route("getClientesByID")]/**/
        public dynamic getClientesByID(int codigo) {

            return new ClienteModel {
                id = codigo.ToString(),
                nombre = "Edye",
                edad = "25",
                email = "edye.1230@gmail.com"
                };
            }
            

    [HttpPost]
    [Route("cliente")]
    public dynamic postCliente(ClienteModel cliente) {
        cliente.id = "3";
        return new {
            succes = true,
            message = "cliente registrado",
            result = cliente
            };
        }
    }
}



