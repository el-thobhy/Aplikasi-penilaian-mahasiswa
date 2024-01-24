using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Repositories;
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
        public AgamaController(MahasiswaDbContext dbContext)
        {
            _repo = new AgamaRepositories(dbContext);
        }

        [HttpPost]
        public async Task<AgamaViewModel> Post(AgamaViewModel model)
        {
            return _repo.Create(model);
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
        public async Task<ResponseResult> Get(int pageNum, int rows, string? search = "", string? orderBy = "", Sorting sort= Sorting.Ascending)
        {
            return _repo.Pagination(pageNum, rows, search, orderBy, sort);
        }
    }
}
