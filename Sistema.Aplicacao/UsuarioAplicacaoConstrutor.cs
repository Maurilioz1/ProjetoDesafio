using Sistema.RepositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Aplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioApEF()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioEF());
        }
    }
}
