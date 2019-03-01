using Sistema.RepositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Aplicacao
{
    public class ClienteAplicacaoConstrutor
    {
        public static ClienteAplicacao ClienteApEF()
        {
            return new ClienteAplicacao(new ClienteRepositorioEF());
        }
    }
}
