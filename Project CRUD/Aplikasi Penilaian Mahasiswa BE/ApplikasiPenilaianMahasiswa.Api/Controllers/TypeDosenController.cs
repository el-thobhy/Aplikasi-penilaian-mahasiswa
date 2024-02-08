using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Security;
using ApplikasiPenilaianMahasiswa.Api.Repositories;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeDosenController : ControllerBase
    {
        private TypeDosenRepositories _repo;
        private IValidator<TypeDosenViewModel> _validator;
        public TypeDosenController(MahasiswaDbContext dbContext, IValidator<TypeDosenViewModel> validator)
        {
            _repo = new TypeDosenRepositories(dbContext);
            _validator = validator;
        }

        [HttpPost]
        [ReadableBodyStream(Roles = "Administrator,typedosen")]
        public async Task<IActionResult> Post(TypeDosenViewModel model)
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
        public async Task<List<TypeDosenViewModel>> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<TypeDosenViewModel> GetById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPut("delete/{id}")]
        public async Task<TypeDosenViewModel> Put(int id, bool status)
        {
            return _repo.ChangeStatus(id, status);
        }

        [HttpPut("{id}")]
        public async Task<TypeDosenViewModel> Put(int id, TypeDosenViewModel? model)
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
