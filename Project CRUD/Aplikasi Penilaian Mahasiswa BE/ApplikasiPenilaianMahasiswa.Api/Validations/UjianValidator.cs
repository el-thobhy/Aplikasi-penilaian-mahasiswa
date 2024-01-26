using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class UjianValidator : AbstractValidator<UjianViewModel>
    {
        //private XCommDbContext _dbContext;
        public UjianValidator(MahasiswaDbContext dbContext)
        {
            //_dbContext = dbContext;

            RuleFor(x => new { x.Nama_Ujian, x.Id })
                .Must(x =>
                {
                    if ((x.Id != null ? x.Id : 0) != 0)
                        return !dbContext.Ujians.Where(o => o.Nama_Ujian == x.Nama_Ujian && o.Id != x.Id).Any();
                    else
                        return !dbContext.Ujians.Where(o => o.Nama_Ujian == x.Nama_Ujian).Any();

                })
                .WithName("nama_Ujian")
                .WithMessage("Ujian Sudah Ada");
        }
    }
}
