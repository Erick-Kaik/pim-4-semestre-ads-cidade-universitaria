using HotelariaControle.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Servicos
{
    public class HospedeService
    {
        public RepositoryHospede oRepositoryHospede { get; set; }
        
        public HospedeService()
        {
            oRepositoryHospede = new RepositoryHospede();
        }
    }
}
