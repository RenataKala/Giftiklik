using BusinessLayer.Interfaces;
using BusinessLayer.Repository;
using DataLayer.Entities;
using GiftiKlik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftiKlik.Controllers
{
    public class VenuesController : Controller
    {
        private readonly IVenues _venuesRepository;

        public VenuesController()
        {
            _venuesRepository = new VenuesRepository();
        }

        // GET: Venues
        public ActionResult Index()
        {
           return RedirectToAction("Index","Home");
        }
        //GET: venues/all
        public ActionResult GetAll()
        {
            var venues = _venuesRepository.GetAllVenues()
                .Select(t => new VenuesViewModel
                { 
                    VenueID = t.VenueID,
                    Name = t.Name,
                    Street = t.Street,
                    StreetNumber = t.StreetNumber,
                    Phone = t.Phone,
                    CityName = t.City.CityName,
                    VenueType = t.VenueType.Type
                })
                .OrderBy(t=>t.Name)
                .ToList();
            return View(venues);
        }

        public ActionResult Locations(string location)
        {
            var venues = _venuesRepository.SearchVenueByLocation(location)
                .Select(t => new VenuesViewModel
                {
                    Name = t.Name,
                    Street = t.Street,
                    StreetNumber = t.StreetNumber,
                    Phone = t.Phone,
                    CityName = t.City.CityName
                }).ToList();

            return PartialView("Locations",venues);
        }

        public ActionResult Location()
        {
            return View();
        }

        [HttpGet]
        //GET: venues/details/id
        public ActionResult Details(int id)
        {
            VenuesViewModel model;
            Venues venue = _venuesRepository.GetVenueById(id);

            if(venue == null)
            {
                return Content("This Venue does not exist");
            }
            model = new VenuesViewModel(venue);


            return View(model);
        }

      


        }
}