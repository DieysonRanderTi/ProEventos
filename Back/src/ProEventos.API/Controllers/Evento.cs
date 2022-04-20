using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


        public IEnumerable<Evento> _evento = new Evento[]
        {
           new Evento(){
               EventoId = 1,
               Tema = "Angular Course",
               Local = "Unaí-MG",
               Lote = "1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString(),
               ImagemURL = "foto.png"
               },
            new Evento(){
               EventoId = 2,
               Tema = ".NET Course",
               Local = "Unaí-MG",
               Lote = "1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString(),
               ImagemURL = "foto.png"
               }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post(string post)
        {
           return post;
        }
    }
}
