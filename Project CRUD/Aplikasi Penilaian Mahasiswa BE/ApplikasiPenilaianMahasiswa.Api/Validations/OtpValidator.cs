using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class OtpValidator : AbstractValidator<AccountViewModel>
    {
        public OtpValidator(MahasiswaDbContext dbContext)
        {
            RuleFor(x => x.Otp)
                .Must(Otp =>
                {
                    return dbContext.Accounts.Where(o => o.Otp == Otp).Any();
                })
                .WithName("Otp")
                .WithMessage("Otp tidak Sesuai");
        }
    }
}
