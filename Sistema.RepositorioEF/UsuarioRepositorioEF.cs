using Sistema.Dominio;
using Sistema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.RepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuarios>
    {
        private readonly BDUsuario bd;

        public UsuarioRepositorioEF()
        {
            bd = new BDUsuario();
        }

        public void Excluir(Usuarios entidade)
        {
            var usuarioExcluir = bd.usuarios.First(x => x.id == entidade.id);
            bd.Set<Usuarios>().Remove(usuarioExcluir);
            bd.SaveChanges();
        }

        public Usuarios ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return bd.usuarios.First(x => x.id == idInt);
        }

        public IEnumerable<Usuarios> ListarTodos()
        {
            return bd.usuarios;
        }

        public void Salvar(Usuarios entidade)
        {
            if (entidade.id > 0)
            {
                var usuarioAlterar = bd.usuarios.First(x => x.id == entidade.id);
                usuarioAlterar.nomeCompleto = entidade.nomeCompleto;
                usuarioAlterar.apelido = entidade.apelido;
                usuarioAlterar.email = entidade.email;
                usuarioAlterar.telefone = entidade.telefone;
            }
            else
            {
                bd.usuarios.Add(entidade);
            }

            bd.SaveChanges();
        }
    }
}
