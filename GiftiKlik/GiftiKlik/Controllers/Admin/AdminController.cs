using BusinessLayer.Interfaces;
using BusinessLayer.Repository;
using DataLayer;
using DataLayer.Entities;
using GiftiKlik.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftiKlik.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IVenues _venuesRepository;
        private readonly IVenueType _venueTypeRepository;
        private readonly ICard _cardRepository;


        public AdminController()
        {
            _venuesRepository = new VenuesRepository();
            _venueTypeRepository = new VenueTypeRepository();
            _cardRepository = new CardRepository();

        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddVenue(VenuesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            VenuesViewModel venue = new VenuesViewModel
            {
                Name = model.Name,
                Street = model.Street,
                StreetNumber = model.StreetNumber,
                CityID = model.CityID,
                Phone = model.Phone,
                VenueTypeID = model.VenueTypeID
            };


            _venuesRepository.Insert(new Venues {

                Name = venue.Name,
                Street = venue.Street,
                StreetNumber = venue.StreetNumber,
                CityID = venue.CityID,
                Phone = venue.Phone,
                VenueTypeID = venue.VenueTypeID
            });

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult AddCard(CardViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            CardViewModel card = new CardViewModel
            {
                CardImagePAth = model.CardImagePAth
            };

            _cardRepository.Insert(new Card
            {
                CardImagePAth = card.CardImagePAth
            });
            return RedirectToAction("Index", "Card");
        }

        public ActionResult AddType(VenueTypeVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            VenueTypeVM type = new VenueTypeVM
            {
                Type = model.Type
            };
            _venueTypeRepository.Insert(new VenueType
            {
                Type = type.Type
            });

            return RedirectToAction("Index", "AdminVenues");
        }    
       
        public ActionResult GetAllCategories()
        {
            var types = _venueTypeRepository.GetAllTypes()
                .Select(t => new VenueTypeVM
                {
                    VenueTypeID = t.VenueTypeID,
                    Type = t.Type
                }).ToList();

            return View(types);
        }

        public ActionResult DeleteCategory(int id)
        {
            _venueTypeRepository.Delete(id);
            return RedirectToAction("GetAllCategories");
        }

        public ActionResult GetAllCards()
        {
            var cards = _cardRepository.GetAllCards()
                .Select(t => new CardViewModel
                {
                    CardID = t.CardID,
                    CardImagePAth = t.CardImagePAth
                }).ToList();

            return View(cards);
        }

        public ActionResult DeleteCard(int id)
        {
            _cardRepository.Delete(id);
            return RedirectToAction("GetAllCards");
        }

        [HttpPost]
        public ActionResult UploadCard(CardViewModel model)
        {
          
            if (model.File.ContentLength > 0)
            {
                var uploadedPath = "~/Content/images/uploads/";
                var fileName = Path.GetFileName(model.File.FileName);
                model.CardImagePAth = uploadedPath + fileName;

                fileName = Path.Combine(Server.MapPath(uploadedPath), fileName);
                model.File.SaveAs(fileName);
                       
              
            }

            return RedirectToAction("AddCard",model);
        }


    }
}
//public ActionResult Index(HttpPostedFileBase file)
//{

//    if (file.ContentLength > 0)
//    {
//        var fileName = Path.GetFileName(file.FileName);
//        var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
//        file.SaveAs(path);
//    }

//    return RedirectToAction("Index");