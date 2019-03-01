using Sistema.Dominio;
using Sistema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Aplicacao
{
    public class ClienteAplicacao
    {
        private readonly IRepositorio<Clientes> repositorio;

        public ClienteAplicacao(IRepositorio<Clientes> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Clientes cliente)
        {
            repositorio.Salvar(cliente);
        }

        public void Excluir(Clientes cliente)
        {
            repositorio.Excluir(cliente);
        }

        public IEnumerable<Clientes> ListarTodos()
        {

            return repositorio.ListarTodos();
        }

        public Clientes ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
