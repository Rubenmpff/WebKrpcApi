﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebKrpcApi.Services.Mapping.Dtos;
using WebKrpcApi.Services.Services.Interfaces;

namespace WebKrpcApi.Controllers
{
    [Route("WebKrpcApi/[controller]")]
    // WebKrpcApi/Client
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;

        public ClientController(IClientService clientService)
        {
            _service = clientService;
        }

        [HttpGet]
        public List<ClientDto> GetAll()
        {
            return _service.GetAll().Result;
        }

        [HttpGet("{id}")]
        public ClientDto GetClient(int id)
        {
            return _service.GetById(id).Result;
        }

        [HttpPost]
        public ClientDto Save(ClientDto clientDto)
        {
            return _service.Save(clientDto).Result;
        }

        [HttpDelete]
        public void Delete(ClientDto clientDto)
        {
            _service.Delete(clientDto);
        }
    }
}