using System.Web.Mvc;
using ComicBookGallery2.Models;

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
            ComicBook comicBook = new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist("Dan Slott", "Scripter"),
                    new Artist("Humberto Ramos","Pencils"),
                    new Artist("Victor Olazaba","Inks"),
                    new Artist("Edgar Delgado","Colors"),
                    new Artist("Chris Eliopoulos", "Letters")
                }
            };

            ViewBag.comicBook = comicBook;

            return View(comicBook);
        }
    }
}