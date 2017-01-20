using CMS.Models;
using System.Linq;
using System.Web.Http;

namespace CMS.Controllers_Api
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            IHttpActionResult ret = null;
            CMSViewModel vm = new CMSViewModel();

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
            CMSViewModel vm = new CMSViewModel();

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
            CMSViewModel vm = new CMSViewModel();

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
            CMSViewModel vm = new CMSViewModel();

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
            else if (vm.Messages.Count > 0)
            {
                ret = BadRequest(ConvertToModelState(vm.Messages)); 
            }
            else {

                ret = NotFound();
            }

            return ret;
        }

        private System.Web.Http.ModelBinding.ModelStateDictionary ConvertToModelState(System.Web.Mvc.ModelStateDictionary states)
        {
            System.Web.Http.ModelBinding.ModelStateDictionary ret = new System.Web.Http.ModelBinding.ModelStateDictionary();
            foreach (var list in states.ToList())
            {
                for (int i = 0; i < list.Value.Errors.Count; i++)
                {
                    ret.AddModelError(list.Key, list.Value.Errors[i].ErrorMessage); 
                }
            }
            return ret;
        }

        [HttpPut()]
        public IHttpActionResult Put(int id,
                    [FromBody] Product product)
        {
            IHttpActionResult ret = null;
            CMSViewModel vm = new CMSViewModel();

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
            CMSViewModel vm = new CMSViewModel();

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