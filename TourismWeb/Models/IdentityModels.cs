using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TourismWeb.Models
{
    // 您可以在 ApplicationUser 類別新增更多屬性，為使用者新增設定檔資料，請造訪 http://go.microsoft.com/fwlink/?LinkID=317594 以深入了解。
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // 注意 authenticationType 必須符合 CookieAuthenticationOptions.AuthenticationType 中定義的項目
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // 在這裡新增自訂使用者宣告
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            
            
            modelBuilder.Entity<IdentityUser>().ToTable("MyUsers", "dbo").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<ApplicationUser>().ToTable("MyUsers", "dbo").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("MyUserRoles", "dbo");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("MyUserLogins", "dbo");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("MyUserClaims", "dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("MyRoles", "dbo");

            modelBuilder.Entity<Blog>().ToTable("BlogMainFiles").Property(p => p.Id);
            //var blogTable = modelBuilder.Entity<Blog>().ToTable("BlogMainFiles");

           // blogTable
           //     .Property(c => c.Id)
           //     .IsRequired()
           //     .HasColumnType("bigint");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public class Blog
        {
            [Key]
            [Required]
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}