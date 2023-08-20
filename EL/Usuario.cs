using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Usuario")]
	public class Usuario
	 {
		[Key]
		public int ID_Usuario { get; set; }
		[MaxLength(50)]
		[Required]
		public string Nombres { get; set; }
		[MaxLength(50)]
		[Required]
		public string Apellidos { get; set; }
		[MaxLength(15)]
		[Required]
		public string NumeroCedula { get; set; }
		[MaxLength(50)]
		[Required]
		public string Password { get; set; }
		[Required]
		public bool Estado { get; set; }
		[Required]
		public int ID_Rol { get; set; }
	 }
}
