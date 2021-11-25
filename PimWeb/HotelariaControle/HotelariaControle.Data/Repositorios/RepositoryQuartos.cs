using HotelariaControle.Data.Interfaces;
using HotelariaControle.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Repositorios
{
    public class RepositoryQuartos:RepositoryBase<Quartos>, IRepositoryQuartos
    {
        public RepositoryQuartos(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
