using eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model.SearchObjects;
using eProdaja.Model.Requests;

namespace eProdaja.Controllers
{
    public class JediniceMjereController 
        : BaseCRUDController<JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>
    {
        public JediniceMjereController(IJediniceMjereService service) : base(service) {}

    }
}
