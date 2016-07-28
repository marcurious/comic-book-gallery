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
            ViewBag.seriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View("DefaultView");
        }
    }
}