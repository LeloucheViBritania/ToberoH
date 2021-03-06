﻿using Microsoft.EntityFrameworkCore;
using Roberto.DAL;
using Roberto.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roberto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Images = GetImages();
            var aboutLast = GetAboutUs();
            var AbImagesHomes = GetAbImageHomes();
            var Services = GetServices();
            var BedRand = GetRoomFisrt();
            var BedRandSc = GetRoomSecond();
            var ServiceRom = GetServicesRoom();
            var BlogsList = GetBlogs();
            var listComment = GetComment();
            var ListActivities = GetAllActivity();
            /*var ListClient = GetListClient();*/

            var VmHom = new HomeViewModel();
   
            VmHom.Images = Images;
            VmHom.AbImageHomes = AbImagesHomes;
            VmHom.AboutUs = aboutLast;
            VmHom.Services = Services;
            VmHom.BedRoomFirst = BedRand;
            VmHom.BedRoomSecond = BedRandSc;
            VmHom.servicesRooms = ServiceRom;
            VmHom.Blogs = BlogsList;
            VmHom.Comments = listComment;
            VmHom.Activities = ListActivities;
            /*VmHom.Clients = ListClient;*/
            return View(VmHom);
        }

        private List<Activity> GetAllActivity()
        {
            var _context = new RobertoContext();
             return _context.Activities.OrderByDescending(Acti => Acti.ActivityId).ToList();

        }



        //recupere la liste des services 
        private List<Service> GetServices()
        {
            var _context = new RobertoContext();
            return _context.Services.ToList();
        }
       
        // Recupere la liste des images 
        private List<Image> GetImages()
        {
            var _context = new RobertoContext();
            return _context.Images.ToList();

        }

        //Recupere la liste des des services room 
        private List<ServicesRoom> GetServicesRoom()
        {
            var _context = new RobertoContext();
            return _context.ServicesRooms.ToList();

        }

        //recupere tous les images du la partie home
        private List<AbImageHome> GetAbImageHomes()
        {
            var _context = new RobertoContext();
            return _context.AbImageHomes.OrderByDescending(Ab=>Ab.IdAbHome).ToList();

        }


        //Recupere le dernier element des abouts
        private AboutUs GetAboutUs()
        {

            var _context = new RobertoContext();
           var lastShowPieceId = _context.AboutUs.Max(x => x.AbputUs);
            return _context.AboutUs.FirstOrDefault(x => x.AbputUs == lastShowPieceId);
        }


        private readonly Random _rand = new Random();

        // Generates a random number within a range.   
        /* le truc est de generer un nombre aleatoire entre le premier index et le dernier*/

        public int GetRandom()
        {
            var _context = new RobertoContext();
            var lastShowPieceId = _context.BedRooms.Max(x => x.BedRoomId);
            var maxBed = _context.BedRooms.FirstOrDefault(x => x.BedRoomId == lastShowPieceId);
            var minBedRoom = _context.BedRooms.Min(x => x.BedRoomId);
            var minBedRoomSelect = _context.BedRooms.FirstOrDefault(x => x.BedRoomId == minBedRoom);

            return _rand.Next(minBedRoomSelect.BedRoomId, maxBed.BedRoomId);
        }



        // Recupere Le premier element avec pour particuelarite une random
        private BedRoom GetRoomFisrt()
        {
            var _context = new RobertoContext();
            int rand = GetRandom();
            return _context.BedRooms.Where(x => x.BedRoomId == rand).Include(x => x.Ïmage).First();
        }

        //recupere le facon aleatoire 
        private BedRoom GetRoomSecond()
        {
            var _context = new RobertoContext();
            int rand = GetRandom();
            return _context.BedRooms.Where(x => x.BedRoomId == rand).Include(x => x.Ïmage).First();
        }


        //recuperer une liste de client de sorte a avoir les commentaire egalement
        private List<Comment> GetComment()
        {
            var _context = new RobertoContext();

            return _context.Comments.OrderByDescending(C => C.CommentId).ToList();

        }

        private List<Blog> GetBlogs()
        {
            var _context = new RobertoContext();
            return _context.Blogs.OrderByDescending(c => c.BlogId).ToList();
        }
    }
}