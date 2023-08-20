using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Registro
	{
        public static Registro Insert(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                Entidad.HoraEntrada = DateTime.Now;
                bd.Registro.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static int ObtenerIDRegistro(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                DateTime fechaInicio = DateTime.Today;
                DateTime fechaFin = fechaInicio.AddDays(1);

                var registroEncontrado = bd.Registro
                    .FirstOrDefault(r => r.ID_Usuario == Entidad.ID_Usuario && r.HoraEntrada >= fechaInicio && r.HoraEntrada < fechaFin);

                if (registroEncontrado != null)
                {
                    return registroEncontrado.ID_Registro;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static bool Break1(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                Registro.Break_1 = Entidad.Break_1;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Almuerzo(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                Registro.Almuerzo = Entidad.Almuerzo;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Break2(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                Registro.Break_2 = Entidad.Break_2;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Cena(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                Registro.Cena = Entidad.Cena;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Salida(Registro Entidad)
        {
              using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                Registro.HoraSalida = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool InsertarTarea(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                Registro.ID_Tareas = Entidad.ID_Tareas;
                return bd.SaveChanges() > 0;
            }
        }

        public static bool Existe(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                return bd.Registro.Where(a => a.ID_Registro == Entidad.ID_Registro).Count() > 0;
            }
        }
        public static Registro Registro(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                return bd.Registro.Where(a => a.ID_Registro == Entidad.ID_Registro).SingleOrDefault();
            }
        }
        
        public static bool VerificarTarea(Registro Entidad)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                if (Registro.ID_Tareas == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static int VerificarRegistro(Registro Entidad)
        {
            using (BDBPOCONTROL bd =new BDBPOCONTROL())
            {
                var Registro = bd.Registro.Find(Entidad.ID_Registro);
                if(Registro.HoraSalida != null)
                {
                    return 5;
                }
                else if (Registro.Cena != null)
                {
                    return 4;
                    
                }
                else if (Registro.Break_2 != null)
                {
                    return 3;
                }
                else if (Registro.Almuerzo != null)
                {
                    return 2;
                }
                else if (Registro.Break_1 != null)
                {
                    return 1;
                }
                else 
                { 
                    return 0; 
                }
            }
        }


        public static int ObtenerIDRegistroSiExiste(int ID_Usuario)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                DateTime fechaInicio = DateTime.Today;
                DateTime fechaFin = fechaInicio.AddDays(1);

                var registroEncontrado = bd.Registro
                    .FirstOrDefault(r => r.ID_Usuario == ID_Usuario && r.HoraEntrada >= fechaInicio && r.HoraEntrada < fechaFin);

                if (registroEncontrado != null)
                {
                    return registroEncontrado.ID_Registro;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
