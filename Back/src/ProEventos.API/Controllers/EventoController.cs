using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {      
        private readonly DataContext _context;

        public EventoController( DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> get()
        {
            return _context.Eventos;
        }    

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }    

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put( int id)
        {
            return $"Exemplo de Put {id}";
        }


    }
}