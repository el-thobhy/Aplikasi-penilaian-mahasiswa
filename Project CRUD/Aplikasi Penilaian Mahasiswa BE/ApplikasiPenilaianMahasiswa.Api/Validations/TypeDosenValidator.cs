using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class TypeDosenValidator : AbstractValidator<TypeDosenViewModel>
    {
        //private XCommDbContext _dbContext;
        public TypeDosenValidator(MahasiswaDbContext dbContext)
        {
            //_dbContext = dbContext;

            RuleFor(x => new { x.Deskripsi, x.Id })
                .Must(x =>
                {
                    if ((x.Id != null ? x.Id : 0) != 0)
                        return !dbContext.TypeDosens.Where(o => o.Deskripsi == x.Deskripsi && o.Id != x.Id).Any();
                    else
                        return !dbContext.TypeDosens.Where(o => o.Deskripsi == x.Deskripsi).Any();

                })
                .WithName("deskripsi")
                .WithMessage("Deskripsi Sudah Ada");
        }
    }
}
