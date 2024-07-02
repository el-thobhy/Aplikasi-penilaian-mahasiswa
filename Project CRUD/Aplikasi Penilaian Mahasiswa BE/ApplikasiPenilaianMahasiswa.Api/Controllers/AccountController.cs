﻿using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Repositories;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IConfiguration _configuration;
        private AccountRepositories _repo;
        private IValidator<LoginViewModel> _validator;
        private IValidator<string> _validatorEmail;
        private IValidator<RegisterViewModel> _validatorRegis;
        private IValidator<AccountViewModel> _validatorOtp;

        public AccountController(
            MahasiswaDbContext dbContext,
            IConfiguration configuration,
            IValidator<LoginViewModel> validator,
            IValidator<string> validatorEmail,
            IValidator<AccountViewModel> validatorOtp,
            IValidator<RegisterViewModel> validatorRegis)
        {
            _repo = new AccountRepositories(dbContext, configuration);
            _configuration = configuration;
            _validator = validator;
            _validatorEmail = validatorEmail;
            _validatorOtp = validatorOtp;
            _validatorRegis = validatorRegis;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            AccountViewModel result = _repo.Login(model);
            ValidationResult validate = await _validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return BadRequest(validate.Errors);
            }
            else
            {
                if (result.UserName != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, result.UserName),
                        new Claim("FirstName", result.FirstName),
                        new Claim("LastName", result.LastName)
                    };
                    foreach (var role in result.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var token = GetToken(claims);
                    result.Otp = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(result);
                }
                else
                {
                    List<object> resultError = new List<object>
                    {
                        new
                        {
                            propertyName = "Password",
                            errorMessage = "Password Salah"
                        }
                    };
                    return NotFound(resultError);
                }
            }
        }

        private JwtSecurityToken GetToken(List<Claim> claims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddDays(Convert.ToDouble(_configuration["JWT:Expires"])),
                claims: claims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

            return token;
        }

        [HttpPost("SendOtp")]
        public async Task<IActionResult> Post(bool regis, string email)
        {
            OtpViewModel result = _repo.SendOtp(regis, email);
            if (regis == false)
            {
                ValidationResult validate = await _validatorEmail.ValidateAsync(email);
                if (!validate.IsValid)
                {
                    return BadRequest(validate.Errors);
                }
                else
                {
                    if (result.Success)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            else
            {
                RegisterViewModel model = new RegisterViewModel
                {
                    Email = email
                };
                ValidationResult validate = await _validatorRegis.ValidateAsync(model);
                if (!validate.IsValid)
                {
                    return BadRequest(validate.Errors);
                }
                else
                {
                    if (result.Success)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound(result);
                    }
                }
            }
        }

        [HttpPost("VerifikasiOtp")]
        public async Task<IActionResult> Verifikasi(string Otp)
        {
            OtpViewModel result = _repo.VerifikasiOtp(Otp);
            AccountViewModel account = new AccountViewModel();
            account.Otp = Otp;
            ValidationResult validate = await _validatorOtp.ValidateAsync(account);
            if (!validate.IsValid)
            {
                return BadRequest(validate.Errors);
            }
            else
            {
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound(result);
                }
            }
        }
        [HttpPost("UbahPassword")]
        public async Task<IActionResult> UbahPassword(string username, string password)
        {
            ChangePasswordViewModel result = _repo.UbahPassword(username, password);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result.Messages);
            }
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> Registration(RegisterViewModel model)
        {
            ValidationResult validate = await _validatorRegis.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return BadRequest(validate.Errors);
            }
            else
            {
                return Ok(_repo.Register(model));
            }
        }
    }
}
