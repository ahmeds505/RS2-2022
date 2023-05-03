﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdaja.Services
{
    public interface IProizvodiService
    {
        IEnumerable<Proizvodi> Get();
        Proizvodi GetById(int id);
    }
}
