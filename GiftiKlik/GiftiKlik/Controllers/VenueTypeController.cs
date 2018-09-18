using BusinessLayer.Interfaces;
using BusinessLayer.Repository;
using GiftiKlik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftiKlik.Controllers
{
    public class VenueTypeController : Controller
    {
        private readonly IVenueType _venueTypeRepository;

        public VenueTypeController()
        {
            _venueTypeRepository = new VenueTypeRepository();
        }
        // GET: VenueType
        public ActionResult CategoryMenuPartial()
        {
            var list = _venueTypeRepository.GetAllTypes()
                .Select(t => new VenueTypeVM
                {
                    VenueTypeID = t.VenueTypeID,
                    Type= t.Type

                });
            return PartialView(list);

            
        }
    }
}