using Exercicios_Inlock_webApi.Domains;
using Exercicios_Inlock_webApi.Interfaces;
using Exercicios_Inlock_webApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class estudiosController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public estudiosController()
        {
            _estudioRepository = new estudioRepository();
        }

        /// <summary>
        /// Lista Eventos
        /// </summary>
        /// <returns> Uma lista de eventos</returns>
        [Authorize(Roles = "1,2")]
        [HttpGet]
        public IActionResult ListarEventos()
        {
            return Ok(_estudioRepository.ListarEstudios());
        }
    }
}
