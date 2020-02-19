using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.AirLiquide.Domain.Interfaces.Repositories;
using CRUD.AirLiquide.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.AirLiquide.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        //INJEÇÃO DE DEPENDÊNCIA
        private IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            try
            {
                return _clienteRepository.GetAll();
            }
            catch
            {
                //TODO: MELHOR TRATAMENTO
                return null;
            }
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public Cliente Get(Guid id)
        {
            try
            {
                return _clienteRepository.GetById(id);
            }
            catch (Exception ex)
            {
                //TODO: MELHOR TRATAMENTO
                return null;
            }

        }

        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] Cliente obj)
        {
            try
            {
                _clienteRepository.Add(obj);
            }
            catch (Exception ex)
            {
                //TODO: MELHOR TRATAMENTO
                throw ex;
            }
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente obj)
        {
            try
            {
                _clienteRepository.Update(obj);
            }
            catch (Exception ex)
            {
                //TODO: MELHOR TRATAMENTO
                throw ex;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            try
            {
                _clienteRepository.Delete(id);
            }
            catch (Exception ex)
            {
                //TODO: MELHOR TRATAMENTO
                throw ex;
            }
        }
    }
}
