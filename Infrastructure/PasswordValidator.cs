using Microsoft.AspNetCore.Identity;
using PrototypingASPNETCoreIdentity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreIdentity.Infrastructure
{
    public class PasswordValidator : PasswordValidator<AppUser>
    {
        public async override Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            var result = await base.ValidateAsync(manager, user, password);

            List<IdentityError> errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();

            if (password.Contains("12345"))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsSequence",
                    Description = "Password cannot contain numeric sequence!"
                });
            }

            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
        }
    }
}
