﻿using BackCine.Data;
using BackCine.Data.Entities;
using BackCine.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;            
        }
        // GET: api/<ClienteController>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _service.GetClientes());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _service.GetClienteById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }
        [HttpGet("Barrios")]
        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> GetBarrios()
        {
            try
            {
                return Ok(await _service.GetBarrios());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }

        [HttpGet("Filtrar/")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetByName([FromQuery] string nombre, [FromQuery] string apellido)
        {
            try
            {
                return Ok(await _service.FiltrarClientePorNombre(nombre, apellido));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }

        [HttpGet("TipoDoc")]
        public async Task<IActionResult> GetTipoDoc()
        {
            try
            {
                return Ok(await _service.GetTiposDocumento());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }


        // POST api/<ClienteController>
        [HttpPost]
        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> Post([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("Ingrese un cliente válido");
                else
                {
                    await _service.RegistrarCliente(cliente);
                    return Ok("Cliente registrado exitosamente");
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> Put(int id, [FromBody] ClienteUpdate cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("Debe ingresar los datos del cliente");
                if (id == 0 || id == null)
                    return NotFound("Cliente no encontrado!");
                else
                {
                    await _service.EditarCliente(id, cliente);
                    return Ok("Cliente actualizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == null)
                    return BadRequest("Ingrese valores válidos");
                else
                {
                    await _service.Eliminar(id);
                    return Ok("Cliente dado de baja!");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ha ocurrido un error interno: {ex.Message}");
            }
        }
    }
}
