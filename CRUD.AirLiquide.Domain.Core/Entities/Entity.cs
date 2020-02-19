using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.AirLiquide.Domain.Core.Entities
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
