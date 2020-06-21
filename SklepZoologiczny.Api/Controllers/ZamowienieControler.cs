using System;
using System.Threading.Tasks;
using SklepZoologiczny.Api.BindingModels;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.Mappers;
using SklepZoologiczny.Api.Validation;
using SklepZoologiczny.Api.ViewModels;
using SklepZoologiczny.IServices.Zamowienie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SklepZoologiczny.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/zamowienie")]
    public class ZamowienieController : Controller
    {
        private readonly SklepZoologicznyDbContext _context;
        private readonly IZamowienieService _zamowienieService;

        public ZamowienieController(SklepZoologicznyDbContext context, IZamowienieService zamowienieService)
        {
            _context = context;
            _zamowienieService = zamowienieService;
        }

        [Route("{zamowienieId:min(1)}", Name = "GetZamowienieById")]
        [HttpGet]
        public async Task<IActionResult> GetZamowienieById(int zamowienieId)
        {
            var zamowienie = await _context.Zamowienie.FirstOrDefaultAsync(x => x.ZamowienieId == zamowienieId);
            if (zamowienie != null)
            {
                return Ok(new ZamowienieViewModel
                {
                    ZamowienieId = zamowienie.ZamowienieId,
                    Data_zlozenia = zamowienie.Data_zlozenia,
                    Status= zamowienie.Status,
                    Przesylka= zamowienie.Przesylka,
                    FirmaId= zamowienie.FirmaId,
                    KlientId= zamowienie.KlientId
                });
            }
            return NotFound();
        }
        
       

       [ValidateModel]
        public async Task<IActionResult> Post([FromBody] IServices.Requests.CreateZamowienie createZamoweinie)
        {
            var zamowienie = await _zamowienieService.CreateZamowienie(createZamoweinie);

            return Created(zamowienie.Id.ToString(), ZamowienieToZamowienieViewModelMapper.ZamowienieToZamowienieViewModel(zamowienie));
        }

        [Route("create", Name = "CreateZamowienie")]
        [ValidateModel]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatZamowienie createzamowienie)
        {
            System.Console.WriteLine("Started for " + createzamowienie);
            var zamowienie = new Zamowienie
            {
                Data_zlozenia = createzamowienie.Data_zlozenia,
                Status = createzamowienie.Status,
                Przesylka = createzamowienie.Przesylka,
                FirmaId = createzamowienie.FirmaId,
                KlientId = createzamowienie.KlientId
            };

            await _context.AddAsync(zamowienie);
            await _context.SaveChangesAsync();

            return Created(zamowienie.ZamowienieId.ToString(), new ZamowienieViewModel
            {
                Data_zlozenia = zamowienie.Data_zlozenia,
                Status = zamowienie.Status,
                Przesylka = zamowienie.Przesylka,
                FirmaId = zamowienie.FirmaId,
                KlientId = zamowienie.KlientId
            });
        }

        [Route("edit/{zamowienieId:min(1)}", Name = "EditZamowienie")]
        [ValidateModel]
        [HttpPatch]
        public async Task<IActionResult> EditUser([FromBody] EditZamowienie editUser, int zamowienieId)
        {
            var zamowienie = await _context.Zamowienie.FirstOrDefaultAsync(x => x.ZamowienieId == zamowienieId);
            zamowienie.KlientId = editUser.KlientId;
            await _context.SaveChangesAsync();

            return Ok(new ZamowienieViewModel
            {
                Data_zlozenia = zamowienie.Data_zlozenia,
                Status = zamowienie.Status,
                Przesylka = zamowienie.Przesylka,
                FirmaId = zamowienie.FirmaId,
                KlientId = zamowienie.KlientId

            });
        }

        [Route("delete/{zamowienieId:min(1)}", Name = "DeleteZamowienie")]
        [ValidateModel]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int zamowienieId)
        {
            var zamowienie = await _context.Zamowienie.FirstOrDefaultAsync(x => x.ZamowienieId == zamowienieId);
            _context.Attach(zamowienie);
            _context.Remove(zamowienie);
            await _context.SaveChangesAsync();
            return Ok(new ZamowienieViewModel
            {
                Data_zlozenia = zamowienie.Data_zlozenia,
                Status = zamowienie.Status,
                Przesylka = zamowienie.Przesylka,
                FirmaId = zamowienie.FirmaId,
                KlientId = zamowienie.KlientId

            });
        }
    }
}
