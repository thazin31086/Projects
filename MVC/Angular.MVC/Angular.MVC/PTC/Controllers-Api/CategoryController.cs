using System.Web.Http;

namespace PTC.Controllers_Api
{
    public class CategoryController : ApiController
    {
        [HttpGet]        
        public IHttpActionResult GetCategories() {

            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();
            vm.LoadCategories();
            if (vm.Categories.Count > 0)
            {
                ret = Ok(vm.Categories);
            }
            else {
                ret = NotFound();
            }
            return ret;
        }

        [HttpGet]
        [Route("api/Categroy/GetSearchCategories")]
        public IHttpActionResult GetSearchCategories()
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();

            vm.LoadSearchCategories();
            if (vm.SearchCategories.Count > 0)
            {
                ret = Ok(vm.SearchCategories);
            }
            else {
                ret = NotFound();
            }

            return ret; 
        }


        [HttpPost]
        [Route("api/Product/Search")]
        public IHttpActionResult Search(ProductSearch searchEntity)
        {
            IHttpActionResult ret = null;
            PTCViewModel vm = new PTCViewModel();
            vm.SearchEntity = searchEntity;
            vm.Search();

            if (vm.Products.Count > 0)
            {
                ret = Ok(vm.Products);
            }
            else
                ret = NotFound();

            return ret;
        }
    }
}
