using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftiKlik.Models
{
    public class CardViewModel
    {
        public int CardID { get; set; }
        public string CardImagePAth { get; set; }
        
        public HttpPostedFileBase File { get; set; }
    }
}