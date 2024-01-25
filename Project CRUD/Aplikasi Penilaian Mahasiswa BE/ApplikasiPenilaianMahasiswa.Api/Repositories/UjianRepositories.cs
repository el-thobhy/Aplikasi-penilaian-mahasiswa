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
                string newKode = NewKode();
                if (!string.IsNullOrEmpty(newKode))
                {
                    Ujian entity = new Ujian();
                    entity.Id = model.Id;
                    entity.Nama_Ujian = model.Nama_Ujian;
                    entity.Status_Ujian = model.Status_Ujian;
                    entity.Kode_Ujian = newKode;
                    entity.Is_delete = model.Is_delete;

                    entity.Created_by = 1;
                    entity.Created_on = DateTime.Now;

                    _dbContext.Ujians.Add(entity);
                    _dbContext.SaveChanges(true);

                    model.Id = entity.Id;
                    model.Kode_Ujian = entity.Kode_Ujian;
                }
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
        private string NewKode()
        {
            //    yyMM incr
            //SLS-2311-0123
            string yearMonth = DateTime.Now.ToString("yy") + DateTime.Now.Month.ToString("D2"); //2311
            string newRef = "UJN-" + yearMonth + "-"; //SLS-2311-
            try
            {
                var maxRef = _dbContext.Ujians
                    .Where(o => o.Kode_Ujian.Contains(newRef))
                    .OrderByDescending(o => o.Kode_Ujian)
                    .FirstOrDefault();

                if (maxRef != null)
                {
                    //SLS-2311-0002
                    string[] oldRef = maxRef.Kode_Ujian.Split('-'); // ['SLS','2311','0002']
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
    }
}
