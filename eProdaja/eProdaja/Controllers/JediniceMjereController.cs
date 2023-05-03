using eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : ControllerBase
    {
        private readonly IJediniceMjereService Service;

        public JediniceMjereController(IJediniceMjereService service)
        {
            Service = service;
        }

        [HttpGet]
        public IEnumerable<JediniceMjere> Get()
        {
            return Service.Get();
        }

        [HttpGet("{id}")]
        public JediniceMjere GetById(int id)
        {
            return Service.GetById(id);
        }
    }
}
