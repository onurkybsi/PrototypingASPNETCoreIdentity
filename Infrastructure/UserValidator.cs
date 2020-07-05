using Microsoft.AspNetCore.Identity;
using PrototypingASPNETCoreIdentity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreIdentity.Infrastructure
{
    public class UserValidator : UserValidator<AppUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            var result = await base.ValidateAsync(manager, user);

            List<IdentityError> errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();

            if (!user.Email.ToLower().EndsWith("@onurkayabasi.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only onurkayabasi.com email addresses are allowed!"
                });
            }

            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
        }
    }
}
