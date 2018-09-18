using DataLayer;
using GiftiKlik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftiKlik.Controllers
{
    public class CardController : Controller
    {
        private GiftiContext db;

        public CardController()
        {
            db = new GiftiContext();
        }
        // GET: Card
        public ActionResult Index()
        {
            var cards = db.Cards
                        .Select(t=> new CardViewModel
                        {
                            CardID = t.CardID,
                            CardImagePAth = t.CardImagePAth
                        });
            return View(cards);
        }
    }
}