using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurusanController : ControllerBase
    {
        private JurusanRepositories _repo;
        public JurusanController(MahasiswaDbContext dbContext)
        {
            _repo = new JurusanRepositories(dbContext);
        }

        [HttpPost]
        public async Task<JurusanViewModel> Post(JurusanViewModel model)
        {
            return _repo.Create(model);
        }

        [HttpGet("GetAll")]
        public async Task<List<JurusanViewModel>> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<JurusanViewModel> GetById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPut("delete/{id}")]
        public async Task<JurusanViewModel> Put(int id, bool status)
        {
            return _repo.ChangeStatus(id, status);
        }

        [HttpPut("{id}")]
        public async Task<JurusanViewModel> Put(int id, JurusanViewModel? model)
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
