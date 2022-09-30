using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    // [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }


  }
}