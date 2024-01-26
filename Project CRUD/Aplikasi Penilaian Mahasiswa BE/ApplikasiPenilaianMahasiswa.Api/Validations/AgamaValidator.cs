using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class AgamaValidator : AbstractValidator<AgamaViewModel>
    {
        //private XCommDbContext _dbContext;
        public AgamaValidator(MahasiswaDbContext dbContext)
        {
            //_dbContext = dbContext;

            RuleFor(x => new { x.Deskripsi, x.Id })
                .Must(x =>
                {
                    if ((x.Id != null ? x.Id : 0) != 0)
                        return !dbContext.Agamas.Where(o => o.Deskripsi == x.Deskripsi && o.Id != x.Id).Any();
                    else
                        return !dbContext.Agamas.Where(o => o.Deskripsi == x.Deskripsi).Any();

                })
                .WithName("deskripsi")
                .WithMessage("Agama Sudah Ada");
        }
    }
}
