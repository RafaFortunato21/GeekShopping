﻿using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();

            if (products == null) return NotFound();

            return Ok(products);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product  = await _repository.FindById(id);

            if (product == null) return  NotFound();

            return  Ok(product);

        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> CreateProduct(ProductVO model)
        {
            if (model == null) return BadRequest();
            var product = await _repository.Create(model);

            return Ok(product);

        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> UpdateProduct(ProductVO model)
        {
            if (model == null) return BadRequest();
            var product = await _repository.Update(model);

            return Ok(product);

        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var status = await _repository.Delete(id);

            if (!status) return BadRequest();

            return Ok(status);

        }
    }
}
