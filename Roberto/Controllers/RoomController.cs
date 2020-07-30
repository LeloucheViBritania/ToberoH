﻿using Microsoft.Ajax.Utilities;
using Microsoft.EntityFrameworkCore;
using Roberto.DAL;
using Roberto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Roberto.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        RobertoContext context = new RobertoContext();
        // GET: Room
        public ActionResult Rooms()
        {
            var ImgOne = GetImageOne();

            var VmRom = new RoomViewModel();

            VmRom.Images = ImgOne;
            ViewBag.listchambre = context.BedRooms.Include(im => im.Ïmage).ToList();
            return View();
        }

        private Image GetImageOne()
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


        [HttpPost]
        public ActionResult Rooms(int searchStringChild, int searchStringAdult)
        {
            //Recherche par nombre d'adulte et enfants  
            var bedroom = from s in context.BedRooms select s;
            if (searchStringAdult != null && searchStringChild != null)
            {
                bedroom = bedroom.Where(s => s.NumberAdult == searchStringAdult && s.NumberChild == searchStringChild);
                ViewBag.listchambre = bedroom.ToList();
            }
            return View();
        }

        public ActionResult Details(int? id)
        {
            // Permet de selectionner un item et voir ses details 
            if (id == null)
            {
                return RedirectToAction("Rooms");
            }
            BedRoom bedroom = context.BedRooms.Find(id);
            if (bedroom == null)
            {
                return RedirectToAction("Rooms");
            }

            return View(bedroom);
        }


    }
}