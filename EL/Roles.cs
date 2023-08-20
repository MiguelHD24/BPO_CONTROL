using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Roles")]
	public class Roles
	 {
		[Key]
		public int ID_Rol { get; set; }
		[MaxLength(50)]
		[Required]
		public string Rol_Nombres { get; set; }
	 }
}
