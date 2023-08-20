using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Tareas
	{
		 public static Tareas Insert (Tareas Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 bd.Tareas.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Tareas Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 var Registro = bd.Tareas.Find(Entidad.ID_Tareas);
				 Registro.Tareas_Nombres = Entidad.Tareas_Nombres;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Tareas Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 var Registro = bd.Tareas.Find(Entidad.ID_Tareas);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Tareas Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 return bd.Tareas.Where(a=>a.ID_Tareas == Entidad.ID_Tareas).Count() > 0;
			}
		}
		 public static Tareas Registro (Tareas Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 return bd.Tareas.Where(a=>a.ID_Tareas == Entidad.ID_Tareas).SingleOrDefault();
			}
		}
        //Metodo que verifique si existe el Tareas_Nombres y me retorne su ID
		public static int ExisteTarea(string Tareas_Nombres)
		{
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
			{
                var Registro = bd.Tareas.Where(a => a.Tareas_Nombres == Tareas_Nombres).SingleOrDefault();
                if (Registro != null)
				{
                    return Registro.ID_Tareas;
                }
                else
				{
                    return 0;
                }
            }
        }

    }
}
