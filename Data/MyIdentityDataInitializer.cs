using Microsoft.AspNetCore.Identity;

namespace DotNet_lab_lista_10.Data
{
    public class MyIdentityDataInitializer
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin",
                };
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("RegularUser").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "RegularUser",
                };
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

        }

        public static void SeedOneUser(UserManager<IdentityUser> userManager, string name, string password, string role = null)
        {
            if (userManager.FindByNameAsync(name).Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = name, // musi być taki sam jak email, inaczej nie zadziała
                    Email = name
                };

                IdentityResult result = userManager.CreateAsync(user, password).Result;
                if (result.Succeeded && role != null)
                {
                    userManager.AddToRoleAsync(user, role).Wait();
                }
            }
        }
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            SeedOneUser(userManager, "adminuser@localhost", "admin!", "Admin");
            SeedOneUser(userManager, "regularuser1@localhost", "User1!", "RegularUser");
            SeedOneUser(userManager, "regularuser2@localhost", "User1!", "RegularUser");
        }
    }
}