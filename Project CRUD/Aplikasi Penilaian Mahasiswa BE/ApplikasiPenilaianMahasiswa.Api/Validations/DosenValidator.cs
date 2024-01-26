using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class DosenValidator : AbstractValidator<DosenViewModel>
    {
        //private XCommDbContext _dbContext;
        public DosenValidator(MahasiswaDbContext dbContext)
        {
            //_dbContext = dbContext;

            RuleFor(x => new { x.Nama_Dosen, x.Id })
                .Must(x =>
                {
                    if ((x.Id != null ? x.Id : 0) != 0)
                        return !dbContext.Dosens.Where(o => o.Nama_Dosen == x.Nama_Dosen && o.Id != x.Id).Any();
                    else
                        return !dbContext.Dosens.Where(o => o.Nama_Dosen == x.Nama_Dosen).Any();

                })
                .WithName("nama_Dosen")
                .WithMessage("Dosen Sudah Ada");
        }
    }
}
