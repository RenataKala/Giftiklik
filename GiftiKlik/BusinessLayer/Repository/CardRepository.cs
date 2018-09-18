using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLayer.Repository
{
    public class CardRepository : ICard
    {

        private GiftiContext db;

        public CardRepository()
        {
            db = new GiftiContext();
        }
        public IQueryable<Card> GetAllCards()
        {
            return db.Cards;
        }
        public void Insert(Card card)
        {
            if (card == null)
                return;
            db.Cards.Add(card);
            db.SaveChanges();
        }

      

       

        public void Delete(int id)
        {
            if (!db.Cards.Any(t => t.CardID == id))
                return;
            db.Cards.Remove(db.Cards.SingleOrDefault(t => t.CardID == id));
            db.SaveChanges();
        }

        public void Delete(Card card)
        {
            if (!db.Cards.Any()) return;
            db.Cards.Remove(card);
            db.SaveChanges();
        }       

        public bool Exists(int id)
        {
            return db.Cards.Any(t => t.CardID == id);
        }       

        public Card GetCardById(int id)
        {
            if (!db.Cards.Any(t => t.CardID == id))
                return null;

            return db.Cards.SingleOrDefault(t => t.CardID == id);
        }


     
    }
}
