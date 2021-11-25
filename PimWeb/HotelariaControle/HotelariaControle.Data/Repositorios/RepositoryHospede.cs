using HotelariaControle.Data.Interfaces;
using HotelariaControle.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaControle.Data.Repositorios
{
    public class RepositoryHospede : RepositoryBase<Hospedes>, IRepositoryHospede
    {
        public RepositoryHospede(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
