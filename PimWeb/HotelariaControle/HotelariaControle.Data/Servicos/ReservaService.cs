using HotelariaControle.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Servicos
{
    public class ReservaService
    {
        public RepositoryReserva oRepositoryReserva { get; set; }

        public ReservaService()
        {
            oRepositoryReserva = new RepositoryReserva();
        }
    }
}
