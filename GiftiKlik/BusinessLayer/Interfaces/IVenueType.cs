﻿using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IVenueType
    {
       List<VenueType> GetAllTypes();
        void Insert(VenueType type);
        void Delete(int id);
    }
}
