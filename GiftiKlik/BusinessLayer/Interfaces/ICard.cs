using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLayer.Interfaces
{
    public interface ICard
    {
        IQueryable<Card> GetAllCards();
        Card GetCardById(int id);
        void Insert(Card card);
      
        void Delete(Card card);
        void Delete(int id);
        bool Exists(int id);
    }
}
