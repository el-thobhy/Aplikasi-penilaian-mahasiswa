using ApplikasiPenilaianMahasiswa.Api.DataModel;
using Framework.Auth;
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
            foreach(var group in list)
            {
                result.Add(group.Role);
            }
            return result;
        }
    }
}
