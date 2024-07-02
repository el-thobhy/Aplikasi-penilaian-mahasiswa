using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApplikasiPenilaianMahasiswa.Api.Security
{
    public class ReadableBodyStreamAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userName = context.HttpContext.User.Claims.First(claim => claim.Type == ClaimTypes.Name).Value;
            new ClaimsContext(userName);
        }
    }

    public class ClaimsContext
    {
        private static string? _UserName;
        public ClaimsContext(string userName)
        {
            _UserName = userName;
        }

        public static string? UserName()
        {
            return _UserName;
        }
    }
}