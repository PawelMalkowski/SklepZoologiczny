using System;
using System.Threading.Tasks;
using SklepZoologiczny.Api.BindingModels;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.Mappers;
using SklepZoologiczny.Api.Validation;
using SklepZoologiczny.Api.ViewModels;
using SklepZoologiczny.IServices.Akcesoria;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SklepZoologiczny.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Akcesoria")]
    public class AkcesoriaController : Controller
    {
        private readonly SklepZoologicznyDbContext _context;
        private readonly IAkcesoriaService _AkcesoriaService;

        public AkcesoriaController(SklepZoologicznyDbContext context, IAkcesoriaService AkcesoriaService)
        {
            _context = context;
            _AkcesoriaService = AkcesoriaService;
        }

        [Route("{AkcesoriaId:min(1)}", Name = "GetAkcesoriaById")]
        [HttpGet]
        public async Task<IActionResult> GetAkcesoriaById(int AkcesoriaId)
        {
            var Akcesoria = await _context.Akcesorie.FirstOrDefaultAsync(x => x.AkcesoriaId == AkcesoriaId);
            if (Akcesoria != null)
            {
                return Ok(new AkcesoriaViewModel
                {
                    AkcesoriaId = Akcesoria.AkcesoriaId,
                    Nazwa = Akcesoria.Nazwa,
                    ProducentId = Akcesoria.ProducentId
                });
            }
            return NotFound();
        }



        [ValidateModel]
        public async Task<IActionResult> Post([FromBody] IServices.Requests.CreateAkcesoria createAkcesoria)
        {
            var Akcesoria = await _AkcesoriaService.CreateAkcesoria(createAkcesoria);

            return Created(Akcesoria.Id.ToString(), AkcesoriaToAkcesoriaViewModelMapper.AkcesoriaToAkcesoriaViewModel(Akcesoria));
        }

        [Route("create", Name = "CreateAkcesoria")]
        [ValidateModel]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatAkcesoria createAkcesoria)
        {
            System.Console.WriteLine("Started for " + createAkcesoria);
            var Akcesoria = new Produkt
            {
                        Ilosc = 0,
                        Waga = 0,
                        Cena = 0,
                        Akcesorias = new Akcesoria
                        {
                           ProducentId = createAkcesoria.ProducentId,
                           Nazwa = createAkcesoria.Nazwa,

                        }
                    

            };

            await _context.AddAsync(Akcesoria);
            await _context.SaveChangesAsync();

            return Created(Akcesoria.Akcesorias.AkcesoriaId.ToString(), new AkcesoriaViewModel
            {
                AkcesoriaId = Akcesoria.Akcesorias.AkcesoriaId,
                Nazwa = Akcesoria.Akcesorias.Nazwa,
                ProducentId = Akcesoria.Akcesorias.ProducentId
            });
        }

        [Route("edit/{AkcesoriaId:min(1)}", Name = "EditAkcesoria")]
        [ValidateModel]
        [HttpPut]
        public async Task<IActionResult> EditAkcesoria([FromBody] EditAkcesoria editAkcesoria, int AkcesoriaId)
        {
            var Akcesoria = await _context.Akcesorie.FirstOrDefaultAsync(x => x.AkcesoriaId == AkcesoriaId);
            Akcesoria.Nazwa = editAkcesoria.Nazwa;
            await _context.SaveChangesAsync();

            return Ok(new AkcesoriaViewModel
            {
                AkcesoriaId= Akcesoria.AkcesoriaId,
                Nazwa= Akcesoria.Nazwa,
                ProducentId= Akcesoria.ProducentId

            });
        }

        [Route("delete/{AkcesoriaId:min(1)}", Name = "DeleteAkcesoria")]
        [ValidateModel]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int AkcesoriaId)
        {
            var Akcesoria = await _context.Produkt.FirstOrDefaultAsync(x => x.ProduktId == AkcesoriaId);
            _context.Attach(Akcesoria);
            _context.Remove(Akcesoria);
            await _context.SaveChangesAsync();
            return Ok("usunieto");
        }
    }
}
