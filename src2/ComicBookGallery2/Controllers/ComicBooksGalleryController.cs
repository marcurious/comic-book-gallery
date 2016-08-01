using System.Web.Mvc;
using ComicBookGallery2.Data;

namespace ComicBookGallery2.Controllers
{
    public class ComicBooksGalleryController : Controller
    {
        private ComicBookRepository comicBookRepository = null;

        public ComicBooksGalleryController()
        {
            comicBookRepository = new ComicBookRepository();
        }
            /* 
         * ContentResult
         * RedirectResult
         * Redirect
         */

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(ComicBookRepository.getComicBook((int)id));
        }

        public ActionResult Index()
        {
            return View(ComicBookRepository.getComicBooks());
        }
    }
}