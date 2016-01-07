using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace KennethCV.Models
{

    public class CVitaeDb : DbContext
    {        

        public CVitaeDb()
            : base("name=CurriculoVitaeConnection")
        {
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<KennethCV.Models.CVitaeDb>());
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Refference> Refferences { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}