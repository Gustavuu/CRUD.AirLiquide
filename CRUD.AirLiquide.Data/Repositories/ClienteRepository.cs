using CRUD.AirLiquide.Data.Context;
using CRUD.AirLiquide.Domain.Interfaces.Repositories;
using CRUD.AirLiquide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.AirLiquide.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(CRUDContext context) : base(context)
        {
        }
    }
}
