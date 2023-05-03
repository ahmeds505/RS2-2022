﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public class Proizvodi
    {
        public int ProizvodId { get; set; }

        public string Naziv { get; set; } 

        public string Sifra { get; set; } 

        public decimal Cijena { get; set; }

        public int VrstaId { get; set; }

        public int JedinicaMjereId { get; set; }

        public byte[] Slika { get; set; }

        public byte[] SlikaThumb { get; set; }

        public bool? Status { get; set; }

        //public virtual ICollection<IzlazStavke> IzlazStavkes { get; set; } = new List<IzlazStavke>();

        //public virtual JediniceMjere JedinicaMjere { get; set; } = null!;

        //public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; } = new List<NarudzbaStavke>();

        //public virtual ICollection<Ocjene> Ocjenes { get; set; } = new List<Ocjene>();

        //public virtual ICollection<UlazStavke> UlazStavkes { get; set; } = new List<UlazStavke>();

        //public virtual VrsteProizvodum Vrsta { get; set; } = null!;
    }
}
