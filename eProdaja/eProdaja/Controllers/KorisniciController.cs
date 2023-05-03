using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _Service;

        public KorisniciController(IKorisniciService Service)
        {
            _Service = Service;
        }

        [HttpGet]
        public IEnumerable<Korisnici> Get()
        {
            return _Service.Get();
        }

        //[HttpGet("{id}")]
        //public Proizvodi GetById(int id)
        //{
        //    return _Service.GetById(id);
        //}
    }
}
