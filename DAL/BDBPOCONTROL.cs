using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DAL
{
	 public class BDBPOCONTROL:DbContext
	{
		public BDBPOCONTROL():base(Conexion.ConexionString(true)){}
		 public virtual DbSet<Registro> Registro{get;set;}
		 public virtual DbSet<Roles> Roles{get;set;}
		 public virtual DbSet<Tareas> Tareas{get;set;}
		 public virtual DbSet<Usuario> Usuario{get;set;}
		 protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Roles>().Property(e => e.Rol_Nombres).IsUnicode(false);
			modelBuilder.Entity<Tareas>().Property(e => e.Tareas_Nombres).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Nombres).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Apellidos).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.NumeroCedula).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Password).IsUnicode(false);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			 base.OnModelCreating(modelBuilder);
		}
		}
	}
