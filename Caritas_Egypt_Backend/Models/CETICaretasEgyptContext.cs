using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caritas_Egypt_Backend.Models;
namespace Caritas_Egypt_Backend.Models
{
    public partial class CETICaretasEgyptContext  : DbContext
    {
        public CETICaretasEgyptContext()
        {
        }
        public CETICaretasEgyptContext(DbContextOptions<CETICaretasEgyptContext> options) : base(options)
        {
        }


        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TypeOfDisability> TypeOfDisabilitys { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<StudentParent> StudentParents { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<StudentNationality> StudentNationalities { get; set; }
        public virtual DbSet<CoursePrice> CoursePrices { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<SessionTime> SessionTimes { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<SessionReservations> SessionReservation { get; set; }
        public virtual DbSet<ProgramsCategoryFE> ProgramsCategoryFEs { get; set; }
        public virtual DbSet<ProjectsCategoryFE> ProjectsCategoryFEs { get; set; }
        public virtual DbSet<ActivitiesAndEventsFE> ActivitiesAndEventsFEs { get; set; }
        public virtual DbSet<OurPartnersFE> OurPartnersFEs { get; set; }
        public virtual DbSet<ProgramsFE> ProgramsFEs { get; set; }
        public virtual DbSet<ProjectsFE> ProjectsFEs { get; set; }
        public virtual DbSet<DiscriptionList> DiscriptionLists { get; set; }
        public virtual DbSet<TrainingCourses> TrainingCoursess { get; set; }
        public virtual DbSet<TrainingFE> TrainingFEs { get; set; }
        public virtual DbSet<JobFE> JobFEs { get; set; }
        
        
        protected void OnModuleCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        
      

       


    }
}
