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
                        Id_Type_Dosen = entity.Id_Type_Dosen,
                        Id_Jurusan = entity.Id_Jurusan,
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
                string newKode = NewKode();
                if(!string.IsNullOrEmpty(newKode))
                {
                    Dosen entity = new Dosen();
                    entity.Id = model.Id;
                    entity.Nama_Dosen = model.Nama_Dosen;
                    entity.Id_Type_Dosen = model.Id_Type_Dosen;
                    entity.Id_Jurusan = model.Id_Jurusan;
                    entity.Kode_Dosen = newKode;
                    entity.Is_delete = model.Is_delete;

                    entity.Created_by = 1;
                    entity.Created_on = DateTime.Now;

                    _dbContext.Dosens.Add(entity);
                    _dbContext.SaveChanges(true);

                    model.Id = entity.Id;
                    model.Kode_Dosen = entity.Kode_Dosen;
                }
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
                              Id_Jurusan = o.Id_Jurusan,
                              Id_Type_Dosen = o.Id_Type_Dosen,
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
                              Id_Type_Dosen = o.Id_Type_Dosen,
                              Id_Jurusan = o.Id_Jurusan,
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
                            Id_Type_Dosen = o.Id_Type_Dosen,
                            Id_Jurusan = o.Id_Jurusan,
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
                    entity.Id_Type_Dosen = model.Id_Type_Dosen;
                    entity.Id_Jurusan = model.Id_Jurusan;
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
        private string NewKode()
        {
            //    yyMM incr
            //SLS-2311-0123
            string yearMonth = DateTime.Now.ToString("yy") + DateTime.Now.Month.ToString("D2"); //2311
            string newRef = "DSN-" + yearMonth + "-"; //SLS-2311-
            try
            {
                var maxRef = _dbContext.Dosens
                    .Where(o => o.Kode_Dosen.Contains(newRef))
                    .OrderByDescending(o => o.Kode_Dosen)
                    .FirstOrDefault();

                if (maxRef != null)
                {
                    //SLS-2311-0002
                    string[] oldRef = maxRef.Kode_Dosen.Split('-'); // ['SLS','2311','0002']
                    int newInc = int.Parse(oldRef[2]) + 1; // 0003
                    newRef += newInc.ToString("D4"); //SLS-2311-0003
                }
                else
                {
                    newRef += "0001"; //SLS-2311-0001
                }
            }
            catch (Exception)
            {
                newRef = string.Empty;
            }
            return newRef;
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
