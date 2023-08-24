using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Usuario
	{
		 public static Usuario Insert (Usuario Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 Entidad.Estado = true;
                 bd.Usuario.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Usuario Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 var Registro = bd.Usuario.Find(Entidad.ID_Usuario);
				 Registro.Nombres = Entidad.Nombres;
				 Registro.Apellidos = Entidad.Apellidos;
				 Registro.NumeroCedula = Entidad.NumeroCedula;
				 Registro.Password = Entidad.Password;
				 Registro.ID_Rol = Entidad.ID_Rol;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Usuario Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 var Registro = bd.Usuario.Find(Entidad.ID_Usuario);
				 Registro.Estado = false;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Usuario Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 return bd.Usuario.Where(a=>a.ID_Usuario == Entidad.ID_Usuario).Count() > 0;
			}
		}
		 public static Usuario Registro (Usuario Entidad)
		{
			 using (BDBPOCONTROL bd = new BDBPOCONTROL ())
			{
				 return bd.Usuario.Where(a=>a.ID_Usuario == Entidad.ID_Usuario).SingleOrDefault();
			}
		}
        public static int ObtenerIDUsuarioSiCredencialesValidas(string UserName, string Password)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var usuarioEncontrado = bd.Usuario
                    .FirstOrDefault(a => a.NumeroCedula.ToLower() == UserName.ToLower() && a.Password == Password);

                if (usuarioEncontrado != null)
                {
                    return usuarioEncontrado.ID_Usuario;
                }
                else
                {
                    return -1; // Valor que indica que las credenciales no son válidas
                }
            }
        }

        public static Usuario MostrarUsuario()
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
              return bd.Usuario.Where(a => a.Estado == true).SingleOrDefault();
            }
        }

        public static DataTable MostrarU()
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ConexionSP.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public static int ObtenerIDRol(int ID_Usuario)
        {
            using (BDBPOCONTROL bd = new BDBPOCONTROL())
            {
                var usuarioEncontrado = bd.Usuario
                    .FirstOrDefault(a => a.ID_Usuario == ID_Usuario);

                if (usuarioEncontrado != null)
                {
                    return usuarioEncontrado.ID_Rol;
                }
                else
                {
                    return -1; // Valor que indica que las credenciales no son válidas
                }
            }
        }
    }
}
