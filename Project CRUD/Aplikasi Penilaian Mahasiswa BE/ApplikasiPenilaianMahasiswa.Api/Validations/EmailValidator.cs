using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class EmailValidator : AbstractValidator<string>
    {
        public EmailValidator(MahasiswaDbContext dbContext)
        {
            RuleFor(x => x)
                .Must(email =>
                {
                    return dbContext.Accounts.Where(o => o.Email == email).Any();
                })
                .WithName("Email")
                .WithMessage("Email Tidak Ditemukan");
        }
    }
}
