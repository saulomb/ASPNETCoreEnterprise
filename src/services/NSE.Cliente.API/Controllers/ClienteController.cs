﻿using Microsoft.AspNetCore.Mvc;
using NSE.Clientes.API.Application.Commands;
using NSE.Core.Mediator;
using NSE.WebAPI.Core.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.Clientes.API.Controllers
{
    public class ClienteController : MainController
    {

        private readonly IMediatorHandler _mediatorHandler;

        public ClienteController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("Clientes")]
        public async Task<IActionResult> Index()
        {
           var resultado = await _mediatorHandler.EnviarComando
                (new RegistrarClienteCommand(Guid.NewGuid(), "Saulo", "saulomb@gmail.com", "79214940568"));

           
            return CustomResponse(resultado);
        }
    }
}