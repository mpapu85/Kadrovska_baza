using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne<City>(gr => gr.PlaceOfBirth)
                .WithMany(zgr => zgr.EmployeePlaceOfBirth)
                .HasForeignKey(gri => gri.PlaceOfBirthId);
            modelBuilder.Entity<Employee>()
                .HasOne<City>(gs => gs.PlaceOfResidence)
                .WithMany(zds => zds.EmployeePlaceOfResidence).OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(gsi => gsi.PlaceOfResidenceId);
            modelBuilder.Entity<Employee>()
                .HasOne<Community>(c => c.CommunityOfBirth)
                .WithMany(ecr => ecr.EmployeeCommunityOfBirth)
                .HasForeignKey(cor => cor.CommunityOfBirthId);
            modelBuilder.Entity<Employee>()
                .HasOne<Community>(os => os.CommunityOfResidence)
                .WithMany(zos => zos.EmployeeCommunityOfResidence).OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(osi => osi.CommunityOfResidenceId);
            modelBuilder.Entity<Employee>()
                .HasOne<ReasonForTermination>(r => r.ReasonForTermination)
                .WithMany(r => r.Employees).OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(r=>r.ReasonForTerminationId);
            modelBuilder.Entity<Employee>()
                .HasOne<Organization>(o => o.Organization)
                .WithMany(e => e.Employees).OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(r => r.OrganizationID);
            
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<ProfessionalQualification> ProfessionalQualifications { get; set; }
        public DbSet<LevelOfEducation> LevelOfEducations { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Sex> Sexs { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<ReasonForTermination> ReasonForTerminations { get; set; }

    }
}
