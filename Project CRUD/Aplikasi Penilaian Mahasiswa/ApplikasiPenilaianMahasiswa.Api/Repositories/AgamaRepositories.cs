using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class AgamaRepositories: IRepositories<AgamaViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public AgamaRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AgamaViewModel ChangeStatus(int id, bool status)
        {
            AgamaViewModel result = new AgamaViewModel();
            try
            {
                Agama entity = _dbContext.Agamas
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = 1;
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new AgamaViewModel
                    {
                        Id = entity.Id,
                        Deskripsi = entity.Deskripsi,
                        Kode_Agama = entity.Kode_Agama,
                        Is_delete = entity.Is_delete
                    };
                }
            }
            catch(Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return result;
        }

        public AgamaViewModel Create(AgamaViewModel model)
        {
            try
            {
                Agama entity = new Agama();
                entity.Id = model.Id;
                entity.Deskripsi = model.Deskripsi;
                entity.Kode_Agama = model.Kode_Agama;
                entity.Is_delete = model.Is_delete;

                entity.Created_by = 1;
                entity.Created_on = DateTime.Now;

                _dbContext.Agamas.Add(entity);
                _dbContext.SaveChanges(true);

                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<AgamaViewModel> GetAll()
        {
            List<AgamaViewModel> result = new List<AgamaViewModel>();
            try
            {
                result = (from o in _dbContext.Agamas
                          where o.Is_delete == false
                          select new AgamaViewModel
                          {
                              Id = o.Id,
                              Kode_Agama = o.Kode_Agama,
                              Deskripsi = o.Deskripsi,
                              Is_delete = o.Is_delete
                          }).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            return result;
        }

        public AgamaViewModel GetById(int id)
        {
            AgamaViewModel result = new AgamaViewModel();
            try
            {
                result = (from o in _dbContext.Agamas
                          where o.Id == id
                          select new AgamaViewModel
                          {
                              Id= o.Id,
                              Deskripsi = o.Deskripsi,
                              Kode_Agama= o.Kode_Agama,
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if(result == null)
                {
                    return new AgamaViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<AgamaViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<AgamaViewModel> result = new List<AgamaViewModel>();
            try
            {
                var query = _dbContext.Agamas
                    .Where(o => o.Deskripsi.Contains(search) && o.Is_delete == false);
                
                int count = query.Count();

                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "Deskripsi":
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Deskripsi) : query.OrderByDescending(o => o.Deskripsi);
                            break;
                        default:
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.Is_delete == false)
                        .Select(o => new AgamaViewModel
                        {
                            Id = o.Id,
                            Kode_Agama = o.Kode_Agama,
                            Deskripsi = o.Deskripsi,
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

        public AgamaViewModel Update(AgamaViewModel model)
        {
            try
            {
                Agama entity = _dbContext.Agamas
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Deskripsi = model.Deskripsi;
                    entity.Kode_Agama = model.Kode_Agama;
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
