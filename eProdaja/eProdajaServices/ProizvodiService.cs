using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public class ProizvodiService : IProizvodiService
    {
        public List<Proizvodi> ProizvodiList = new List<Proizvodi>()
            {
                new Proizvodi() {Id = 1, Naziv = "Laptop"},
                new Proizvodi() {Id = 2, Naziv = "Mobitel"}
            };
        public IEnumerable<Proizvodi> Get()
        {
            ProizvodiList.Add(new Proizvodi() { Id = -1, Naziv = "Mis" });
            return ProizvodiList;
        }

        public Proizvodi GetById (int id)
        {
            return ProizvodiList.FirstOrDefault(x => x.Id == id);
        }
    }
}
