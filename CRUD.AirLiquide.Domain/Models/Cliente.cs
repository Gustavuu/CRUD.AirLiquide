using CRUD.AirLiquide.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.AirLiquide.Domain.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}
