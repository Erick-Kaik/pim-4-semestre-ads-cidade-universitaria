using HotelariaControle.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Servicos
{
    public class UsuarioService
    {
        public RepositoryUsuario oRepositoryUsuario { get; set; }
        public UsuarioService()
        {
            oRepositoryUsuario = new RepositoryUsuario();
        }
    }
}
