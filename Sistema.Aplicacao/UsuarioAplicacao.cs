using Sistema.Dominio;
using Sistema.Dominio.contrato;
using System;
using System.Collections.Generic;


namespace Sistema.Aplicacao
{
    public class UsuarioAplicacao
    {
        private readonly IRepositorio<Usuarios> repositorio;

        public UsuarioAplicacao(IRepositorio<Usuarios> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Usuarios usuario)
        {
            repositorio.Salvar(usuario);
        }

        public void Excluir(Usuarios usuario)
        {
            repositorio.Excluir(usuario);
        }

        public IEnumerable<Usuarios> ListarTodos()
        {

            return repositorio.ListarTodos();
        }

        public Usuarios ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}