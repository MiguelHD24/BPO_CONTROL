using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Roles
	{
		 public static Roles Insert (Roles Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 bd.Roles.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Roles Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 var Registro = bd.Roles.Find(Entidad.ID_Rol);
				 Registro.Rol_Nombres = Entidad.Rol_Nombres;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Roles Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 var Registro = bd.Roles.Find(Entidad.ID_Rol);
				 return bd.SaveChanges() > 0;
			}
		}
		//metodo para mostrar los roles en el combobox
		public static List<Roles> ListarRoles()
		{
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
			{
                return bd.Roles.ToList();
            }
        }
		 public static bool Existe (Roles Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 return bd.Roles.Where(a=>a.ID_Rol == Entidad.ID_Rol).Count() > 0;
			}
		}
		 public static Roles Registro (Roles Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 return bd.Roles.Where(a=>a.ID_Rol == Entidad.ID_Rol).SingleOrDefault();
			}
		}
		 
	}
}
