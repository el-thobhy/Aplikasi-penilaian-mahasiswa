using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class MahasiswaRepositories : IRepositories<MahasiswaViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public MahasiswaRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MahasiswaViewModel ChangeStatus(int id, bool status)
        {
            MahasiswaViewModel result = new MahasiswaViewModel();
            try
            {
                Mahasiswa entity = _dbContext.Mahasiswas
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = 1;
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new MahasiswaViewModel
                    {
                        Id = entity.Id,
                        Nama_Mahasiswa = entity.Nama_Mahasiswa,
                        Alamat = entity.Alamat,
                        Kode_Agama = entity.Kode_Agama,
                        Kode_Jurusan = entity.Kode_Jurusan,
                        Kode_Mahasiswa = entity.Kode_Mahasiswa,
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

        public MahasiswaViewModel Create(MahasiswaViewModel model)
        {
            try
            {
                Mahasiswa entity = new Mahasiswa();
                entity.Id = model.Id;
                entity.Nama_Mahasiswa = model.Nama_Mahasiswa;
                entity.Kode_Mahasiswa = model.Kode_Mahasiswa;
                entity.Alamat = model.Alamat;
                entity.Kode_Agama = model.Kode_Agama;
                entity.Kode_Jurusan = model.Kode_Jurusan;
                entity.Is_delete = model.Is_delete;

                entity.Created_by = 1;
                entity.Created_on = DateTime.Now;

                _dbContext.Mahasiswas.Add(entity);
                _dbContext.SaveChanges(true);

                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<GetMahasiswaViewModel> GetAll()
        {
            List<GetMahasiswaViewModel> result = new List<GetMahasiswaViewModel>();
            try
            {
                result = (from o in _dbContext.Mahasiswas
                          where o.Is_delete == false
                          select new GetMahasiswaViewModel
                          {
                              Id = o.Id,
                              Kode_Mahasiswa = o.Kode_Mahasiswa,
                              Kode_Jurusan = o.Kode_Jurusan,
                              Nama_Mahasiswa = o.Nama_Mahasiswa,
                              Jurusan = new JurusanViewModel
                              {
                                  Id = o.Jurusan.Id,
                                  Kode_Jurusan = o.Jurusan.Kode_Jurusan,
                                  Status_Jurusan = o.Jurusan.Status_Jurusan,
                                  Nama_Jurusan = o.Jurusan.Nama_Jurusan,
                                  Is_delete = o.Jurusan.Is_delete
                              },
                              Alamat = o.Alamat,
                              Kode_Agama = o.Kode_Agama,
                              Agama = new AgamaViewModel
                              {
                                  Id = o.Agama.Id,
                                  Kode_Agama = o.Agama.Kode_Agama,
                                  Deskripsi = o.Agama.Deskripsi,
                                  Is_delete = o.Agama.Is_delete
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

        public GetMahasiswaViewModel GetById(int id)
        {
            GetMahasiswaViewModel result = new GetMahasiswaViewModel();
            try
            {
                result = (from o in _dbContext.Mahasiswas
                          where o.Id == id
                          select new GetMahasiswaViewModel
                          {
                              Id = o.Id,
                              Kode_Mahasiswa = o.Kode_Mahasiswa,
                              Kode_Jurusan = o.Kode_Jurusan,
                              Nama_Mahasiswa = o.Nama_Mahasiswa,
                              Jurusan = new JurusanViewModel
                              {
                                  Id = o.Jurusan.Id,
                                  Kode_Jurusan = o.Jurusan.Kode_Jurusan,
                                  Status_Jurusan = o.Jurusan.Status_Jurusan,
                                  Nama_Jurusan = o.Jurusan.Nama_Jurusan,
                                  Is_delete = o.Jurusan.Is_delete
                              },
                              Alamat = o.Alamat,
                              Kode_Agama = o.Kode_Agama,
                              Agama = new AgamaViewModel
                              {
                                  Id = o.Agama.Id,
                                  Kode_Agama = o.Agama.Kode_Agama,
                                  Deskripsi = o.Agama.Deskripsi,
                                  Is_delete = o.Agama.Is_delete
                              },
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if (result == null)
                {
                    return new GetMahasiswaViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<MahasiswaViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<GetMahasiswaViewModel> result = new List<GetMahasiswaViewModel>();
            try
            {
                var query = _dbContext.Mahasiswas
                    .Where(o => o.Nama_Mahasiswa.Contains(search) && o.Is_delete == false);

                int count = query.Count();

                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "Nama":
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Nama_Mahasiswa) : query.OrderByDescending(o => o.Nama_Mahasiswa);
                            break;
                        default:
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.Is_delete == false)
                        .Select(o => new GetMahasiswaViewModel
                        {
                            Id = o.Id,
                            Kode_Mahasiswa = o.Kode_Mahasiswa,
                            Kode_Jurusan = o.Kode_Jurusan,
                            Nama_Mahasiswa = o.Nama_Mahasiswa,
                            Jurusan = new JurusanViewModel
                            {
                                Id = o.Jurusan.Id,
                                Kode_Jurusan = o.Jurusan.Kode_Jurusan,
                                Status_Jurusan = o.Jurusan.Status_Jurusan,
                                Nama_Jurusan = o.Jurusan.Nama_Jurusan,
                                Is_delete = o.Jurusan.Is_delete
                            },
                            Alamat = o.Alamat,
                            Kode_Agama = o.Kode_Agama,
                            Agama = new AgamaViewModel
                            {
                                Id = o.Agama.Id,
                                Kode_Agama = o.Agama.Kode_Agama,
                                Deskripsi = o.Agama.Deskripsi,
                                Is_delete = o.Agama.Is_delete
                            },
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

        public MahasiswaViewModel Update(MahasiswaViewModel model)
        {
            try
            {
                Mahasiswa entity = _dbContext.Mahasiswas
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Nama_Mahasiswa = model.Nama_Mahasiswa;
                    entity.Kode_Mahasiswa = model.Kode_Mahasiswa;
                    entity.Alamat = model.Alamat;
                    entity.Kode_Agama = model.Kode_Agama;
                    entity.Kode_Jurusan = model.Kode_Jurusan;
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

        List<MahasiswaViewModel> IRepositories<MahasiswaViewModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        MahasiswaViewModel IRepositories<MahasiswaViewModel>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
