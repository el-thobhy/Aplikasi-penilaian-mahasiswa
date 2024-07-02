using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplikasiPenilaianMahasiswa.Api.DataModel;
using FluentValidation;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class RegisterValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator(MahasiswaDbContext dbContext)
        {
            RuleFor(x => x.Email)
                .Must(email =>
                {
                    return !dbContext.Accounts.Where(o => o.Email == email).Any();
                })
                .WithName("Email")
                .WithMessage("Email Sudah Ada, Silahkan Klik Lupa Password");

            RuleFor(x => x.UserName)
            .Must(username =>
            {
                return !dbContext.Accounts.Where(o => o.UserName == username).Any();
            })
            .WithName("UserName")
            .WithMessage("Username Sudah digunakan");
        }
    }
}