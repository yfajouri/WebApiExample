﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApiExample.Context;
using webApiExample.Models;

namespace webApiExample.ApiControllers
{
    public class CargoController : ApiController
    {
         
        private ApiContext context;

        public CargoController()
        {
            context = new ApiContext();
        }

        // GET api/<controller>
        public IEnumerable<Cargo> Get()
        {
            return context.Cargos;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}