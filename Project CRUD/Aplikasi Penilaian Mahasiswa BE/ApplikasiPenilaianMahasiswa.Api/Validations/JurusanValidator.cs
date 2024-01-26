using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class JurusanValidator : AbstractValidator<JurusanViewModel>
    {
        //private XCommDbContext _dbContext;
        public JurusanValidator(MahasiswaDbContext dbContext)
        {
            //_dbContext = dbContext;

            RuleFor(x => new { x.Nama_Jurusan, x.Id })
                .Must(x =>
                {
                    if ((x.Id != null ? x.Id : 0) != 0)
                        return !dbContext.Jurusans.Where(o => o.Nama_Jurusan == x.Nama_Jurusan && o.Id != x.Id).Any();
                    else
                        return !dbContext.Jurusans.Where(o => o.Nama_Jurusan == x.Nama_Jurusan).Any();

                })
                .WithName("nama_Jurusan")
                .WithMessage("Jurusan Sudah Ada");
        }
    }
}