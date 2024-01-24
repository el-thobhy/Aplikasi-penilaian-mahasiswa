using System;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public interface IRepositories<T>
    {
        List<T> GetAll(); //hanya untuk coba2
        T GetById(int id);

        List<T> GetByParentId(int parentId);

        T Create(T model);

        ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort);

        T Update(T model);

        T ChangeStatus(int id, bool status);
    }
}
