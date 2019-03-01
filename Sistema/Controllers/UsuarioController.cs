using Sistema.Aplicacao;
using Sistema.Dominio;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioAplicacao appUsuario;

        public UsuarioController()
        {
            appUsuario = UsuarioAplicacaoConstrutor.UsuarioApEF();
        }

        // GET: Usuario
        public ActionResult ListaUsuarios()
        {
            var listaUsuarios = appUsuario.ListarTodos();
            return View(listaUsuarios);
        }

        public ActionResult CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarUsuario(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                appUsuario.Salvar(usuario);
                return RedirectToAction("ListaUsuarios");
            }

            return View(usuario);
        }

        public ActionResult EditarUsuario(string id)
        {
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        public ActionResult EditarUsuario(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                appUsuario.Salvar(usuario);
                return RedirectToAction("ListaUsuarios");
            }

            return View(usuario);
        }

        public ActionResult DetalhesUsuario(string id)
        {
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult ExcluirUsuario(string id)
        {
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost, ActionName("ExcluirUsuario")]
        public ActionResult ExcluirConfirmado(string id)
        {
            var usuario = appUsuario.ListarPorId(id);
            appUsuario.Excluir(usuario);
            return RedirectToAction("ListaUsuarios");
        }
    }
}