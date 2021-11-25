using HotelariaControle.Data.Interfaces;
using HotelariaControle.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Repositorios
{
    public class RepositoryReserva : RepositoryBase<Reservas>, IRepositoryReserva
    {
        public RepositoryReserva(bool SaveChanges = true) : base(SaveChanges)
        {

        } 
    }
}
