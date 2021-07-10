﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasaDoCodigo.RelatorioWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {

        private readonly List<string> Relatorio = new List<string>()
        {
            "Primeiro pedido",
            "Segundo pedido"
        };


        // GET: api/<RelatorioController>
        [HttpGet]
        public string Get()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (var linha in Relatorio)
            {
                sb.AppendLine($"{linha}");
                
            }
            return sb.ToString();
        }

        //// GET api/<RelatorioController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<RelatorioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Relatorio.Add(value);
        }
        
        //// PUT api/<RelatorioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RelatorioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
