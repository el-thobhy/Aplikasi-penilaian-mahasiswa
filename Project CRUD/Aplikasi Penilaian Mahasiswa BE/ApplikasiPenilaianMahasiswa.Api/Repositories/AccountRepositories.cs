using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Security;
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

        public OtpViewModel SendOtp(bool regis, string email)
        {
            OtpViewModel result = new OtpViewModel();
            try
            {
                Account account = _dbContext.Accounts
                    .Where(o => o.Email == email)
                    .FirstOrDefault();

                if (account != null && regis == false)
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
                else if (regis == true && account == null)
                {
                    Random generator = new Random();
                    string otp = generator.Next(0, 1000000).ToString("D6");
                    string user = new string("user") + DateTime.Now.ToString().Split(" ")[0].Replace("/", "") + DateTime.Now.ToString().Split(" ")[1].Replace(":", "").Substring(0, 5);

                    account = new Account
                    {
                        FirstName = "",
                        LastName = "",
                        Password = "",
                        UserName = user,
                        Email = "",
                        RoleGroupId = 3,
                        Created_by = ClaimsContext.UserName(),
                        Created_on = DateTime.Now,
                        Otp = otp,
                        OtpExpire = (DateTime.Now).AddMinutes(10)
                    };

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

                    mailMessage.To.Add(email);
                    smtpClient.Send(mailMessage);

                    _dbContext.Accounts.Add(account);
                    _dbContext.SaveChanges();
                    result.Message = "OTP Just Sent";
                    result.Id = account.Id;
                }
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.ToString();
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
                    result.Id = account.Id;
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
        public AccountViewModel Register(RegisterViewModel model)
        {
            AccountViewModel result = new AccountViewModel();
            Account exist = _dbContext.Accounts
                .Where(o => o.Id == model.Id)
                .FirstOrDefault();

            if (exist != null)
            {

                exist.UserName = model.UserName;
                exist.FirstName = model.FirstName;
                exist.LastName = model.LastName;
                exist.Email = model.Email;
                exist.Password = Encryption.HashSha256(model.Password);
                exist.RoleGroupId = model.RoleGroupId;
                exist.Created_by = ClaimsContext.UserName();
                exist.Created_on = DateTime.Now;


                _dbContext.SaveChanges();

                result = new AccountViewModel
                {
                    Id = exist.Id,
                    UserName = exist.UserName,
                    FirstName = exist.FirstName,
                    LastName = exist.LastName,
                    Otp = exist.Otp,
                    Email = exist.Email,
                    Is_delete = exist.Is_delete,
                    Roles = Roles(exist.RoleGroupId)
                };
            }
            else
            {
                result = new AccountViewModel();
            }
            return result;
        }

    }
}
