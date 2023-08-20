using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Registro
	{
        public static Registro Insert(Registro Entidad)
        {
            return DAL_Registro.Insert(Entidad);
        }

        public static int ObtenerIDRegistro(Registro Entidad)
        {
            return DAL_Registro.ObtenerIDRegistro(Entidad);
        }
        public static bool Break1(Registro Entidad)
        {
              return DAL_Registro.Break1(Entidad);
        }
        public static bool Almuerzo(Registro Entidad)
        { 
            return DAL_Registro.Almuerzo(Entidad);
        }
        public static bool Break2(Registro Entidad)
        {
            return DAL_Registro.Break2(Entidad);
        }

        public static bool Cena(Registro Entidad)
        {
            return DAL_Registro.Cena(Entidad);
        }
        public static bool Salida(Registro Entidad)
        {
            return DAL_Registro.Salida(Entidad);
        }
        public static bool InsertarTarea(Registro Entidad)
        {
            return DAL_Registro.InsertarTarea(Entidad);
        }
        public static bool Existe(Registro Entidad)
        {
            return DAL_Registro.Existe(Entidad);
        }
        public static Registro Registro(Registro Entidad)
        {
            return DAL_Registro.Registro(Entidad);
        }
        public static bool VerificarTarea(Registro Entidad)
        {
            return DAL_Registro.VerificarTarea(Entidad);
        }
        public static int ObtenerIDRegistroSiExiste(int ID_Usuario)
        {
            return DAL_Registro.ObtenerIDRegistroSiExiste(ID_Usuario);
        }
        public static int VerificarRegistro(Registro Entidad)
        {
            return DAL.DAL_Registro.VerificarRegistro(Entidad);
        }
    }
}
