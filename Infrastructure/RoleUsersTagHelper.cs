using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PrototypingASPNETCoreIdentity.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreIdentity.Infrastructure
{
    [HtmlTargetElement("td", Attributes = "role-users")]
    public class RoleUsersTagHelper : TagHelper
    {
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public RoleUsersTagHelper(UserManager<AppUser> usermgr, RoleManager<IdentityRole> rolemgr)
        {
            this._userManager = usermgr;
            this._roleManager = rolemgr;
        }

        [HtmlAttributeName("role-users")]
        public string RoleId { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var userNames = new List<string>();

            var role = await _roleManager.FindByIdAsync(RoleId);

            if(role != null)
            {
                foreach (var user in _userManager.Users)
                {
                    if(user != null && await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        userNames.Add(user.UserName);
                    }
                }
            }

            output.Content.SetContent(userNames.Count == 0 ? "No Users" : string.Join(", ", userNames));
        }
    }
}
