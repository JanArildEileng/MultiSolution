using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Kunde.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KundeController : ControllerBase
    {
        private readonly ILogger<KundeController> _logger;
      
         private static List<Models.Kunde> kunder=new  List<Models.Kunde>();
        private static int NextKundeId=1;



        public KundeController(ILogger<KundeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<Kunde.Webapi.Models.Kunde>> GetAll()
        {
            return Ok(kunder);
        }

        [HttpGet]
        [Route("{Id:int}")]
        public Kunde.Webapi.Models.Kunde GetKunde(int Id)
        {
          return new Kunde.Webapi.Models.Kunde
            {
               
            };
        }

        [HttpPost]
        [Route("")]
        public  ActionResult<Kunde.Webapi.Models.Kunde> Create(Kunde.Webapi.Models.Kunde kunde)
        {
            kunde.Guid=Guid.NewGuid();
            kunde.Id=NextKundeId++;
            kunder.Add(kunde);
            return CreatedAtAction(nameof(GetKunde), new { id = kunde.Id }, kunde);
        }


    }
}
