using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Repositories;
using ApplikasiPenilaianMahasiswa.Api.Security;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DosenController : ControllerBase
    {
        private DosenRepositories _repo;
        private IValidator<DosenViewModel> _validator;
        public DosenController(MahasiswaDbContext dbContext, IValidator<DosenViewModel> validator)
        {
            _repo = new DosenRepositories(dbContext);
            _validator = validator;
        }

        [HttpPost]
        [ReadableBodyStream(Roles = "Administrator,dosen")]
        public async Task<IActionResult> Post(DosenViewModel model)
        {
            try
            {
                ValidationResult result = await _validator.ValidateAsync(model);
                if (!result.IsValid)
                {
                    return BadRequest(result.Errors);
                }
                return Ok(_repo.Create(model));
            }
            catch (Exception)
            {
                //throw;
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<List<GetDosenViewModel>> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<GetDosenViewModel> GetById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPut("delete/{id}")]
        public async Task<DosenViewModel> Put(int id, bool status)
        {
            return _repo.ChangeStatus(id, status);
        }

        [HttpPut("{id}")]
        public async Task<DosenViewModel> Put(int id, DosenViewModel? model)
        {
            model.Id = id;
            return _repo.Update(model);
        }

        [HttpGet("Search")]
        public async Task<ResponseResult> Get(int pageNum, int rows, string? search = "", string? orderBy = "", Sorting sort = Sorting.Ascending)
        {
            return _repo.Pagination(pageNum, rows, search, orderBy, sort);
        }
    }
}
