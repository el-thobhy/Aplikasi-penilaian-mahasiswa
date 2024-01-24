using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class UjianRepositories : IRepositories<UjianViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public UjianRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UjianViewModel ChangeStatus(int id, bool status)
        {
            UjianViewModel result = new UjianViewModel();
            try
            {
                Ujian entity = _dbContext.Ujians
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = 1;
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new UjianViewModel
                    {
                        Id = entity.Id,
                        Nama_Ujian = entity.Nama_Ujian,
                        Status_Ujian = entity.Status_Ujian,
                        Kode_Ujian = entity.Kode_Ujian,
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

        public UjianViewModel Create(UjianViewModel model)
        {
            try
            {
                Ujian entity = new Ujian();
                entity.Id = model.Id;
                entity.Nama_Ujian = model.Nama_Ujian;
                entity.Status_Ujian = model.Status_Ujian;
                entity.Kode_Ujian = model.Kode_Ujian;
                entity.Is_delete = model.Is_delete;

                entity.Created_by = 1;
                entity.Created_on = DateTime.Now;

                _dbContext.Ujians.Add(entity);
                _dbContext.SaveChanges(true);

                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<UjianViewModel> GetAll()
        {
            List<UjianViewModel> result = new List<UjianViewModel>();
            try
            {
                result = (from o in _dbContext.Ujians
                          where o.Is_delete == false
                          select new UjianViewModel
                          {
                              Id = o.Id,
                              Kode_Ujian = o.Kode_Ujian,
                              Nama_Ujian = o.Nama_Ujian,
                              Status_Ujian = o.Status_Ujian,
                              Is_delete = o.Is_delete
                          }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public UjianViewModel GetById(int id)
        {
            UjianViewModel result = new UjianViewModel();
            try
            {
                result = (from o in _dbContext.Ujians
                          where o.Id == id
                          select new UjianViewModel
                          {
                              Id = o.Id,
                              Kode_Ujian = o.Kode_Ujian,
                              Nama_Ujian = o.Nama_Ujian,
                              Status_Ujian = o.Status_Ujian,
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if (result == null)
                {
                    return new UjianViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<UjianViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<UjianViewModel> result = new List<UjianViewModel>();
            try
            {
                var query = _dbContext.Ujians
                    .Where(o => o.Nama_Ujian.Contains(search) && o.Is_delete == false);

                int count = query.Count();

                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "Deskripsi":
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Nama_Ujian) : query.OrderByDescending(o => o.Nama_Ujian);
                            break;
                        default:
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.Is_delete == false)
                        .Select(o => new UjianViewModel
                        {
                            Id = o.Id,
                            Kode_Ujian = o.Kode_Ujian,
                            Nama_Ujian = o.Nama_Ujian,
                            Status_Ujian = o.Status_Ujian,
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

        public UjianViewModel Update(UjianViewModel model)
        {
            try
            {
                Ujian entity = _dbContext.Ujians
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Nama_Ujian = model.Nama_Ujian;
                    entity.Status_Ujian = model.Status_Ujian;
                    entity.Kode_Ujian = model.Kode_Ujian;
                    entity.Is_delete = model.Is_delete;

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
