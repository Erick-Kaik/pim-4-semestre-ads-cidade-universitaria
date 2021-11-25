using HotelariaControle.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Servicos
{
    public class QuartosService
    {
        public RepositoryQuartos oRepositoryQuartos { get; set; }

        public QuartosService()
        {
            oRepositoryQuartos = new RepositoryQuartos();
        }
    }
}
