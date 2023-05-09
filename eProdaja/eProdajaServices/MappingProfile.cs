using AutoMapper;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    internal class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();
            CreateMap<JediniceMjereUpsertRequest, Database.JediniceMjere>();

        }
    }
}
