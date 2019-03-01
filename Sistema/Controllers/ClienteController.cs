using Sistema.Aplicacao;
using Sistema.Dominio;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteAplicacao appCliente;

        public ClienteController()
        {
            appCliente = ClienteAplicacaoConstrutor.ClienteApEF();
        }

        // GET: Cliente
        public ActionResult ListaClientes()
        {
            var listaClientes = appCliente.ListarTodos();
            return View(listaClientes);
        }

        public ActionResult CadastrarCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarCliente(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                appCliente.Salvar(cliente);
                return RedirectToAction("ListaClientes");
            }

            return View(cliente);
        }

        public ActionResult EditarCliente(string id)
        {
            var cliente = appCliente.ListarPorId(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        public ActionResult EditarCliente(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                appCliente.Salvar(cliente);
                return RedirectToAction("ListaClientes");
            }

            return View(cliente);
        }

        public ActionResult DetalhesCliente(string id)
        {
            var cliente = appCliente.ListarPorId(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        public ActionResult ExcluirCliente(string id)
        {
            var cliente = appCliente.ListarPorId(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("ExcluirCliente")]
        public ActionResult ExcluirConfirmado(string id)
        {
            var cliente = appCliente.ListarPorId(id);
            appCliente.Excluir(cliente);
            return RedirectToAction("ListaClientes");
        }
    }
}