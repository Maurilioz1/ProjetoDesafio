using Sistema.Dominio;
using Sistema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.RepositorioEF
{
    public class ClienteRepositorioEF : IRepositorio<Clientes>
    {
        private readonly BDCliente bd;

        public ClienteRepositorioEF()
        {
            bd = new BDCliente();
        }

        public void Excluir(Clientes entidade)
        {
            var clienteExcluir = bd.clientes.First(x => x.id == entidade.id);
            bd.Set<Clientes>().Remove(clienteExcluir);
            bd.SaveChanges();
        }

        public Clientes ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return bd.clientes.First(x => x.id == idInt);
        }

        public IEnumerable<Clientes> ListarTodos()
        {
            return bd.clientes;
        }

        public void Salvar(Clientes entidade)
        {
            if (entidade.id > 0)
            {
                var usuarioAlterar = bd.clientes.First(x => x.id == entidade.id);
                usuarioAlterar.razaoSocial = entidade.razaoSocial;
                usuarioAlterar.nomeFantasia = entidade.nomeFantasia;
                usuarioAlterar.cnpj = entidade.cnpj;
                usuarioAlterar.endereço = entidade.endereço;
                usuarioAlterar.numero = entidade.numero;
                usuarioAlterar.bairro = entidade.bairro;
                usuarioAlterar.complemento = entidade.complemento;
                usuarioAlterar.municipio = entidade.municipio;
                usuarioAlterar.cep = entidade.cep;
            }
            else
            {
                bd.clientes.Add(entidade);
            }

            bd.SaveChanges();
        }
    }
}
