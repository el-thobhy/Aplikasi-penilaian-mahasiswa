using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {
        public LoginValidator(MahasiswaDbContext dbContext)
        {
            RuleFor(x => x.UserName)
                .Must(username =>
                {
                    return dbContext.Accounts.Where(o => o.UserName == username).Any();
                })
                .WithName("UserName")
                .WithMessage("Username Tidak Ditemukan");
        }
    }
}
