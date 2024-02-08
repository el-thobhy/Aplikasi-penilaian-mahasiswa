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
    public class AgamaController : ControllerBase
    {
        private AgamaRepositories _repo;
        private IValidator<AgamaViewModel> _validator;
        public AgamaController(MahasiswaDbContext dbContext, IValidator<AgamaViewModel> validator)
        {
            _repo = new AgamaRepositories(dbContext);
            _validator = validator;
        }

        [HttpPost]
        [ReadableBodyStream(Roles = "Administrator,agama")]
        public async Task<IActionResult> Post(AgamaViewModel model)
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
        public async Task<List<AgamaViewModel>> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<AgamaViewModel> GetById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPut("delete/{id}")]
        public async Task<AgamaViewModel> Put(int id, bool status)
        {
            return _repo.ChangeStatus(id, status);
        }

        [HttpPut("{id}")]
        public async Task<AgamaViewModel> Put(int id, AgamaViewModel? model)
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
