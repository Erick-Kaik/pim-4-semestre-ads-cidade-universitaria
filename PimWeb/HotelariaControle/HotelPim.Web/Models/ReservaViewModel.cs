using HotelariaControle.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelPim.Web.Models
{
    public class ReservaViewModel
    {
        public Reservas oReserva { get; set; }
        public Quartos oQuartos { get; set; }
        public Usuarios oUsuario { get; set; }

        public string NomeUsuarioLogin { get; set; }
        public string Loggout { get; set; }
    }
}
