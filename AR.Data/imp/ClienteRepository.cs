using AR.Data.Interfaces;
using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Data.imp
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextoPrincipal _db;

        public ClienteRepository(ContextoPrincipal db)
        {
            _db = db;
        }

       public async Task Add(Cliente entity)
        {
          await _db.AddAsync(entity);
          await _db.SaveChangesAsync();
        }

        IQueryable<Cliente> IClienteRepository.GetAll()
        {
            return _db.Cliente;
        }
    }
}
