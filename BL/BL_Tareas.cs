using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Tareas
	{
		 public static Tareas Insert (Tareas Entidad)
		{
			 return DAL_Tareas.Insert(Entidad);
		}
		 public static bool Update (Tareas Entidad)
		{
			 return DAL_Tareas.Update(Entidad);
		}
		 public static bool Anular (Tareas Entidad)
		{
			 return DAL_Tareas.Anular(Entidad);
		}
		 public static bool Existe (Tareas Entidad)
		{
			 return DAL_Tareas.Existe(Entidad);
		}
		 public static Tareas Registro (Tareas Entidad)
		{
			 return DAL_Tareas.Registro(Entidad);
		}
        public static int ExisteTarea(string Tareas_Nombres)
		{
			return DAL_Tareas.ExisteTarea(Tareas_Nombres);
		}


    }
}
