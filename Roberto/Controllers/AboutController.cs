using Roberto.DAL;
using Roberto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Roberto.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            var AboutUS = GetAboutUs();
            var ImageAbouPage = GetImageAboutPageRand();
            var ListActivites = GetACtivitiesL();

            var VmAb = new AboutViewModel();

            VmAb.AboutUs = AboutUS;
            VmAb.Images = ImageAbouPage;
            VmAb.Activities = ListActivites;




            return View(VmAb);
        }

        private List<Activity> GetACtivitiesL()
        {
            var _context = new RobertoContext();
            return _context.Activities.ToList();
        }

        private Image GetImageAboutPageRand()
        {
            var _context = new RobertoContext();
            int rand = GetRandom();
            return _context.Images.Where(x => x.ImgId == rand).FirstOrDefault();
        }

        private readonly Random _rand = new Random();

        private int GetRandom()
        {
            var _context = new RobertoContext();
            var lastShowPieceId = _context.Images.Max(x => x.ImgId);
            var maxBed = _context.Images.FirstOrDefault(x => x.ImgId == lastShowPieceId);
            var minBedRoom = _context.Images.Min(x => x.ImgId);
            var minBedRoomSelect = _context.Images.FirstOrDefault(x => x.ImgId == minBedRoom);

            return _rand.Next(minBedRoomSelect.ImgId, maxBed.ImgId);
        }

        //About le premier element de la table about
        private AboutUs GetAboutUs()
        {
            var _context = new RobertoContext();
            var aboutOne = _context.AboutUs.FirstOrDefault();
            return aboutOne;
        }



    }
}