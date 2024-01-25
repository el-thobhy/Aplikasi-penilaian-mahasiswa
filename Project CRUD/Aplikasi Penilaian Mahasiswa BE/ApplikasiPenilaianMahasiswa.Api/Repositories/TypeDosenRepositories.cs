using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class TypeDosenRepositories : IRepositories<TypeDosenViewModel>
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();

        public TypeDosenRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TypeDosenViewModel ChangeStatus(int id, bool status)
        {
            TypeDosenViewModel result = new TypeDosenViewModel();
            try
            {
                TypeDosen entity = _dbContext.TypeDosens
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                if (entity != null)
                {
                    entity.Is_delete = status;
                    entity.Deleted_by = 1;
                    entity.Deleted_on = DateTime.Now;

                    _dbContext.SaveChanges();
                    result = new TypeDosenViewModel
                    {
                        Id = entity.Id,
                        Deskripsi = entity.Deskripsi,
                        Kode_Type_Dosen = entity.Kode_Type_Dosen,
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

        public TypeDosenViewModel Create(TypeDosenViewModel model)
        {
            try
            {
                string newKode = NewKode();
                if (!string.IsNullOrEmpty(newKode))
                {
                    TypeDosen entity = new TypeDosen();
                    entity.Id = model.Id;
                    entity.Deskripsi = model.Deskripsi;
                    entity.Kode_Type_Dosen = newKode;
                    entity.Is_delete = model.Is_delete;

                    entity.Created_by = 1;
                    entity.Created_on = DateTime.Now;

                    _dbContext.TypeDosens.Add(entity);
                    _dbContext.SaveChanges(true);

                    model.Id = entity.Id;
                    model.Kode_Type_Dosen = entity.Kode_Type_Dosen;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<TypeDosenViewModel> GetAll()
        {
            List<TypeDosenViewModel> result = new List<TypeDosenViewModel>();
            try
            {
                result = (from o in _dbContext.TypeDosens
                          where o.Is_delete == false
                          select new TypeDosenViewModel
                          {
                              Id = o.Id,
                              Kode_Type_Dosen = o.Kode_Type_Dosen,
                              Deskripsi = o.Deskripsi,
                              Is_delete = o.Is_delete
                          }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public TypeDosenViewModel GetById(int id)
        {
            TypeDosenViewModel result = new TypeDosenViewModel();
            try
            {
                result = (from o in _dbContext.TypeDosens
                          where o.Id == id
                          select new TypeDosenViewModel
                          {
                              Id = o.Id,
                              Deskripsi = o.Deskripsi,
                              Kode_Type_Dosen = o.Kode_Type_Dosen,
                              Is_delete = o.Is_delete
                          }).FirstOrDefault();
                if (result == null)
                {
                    return new TypeDosenViewModel();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<TypeDosenViewModel> GetByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            List<TypeDosenViewModel> result = new List<TypeDosenViewModel>();
            try
            {
                var query = _dbContext.TypeDosens
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
                        .Select(o => new TypeDosenViewModel
                        {
                            Id = o.Id,
                            Kode_Type_Dosen = o.Kode_Type_Dosen,
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

        public TypeDosenViewModel Update(TypeDosenViewModel model)
        {
            try
            {
                TypeDosen entity = _dbContext.TypeDosens
                    .Where(o => o.Id == model.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.Deskripsi = model.Deskripsi;
                    entity.Kode_Type_Dosen = model.Kode_Type_Dosen;
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
            string newRef = "TYP-" + yearMonth + "-"; //SLS-2311-
            try
            {
                var maxRef = _dbContext.TypeDosens
                    .Where(o => o.Kode_Type_Dosen.Contains(newRef))
                    .OrderByDescending(o => o.Kode_Type_Dosen)
                    .FirstOrDefault();

                if (maxRef != null)
                {
                    //SLS-2311-0002
                    string[] oldRef = maxRef.Kode_Type_Dosen.Split('-'); // ['SLS','2311','0002']
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
