using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class DosenRepositories : IRepositories<DosenViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public DosenRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DosenViewModel ChangeStatus(int id, bool status)
        {
            DosenViewModel result = new DosenViewModel();
            try
            {
                Dosen entity = _dbContext.Dosens
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = 1;
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new DosenViewModel
                    {
                        Id = entity.Id,
                        Nama_Dosen = entity.Nama_Dosen,
                        Kode_Type_Dosen = entity.Kode_Type_Dosen,
                        Kode_Jurusan = entity.Kode_Jurusan,
                        Kode_Dosen = entity.Kode_Dosen,
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

        public DosenViewModel Create(DosenViewModel model)
        {
            try
            {
                Dosen entity = new Dosen();
                entity.Id = model.Id;
                entity.Nama_Dosen = model.Nama_Dosen;
                entity.Kode_Type_Dosen = model.Kode_Type_Dosen;
                entity.Kode_Jurusan = model.Kode_Jurusan;
                entity.Kode_Dosen = model.Kode_Dosen;
                entity.Is_delete = model.Is_delete;

                entity.Created_by = 1;
                entity.Created_on = DateTime.Now;

                _dbContext.Dosens.Add(entity);
                _dbContext.SaveChanges(true);

                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<GetDosenViewModel> GetAll()
        {
            List<GetDosenViewModel> result = new List<GetDosenViewModel>();
            try
            {
                result = (from o in _dbContext.Dosens
                          where o.Is_delete == false
                          select new GetDosenViewModel
                          {
                              Id = o.Id,
                              Kode_Dosen = o.Kode_Dosen,
                              Kode_Jurusan = o.Kode_Jurusan,
                              Kode_Type_Dosen = o.Kode_Type_Dosen,
                              Nama_Dosen = o.Nama_Dosen,
                              Jurusan = new JurusanViewModel
                              {
                                Id = o.Jurusan.Id,
                                Kode_Jurusan = o.Jurusan.Kode_Jurusan,
                                Nama_Jurusan = o.Jurusan.Nama_Jurusan,
                                Status_Jurusan = o.Jurusan.Status_Jurusan
                              },
                              TypeDosen = new TypeDosenViewModel
                              {
                                  Id=o.TypeDosen.Id,
                                  Deskripsi = o.TypeDosen.Deskripsi,
                                  Kode_Type_Dosen = o.TypeDosen.Kode_Type_Dosen,
                              },
                              Is_delete = o.Is_delete
                          }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public GetDosenViewModel GetById(int id)
        {
            GetDosenViewModel result = new GetDosenViewModel();
            try
            {
                result = (from o in _dbContext.Dosens
                          where o.Id == id
                          select new GetDosenViewModel
                          {
                              Id = o.Id,
                              Nama_Dosen = o.Nama_Dosen,
                              Kode_Type_Dosen = o.Kode_Type_Dosen,
                              Kode_Jurusan = o.Kode_Jurusan,
                              Kode_Dosen = o.Kode_Dosen,
                              Jurusan = new JurusanViewModel
                              {
                                  Id = o.Jurusan.Id,
                                  Kode_Jurusan = o.Jurusan.Kode_Jurusan,
                                  Nama_Jurusan = o.Jurusan.Nama_Jurusan,
                                  Status_Jurusan = o.Jurusan.Status_Jurusan
                              },
                              TypeDosen = new TypeDosenViewModel
                              {
                                  Id = o.TypeDosen.Id,
                                  Deskripsi = o.TypeDosen.Deskripsi,
                                  Kode_Type_Dosen = o.TypeDosen.Kode_Type_Dosen,
                              },
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if (result == null)
                {
                    return new GetDosenViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<DosenViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<GetDosenViewModel> result = new List<GetDosenViewModel>();
            try
            {
                var query = _dbContext.Dosens
                    .Where(o => o.Nama_Dosen.Contains(search) && o.Is_delete == false);

                int count = query.Count();

                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "Nama":
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Nama_Dosen) : query.OrderByDescending(o => o.Nama_Dosen);
                            break;
                        default:
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.Is_delete == false)
                        .Select(o => new GetDosenViewModel
                        {
                            Id = o.Id,
                            Nama_Dosen = o.Nama_Dosen,
                            Kode_Type_Dosen = o.Kode_Type_Dosen,
                            Kode_Jurusan = o.Kode_Jurusan,
                            Kode_Dosen = o.Kode_Dosen,
                            Is_delete = o.Is_delete,
                            Jurusan = new JurusanViewModel
                            {
                                Id = o.Jurusan.Id,
                                Kode_Jurusan = o.Jurusan.Kode_Jurusan,
                                Nama_Jurusan = o.Jurusan.Nama_Jurusan,
                                Status_Jurusan = o.Jurusan.Status_Jurusan
                            },
                            TypeDosen = new TypeDosenViewModel
                            {
                                Id = o.TypeDosen.Id,
                                Deskripsi = o.TypeDosen.Deskripsi,
                                Kode_Type_Dosen = o.TypeDosen.Kode_Type_Dosen,
                            },
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

        public DosenViewModel Update(DosenViewModel model)
        {
            try
            {
                Dosen entity = _dbContext.Dosens
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Nama_Dosen = model.Nama_Dosen;
                    entity.Kode_Type_Dosen = model.Kode_Type_Dosen;
                    entity.Kode_Jurusan = model.Kode_Jurusan;
                    entity.Kode_Dosen = model.Kode_Dosen;
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

        List<DosenViewModel> IRepositories<DosenViewModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        DosenViewModel IRepositories<DosenViewModel>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
