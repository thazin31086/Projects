﻿using PTC.Models;
using System.Web.Http;

namespace PTC.Controllers_Api
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();

            // throw new ApplicationException("Error in the Get() method");

            vm.Get();
            // vm.Products.Clear();
            if (vm.Products.Count > 0)
            {
                ret = Ok(vm.Products);
            }
            else {
                ret = NotFound();
            }

            return ret;
        }

        [HttpPost()]
        [Route("api/Product/Search")]
        public IHttpActionResult Search(
          ProductSearch searchEntity)
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();

            // Search for Products
            vm.SearchEntity = searchEntity;
            vm.Search();
            if (vm.Products.Count > 0)
            {
                ret = Ok(vm.Products);
            }
            else {
                ret = NotFound();
            }

            return ret;
        }

        // GET api/<controller>/5
        [HttpGet()]
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult ret;
            Product prod = new Product();
            PTCViewModel vm = new PTCViewModel();

            prod = vm.Get(id);
            if (prod != null)
            {
                ret = Ok(prod);
            }
            else {
                ret = NotFound();
            }

            return ret;
        }

        [HttpPost()]
        public IHttpActionResult Post(
               Product product)
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();

            vm.Entity = product;
            vm.PageMode = PageConstants.ADD;
            vm.Save();

            if (vm.IsValid)
            {
                ret = Created<Product>(
                        Request.RequestUri +
                        product.ProductId.ToString(),
                          product);
            }
            else {
                ret = NotFound();
            }

            return ret;
        }

        [HttpPut()]
        public IHttpActionResult Put(int id,
                    [FromBody] Product product)
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();

            vm.Entity = product;
            vm.PageMode = PageConstants.EDIT;
            vm.Save();

            if (vm.IsValid)
            {
                ret = Ok(product);
            }
            else {
                ret = NotFound();
            }

            return ret;
        }

        [HttpDelete()]
        public IHttpActionResult Delete(int id)
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();

            // Get the product
            vm.Entity = vm.Get(id);
            // Did we find the product?
            if (vm.Entity.ProductId > 0)
            {
                // Delete the product
                vm.Delete(id);

                ret = Ok(true);
            }
            else {
                ret = NotFound();
            }

            return ret;
        }
    }
}