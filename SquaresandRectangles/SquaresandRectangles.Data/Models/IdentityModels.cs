using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Configuration;

namespace SquaresandRectangles.Data.Models
{

    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //ConnectionStringSettings set = new ConnectionStringSettings("Test String", "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BitAbridged;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        //ConfigurationManager
        //    .ConnectionStrings.Add(set);
        //System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString= new ConnectionStringSettings
        //{
        //    Name = "DefaultConnection",
        //    ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BitAbridged;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        //}

        public ApplicationDbContext()
            : base("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SR;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}