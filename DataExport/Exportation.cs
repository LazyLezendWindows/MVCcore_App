using Microsoft.EntityFrameworkCore;
using MVCore_App.Models;

namespace MVCore_App.DataExport
{
    public class Exportation : DbContext
    {

        public Exportation(DbContextOptions<Exportation> options) : base(options)
        {
            Options = options;
        }

        public DbContextOptions<Exportation> Options { get; }

        public DbSet<SRegistrationModel> sRegistrationModels { get; set; }
    }
}
