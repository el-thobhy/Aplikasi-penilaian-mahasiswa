using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Security;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class NilaiRepositories : IRepositories<NilaiViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public NilaiRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public NilaiViewModel ChangeStatus(int id, bool status)
        {
            NilaiViewModel result = new NilaiViewModel();
            try
            {
                Nilai entity = _dbContext.Nilais
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = ClaimsContext.UserName();
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new NilaiViewModel
                    {
                        Id = entity.Id,
                        Id_Mahasiswa = entity.Id_Mahasiswa,
                        Id_Ujian = entity.Id_Ujian,
                        NilaiMahasiswa = entity.NilaiMahasiswa,
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

        public NilaiViewModel Create(NilaiViewModel model)
        {
            try
            {
                Nilai entity = new Nilai();
                entity.Id = model.Id;
                entity.Id_Mahasiswa = model.Id_Mahasiswa;
                entity.Id_Ujian = model.Id_Ujian;
                entity.NilaiMahasiswa = model.NilaiMahasiswa;
                entity.Is_delete = model.Is_delete;

                entity.Created_by = ClaimsContext.UserName();
                entity.Created_on = DateTime.Now;

                _dbContext.Nilais.Add(entity);
                _dbContext.SaveChanges(true);

                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<GetNilaiViewModel> GetAll()
        {
            List<GetNilaiViewModel> result = new List<GetNilaiViewModel>();
            try
            {
                result = (from o in _dbContext.Nilais
                          where o.Is_delete == false
                          select new GetNilaiViewModel
                          {
                              Id = o.Id,
                              Id_Mahasiswa = o.Id_Mahasiswa,
                              Id_Ujian = o.Id_Ujian,
                              NilaiMahasiswa = o.NilaiMahasiswa,
                              Mahasiswa = new GetMahasiswaViewModel
                              {
                                  Id = o.Mahasiswa.Id,
                                  Kode_Mahasiswa = o.Mahasiswa.Kode_Mahasiswa,
                                  Id_Jurusan = o.Mahasiswa.Id_Jurusan,
                                  Nama_Mahasiswa = o.Mahasiswa.Nama_Mahasiswa,
                                  Jurusan = new JurusanViewModel
                                  {
                                      Id = o.Mahasiswa.Jurusan.Id,
                                      Kode_Jurusan = o.Mahasiswa.Jurusan.Kode_Jurusan,
                                      Status_Jurusan = o.Mahasiswa.Jurusan.Status_Jurusan,
                                      Nama_Jurusan = o.Mahasiswa.Jurusan.Nama_Jurusan,
                                      Is_delete = o.Mahasiswa.Jurusan.Is_delete
                                  },
                                  Alamat = o.Mahasiswa.Alamat,
                                  Id_Agama = o.Mahasiswa.Id_Agama,
                                  Agama = new AgamaViewModel
                                  {
                                      Id = o.Mahasiswa.Agama.Id,
                                      Kode_Agama = o.Mahasiswa.Agama.Kode_Agama,
                                      Deskripsi = o.Mahasiswa.Agama.Deskripsi,
                                      Is_delete = o.Mahasiswa.Agama.Is_delete
                                  },
                                  Is_delete = o.Mahasiswa.Is_delete
                              },
                              Ujian = new UjianViewModel
                              {
                                  Id = o.Ujian.Id,
                                  Kode_Ujian = o.Ujian.Kode_Ujian,
                                  Nama_Ujian = o.Ujian.Nama_Ujian,
                                  Status_Ujian = o.Ujian.Status_Ujian
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

        public GetNilaiViewModel GetById(int id)
        {
            GetNilaiViewModel result = new GetNilaiViewModel();
            try
            {
                result = (from o in _dbContext.Nilais
                          where o.Id == id
                          select new GetNilaiViewModel
                          {
                              Id = o.Id,
                              Id_Mahasiswa = o.Id_Mahasiswa,
                              Id_Ujian = o.Id_Ujian,
                              NilaiMahasiswa = o.NilaiMahasiswa,
                              Mahasiswa = new GetMahasiswaViewModel
                              {
                                  Id = o.Mahasiswa.Id,
                                  Kode_Mahasiswa = o.Mahasiswa.Kode_Mahasiswa,
                                  Id_Jurusan = o.Mahasiswa.Id_Jurusan,
                                  Nama_Mahasiswa = o.Mahasiswa.Nama_Mahasiswa,
                                  Jurusan = new JurusanViewModel
                                  {
                                      Id = o.Mahasiswa.Jurusan.Id,
                                      Kode_Jurusan = o.Mahasiswa.Jurusan.Kode_Jurusan,
                                      Status_Jurusan = o.Mahasiswa.Jurusan.Status_Jurusan,
                                      Nama_Jurusan = o.Mahasiswa.Jurusan.Nama_Jurusan,
                                      Is_delete = o.Mahasiswa.Jurusan.Is_delete
                                  },
                                  Alamat = o.Mahasiswa.Alamat,
                                  Id_Agama = o.Mahasiswa.Id_Agama,
                                  Agama = new AgamaViewModel
                                  {
                                      Id = o.Mahasiswa.Agama.Id,
                                      Kode_Agama = o.Mahasiswa.Agama.Kode_Agama,
                                      Deskripsi = o.Mahasiswa.Agama.Deskripsi,
                                      Is_delete = o.Mahasiswa.Agama.Is_delete
                                  },
                                  Is_delete = o.Mahasiswa.Is_delete
                              },
                              Ujian = new UjianViewModel
                              {
                                  Id = o.Ujian.Id,
                                  Kode_Ujian = o.Ujian.Kode_Ujian,
                                  Nama_Ujian = o.Ujian.Nama_Ujian,
                                  Status_Ujian = o.Ujian.Status_Ujian
                              },
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if (result == null)
                {
                    return new GetNilaiViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<NilaiViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<GetNilaiViewModel> result = new List<GetNilaiViewModel>();
            try
            {
                var query = _dbContext.Nilais
                    .Where(o => o.Mahasiswa.Nama_Mahasiswa.Contains(search) && o.Is_delete == false);

                int count = query.Count();

                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "Nama":
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Mahasiswa.Nama_Mahasiswa) : query.OrderByDescending(o => o.Mahasiswa.Nama_Mahasiswa);
                            break;
                        default:
                            query = (sort == Sorting.Ascending) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.Is_delete == false)
                        .Select(o => new GetNilaiViewModel
                        {
                            Id = o.Id,
                            Id_Mahasiswa = o.Id_Mahasiswa,
                            Id_Ujian = o.Id_Ujian,
                            NilaiMahasiswa = o.NilaiMahasiswa,
                            Mahasiswa = new GetMahasiswaViewModel
                            {
                                Id = o.Mahasiswa.Id,
                                Kode_Mahasiswa = o.Mahasiswa.Kode_Mahasiswa,
                                Id_Jurusan = o.Mahasiswa.Id_Jurusan,
                                Nama_Mahasiswa = o.Mahasiswa.Nama_Mahasiswa,
                                Jurusan = new JurusanViewModel
                                {
                                    Id = o.Mahasiswa.Jurusan.Id,
                                    Kode_Jurusan = o.Mahasiswa.Jurusan.Kode_Jurusan,
                                    Status_Jurusan = o.Mahasiswa.Jurusan.Status_Jurusan,
                                    Nama_Jurusan = o.Mahasiswa.Jurusan.Nama_Jurusan,
                                    Is_delete = o.Mahasiswa.Jurusan.Is_delete
                                },
                                Alamat = o.Mahasiswa.Alamat,
                                Id_Agama = o.Mahasiswa.Id_Agama,
                                Agama = new AgamaViewModel
                                {
                                    Id = o.Mahasiswa.Agama.Id,
                                    Kode_Agama = o.Mahasiswa.Agama.Kode_Agama,
                                    Deskripsi = o.Mahasiswa.Agama.Deskripsi,
                                    Is_delete = o.Mahasiswa.Agama.Is_delete
                                },
                                Is_delete = o.Mahasiswa.Is_delete
                            },
                            Ujian = new UjianViewModel
                            {
                                Id = o.Ujian.Id,
                                Kode_Ujian = o.Ujian.Kode_Ujian,
                                Nama_Ujian = o.Ujian.Nama_Ujian,
                                Status_Ujian = o.Ujian.Status_Ujian
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

        public NilaiViewModel Update(NilaiViewModel model)
        {
            try
            {
                Nilai entity = _dbContext.Nilais
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Id_Mahasiswa = model.Id_Mahasiswa;
                    entity.Id_Ujian = model.Id_Ujian;
                    entity.NilaiMahasiswa = model.NilaiMahasiswa;
                    entity.Is_delete = model.Is_delete;

                    entity.Modified_by = ClaimsContext.UserName();
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

        List<NilaiViewModel> IRepositories<NilaiViewModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        NilaiViewModel IRepositories<NilaiViewModel>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
