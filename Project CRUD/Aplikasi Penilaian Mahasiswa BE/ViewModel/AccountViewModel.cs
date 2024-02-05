using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LoginViewModel
    {
        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(200)]
        public string Password { get; set; }
    }

    public class AccountViewModel
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Is_delete { get; set; }
        public string Otp { get; set; }
        public List<string> Roles { get; set; }
    }
    public class RegisterViewModel: LoginViewModel
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, DataType(DataType.EmailAddress), MaxLength(200)]
        public string Email { get; set; }
    }
}
