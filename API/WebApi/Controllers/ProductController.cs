﻿using Application;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(string id)
        {
            return Ok(await _mediator.Send(new Details.Query { Id = Guid.Parse(id) }));
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _mediator.Send(new List.Query()));
        }

        [HttpDelete]
        public async Task<ActionResult<List<Product>>> DeleteProduct()
        {
            return Ok();
        }
    }
}
