using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Tareas")]
	public class Tareas
	 {
		[Key]
		public int ID_Tareas { get; set; }
		[MaxLength(255)]
		public string Tareas_Nombres { get; set; }
	 }
}
