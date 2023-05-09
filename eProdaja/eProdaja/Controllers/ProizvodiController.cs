using eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model.SearchObjects;
using eProdaja.Model.Requests;

namespace eProdaja.Controllers
{
    public class ProizvodiController 
        : BaseCRUDController<Model.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService service):base(service){}

    }
}
