using System.Web.Mvc;


namespace ComicBookGallery2.Controllers
{
    public class ComicBooksGalleryController : Controller
    {

        /* 
         * ContentResult
         * RedirectResult
         * Redirect
         */

        public ActionResult Default()
        {
            return View("DefaultView");
        }
    }
}