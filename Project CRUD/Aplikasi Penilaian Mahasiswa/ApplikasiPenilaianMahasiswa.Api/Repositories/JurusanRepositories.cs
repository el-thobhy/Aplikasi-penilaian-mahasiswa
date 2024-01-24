using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class JurusanRepositories : IRepositories<JurusanViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public JurusanRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public JurusanViewModel ChangeStatus(int id, bool status)
        {
            JurusanViewModel result = new JurusanViewModel();
            try
            {
                Jurusan entity = _dbContext.Jurusans
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = 1;
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new JurusanViewModel
                    {
                        Id = entity.Id,
                        Nama_Jurusan = entity.Nama_Jurusan,
                        Status_Jurusan = entity.Status_Jurusan,
                        Kode_Jurusan = entity.Kode_Jurusan,
                        Is_delete = entity.Is_delete
                    };
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return result;
        }

        public JurusanViewModel Create(JurusanViewModel model)
        {
            try
            {
                Jurusan entity = new Jurusan();
                entity.Id = model.Id;
                entity.Nama_Jurusan = model.Nama_Jurusan;
                entity.Status_Jurusan = model.Status_Jurusan;
                entity.Kode_Jurusan = model.Kode_Jurusan;
                entity.Is_delete = model.Is_delete;

                entity.Created_by = 1;
                entity.Created_on = DateTime.Now;

                _dbContext.Jurusans.Add(entity);
                _dbContext.SaveChanges(true);

                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<JurusanViewModel> GetAll()
        {
            List<JurusanViewModel> result = new List<JurusanViewModel>();
            try
            {
                result = (from o in _dbContext.Jurusans
                          where o.Is_delete == false
                          select new JurusanViewModel
                          {
                              Id = o.Id,
                              Kode_Jurusan = o.Kode_Jurusan,
                              Status_Jurusan = o.Status_Jurusan,
                              Nama_Jurusan = o.Nama_Jurusan,
                              Is_delete = o.Is_delete
                          }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public JurusanViewModel GetById(int id)
        {
            JurusanViewModel result = new JurusanViewModel();
            try
            {
                result = (from o in _dbContext.Jurusans
                          where o.Id == id
                          select new JurusanViewModel
                          {
                              Id = o.Id,
                              Kode_Jurusan = o.Kode_Jurusan,
                              Status_Jurusan = o.Status_Jurusan,
                              Nama_Jurusan = o.Nama_Jurusan,
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if (result == null)
                {
                    return new JurusanViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<JurusanViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<JurusanViewModel> result = new List<JurusanViewModel>();
            try
            {
                var query = _dbContext.Jurusans
                    .Where(o => o.Nama_Jurusan.Contains(search) && o.Is_delete == false);

                int count = query.Count();

                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "Deskripsi":
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Nama_Jurusan) : query.OrderByDescending(o => o.Nama_Jurusan);
                            break;
                        default:
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.Is_delete == false)
                        .Select(o => new JurusanViewModel
                        {
                            Id = o.Id,
                            Kode_Jurusan = o.Kode_Jurusan,
                            Status_Jurusan = o.Status_Jurusan,
                            Nama_Jurusan = o.Nama_Jurusan,
                            Is_delete = o.Is_delete
                        }).ToList();

                    _result.Pages = (int)Math.Ceiling((decimal)query.Count() / (decimal)rows);

                    if (_result.Pages < pageNum)
                    {
                        return Pagination(1, rows, search, orderBy, sort);
                    }
                }
                else
                {
                    _result.Message = "No Record found";
                }
            }
            catch (Exception ex)
            {
                _result.Success = false;
                _result.Message = ex.Message;
            }
            return _result;
        }

        public JurusanViewModel Update(JurusanViewModel model)
        {
            try
            {
                Jurusan entity = _dbContext.Jurusans
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Nama_Jurusan = model.Nama_Jurusan;
                    entity.Status_Jurusan = model.Status_Jurusan;
                    entity.Kode_Jurusan = model.Kode_Jurusan;

                    entity.Modified_by = 1;
                    entity.Modified_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    model.Id = entity.Id;
                }
                else
                {
                    model.Id = 0;
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return model;
        }
    }
}
