using MAGNA_SERVER.DataAccess.Configurations;
using MAGNA_SERVER.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.DataAccess
{
    public class ApiDbContext : IdentityDbContext
    {
        /// <summary>
        /// Create the database context for each of the objects we want
        ///that they persist
        /// </summary>
        public DbSet<Assemble> Assemble { get; set; }
        public DbSet<SubAssemble> AssembleVersion { get; set; }
        public DbSet<AssembleType> AssembleType { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Departament> Departament { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<NoticePriority> NoticePriority { get; set; }
        public DbSet<NoticeCategory> NoticeCategory { get; set; }
        public DbSet<NoticeType> NoticeType { get; set; }
        public DbSet<NoticeState> NoticeState { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }
        public DbSet<WorkOrderState> WorkOrderState { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<TechnicalLocation> TechnicalLocation { get; set; }
        /// <summary>
        /// builder apiDbContext
        /// </summary>
        /// <remarks>
        /// the constructor receives a dbcontextoptions object as parameters.This object s necessary to be able 
        /// to obtain the configuration and options that the entity framework needs.The Dbcontext class, which 
        /// is the parent class of this hierarchy, is passed through the constructor.
        /// </remarks>
        /// <param name="options"></param>
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {
           
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = BD_MAGNA_TEST; Integrated Security=true;")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }       
        /// <summary>
        /// override OModelCreating
        /// </summary>
        /// <remarks>
        ///we override OModelCreating this operation allows us to configure what we want to happen when the database model 
        ///is created when executing the application and creating the migration To prevent tables from being created that we don't need
        /// </remarks>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();     
            base.OnModelCreating(modelBuilder);

          
            



        }
    }
}
