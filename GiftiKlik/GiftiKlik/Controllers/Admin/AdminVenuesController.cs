using BusinessLayer.Interfaces;
using BusinessLayer.Repository;
using DataLayer.Entities;
using GiftiKlik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftiKlik.Controllers.Admin
{
    public class AdminVenuesController : Controller
    {

        private readonly IVenues _venuesRepository;

        public AdminVenuesController()
        {
            _venuesRepository = new VenuesRepository();
        }

        // GET: AdminVenues
        public ActionResult Index()
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
               .OrderBy(t => t.Name)
               .ToList();
            return View(venues);
        }
        public ActionResult Details(int id)
        {
            return PartialView("_Details", id);
        }


        public JsonResult DetailsInfo(int id)
        {
            var venue = _venuesRepository.GetVenueById(id);
            if (venue == null)
            {
                return null;
            }
            VenuesViewModel model = new VenuesViewModel();
            model.VenueID = venue.VenueID;
            model.Name = venue.Name;
            model.Street = venue.Street;
            model.StreetNumber = venue.StreetNumber;
            model.CityID = venue.CityID;
            model.Phone = venue.Phone;
            model.VenueTypeID = venue.VenueTypeID;

            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public ActionResult UpdateVenue(VenuesViewModel model)
        {
            Venues venue = _venuesRepository.GetVenueById(model.VenueID);
            if (venue == null)
            {
                return Json(new { success = false, message = "Локалот не постои" });
            }
            venue.Name = model.Name;
            venue.Street = model.Street;
            venue.StreetNumber = model.StreetNumber;
            venue.CityID = model.CityID;
            venue.Phone = model.Phone;
            venue.VenueTypeID = model.VenueTypeID;

            _venuesRepository.Update(venue);
            return RedirectToAction("Index");
            //return Json(new { success = true, message = "Success" });

        }

        public ActionResult Delete(int id)
        {
            _venuesRepository.Delete(id);

            return RedirectToAction("Index");
        }

    }
}