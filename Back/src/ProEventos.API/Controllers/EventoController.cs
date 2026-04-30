using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        [HttpGet]
        public Evento Get()
        {
            return new Evento()
            {
                EventoId = 1,
                Tema = "Angular + .NET",
                Local = "BEAGÁ",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(3).ToString()
            };
        }
    }
}