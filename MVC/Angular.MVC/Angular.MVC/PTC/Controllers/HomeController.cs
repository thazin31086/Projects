using System.Web.Mvc;

namespace CMS.Controllers
{
    public class HomeController : Controller
  {
    public ActionResult Index()
    {
      CMSViewModel vm = new CMSViewModel();

      vm.HandleRequest();

      return View(vm);
    }
    
    [HttpPost]
    public ActionResult Index(CMSViewModel vm)
    {
      vm.HandleRequest();

      // If everything is OK, update the model state on the page
      if (vm.IsValid) {
        ModelState.Clear();
      }
      else {
        ModelState.Merge(vm.Messages);
      }

      return View(vm);
    }
  }
}