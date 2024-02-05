using ApplikasiPenilaianMahasiswa.Api.DataModel;
using Framework.Auth;
using System.Net;
using System.Net.Mail;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class AccountRepositories
    {
        private MahasiswaDbContext _dbContext;
        private IConfiguration _configuration;
        public AccountRepositories(MahasiswaDbContext dbContext, IConfiguration configuration)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public AccountViewModel Login(LoginViewModel model)
        {
            AccountViewModel result = new AccountViewModel();
            Account account = _dbContext.Accounts
                .Where(o => o.UserName == model.UserName && o.Password == Encryption.HashSha256(model.Password))
                .FirstOrDefault();

            try
            {
                if (account != null)
                {
                    result = new AccountViewModel
                    {
                        Id = account.Id,
                        UserName = account.UserName,
                        FirstName = account.FirstName,
                        LastName = account.LastName,
                        Email = account.Email,
                        Is_delete = account.Is_delete,
                    };
                    result.Roles = Roles(account.RoleGroupId);
                }
                return result;

            }
            catch
            {
                return result;
                throw;
            }
        }

        public List<string> Roles(int roleGroupId)
        {
            List<string> result = new List<string>();
            var list = _dbContext.AuthorizationGroups
                .Where(o => o.RoleGroupId == roleGroupId)
                .ToList();
            foreach (var group in list)
            {
                result.Add(group.Role);
            }
            return result;
        }

        public OtpViewModel SendOtp(string email)
        {
            OtpViewModel result = new OtpViewModel();
            try
            {
                Account account = _dbContext.Accounts
                    .Where(o => o.Email == email)
                    .FirstOrDefault();

                if (account != null)
                {
                    Random generator = new Random();
                    string otp = generator.Next(0, 1000000).ToString("D6");

                    account.Otp = otp;
                    account.OtpExpire = (DateTime.Now).AddMinutes(10);

                    result.Expire = account.OtpExpire;

                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(_configuration["OTP:UserName"], _configuration["OTP:Password"]),
                        EnableSsl = true
                    };

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress("auriwan.yasper@sci.ui.ac.id"),
                        Subject = "OTP",
                        Body = $"<h1>Hello your OTP: {otp}</h1>",
                        IsBodyHtml = true,
                    };

                    mailMessage.To.Add(account.Email);
                    smtpClient.Send(mailMessage);
                    _dbContext.SaveChanges();
                    result.Message = "OTP Just Sent";
                }
            }
            catch
            {
                result.Success = false;
                result.Message = "Email not registered!";
            }
            return result;
        }

        public OtpViewModel VerifikasiOtp(string otp)
        {
            OtpViewModel result = new OtpViewModel();
            Account account = _dbContext.Accounts
                .Where(o => o.Otp == otp)
                .FirstOrDefault();

            if (account != null)
            {
                if (DateTime.Now < account.OtpExpire)
                {
                    result.Success = true;
                    result.Expire = account.OtpExpire;
                    result.UserName = account.UserName;
                    result.Message = "Verifikasi berhasil";
                }
                else
                {
                    result.Success = false;
                    result.Message = "Otp sudah Kadaluarsa";
                }
            }
            return result;
        }

        public ChangePasswordViewModel UbahPassword(string username, string password)
        {
            ChangePasswordViewModel result = new ChangePasswordViewModel();
            Account account = _dbContext.Accounts
                .Where(o => o.UserName == username)
                .FirstOrDefault();

            if (account != null)
            {
                account.Password = Encryption.HashSha256(password);
                _dbContext.SaveChanges();

                result.Success = true;
                result.Messages = "Berhasil ubah password";
            }
            else
            {
                result.Success = false;
                result.Messages = "Terjadi kesalahan, Gagal ubah password";
            }
            return result;
        }


    }
}
