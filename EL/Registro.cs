using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Registro")]
	public class Registro
	 {
		[Key]
		public int ID_Registro { get; set; }
		public int? ID_Usuario { get; set; }
		public DateTime? HoraEntrada { get; set; }
		public DateTime? HoraSalida { get; set; }
		public TimeSpan? Break_1 { get; set; }
		public TimeSpan? Almuerzo { get; set; }
		public TimeSpan? Break_2 { get; set; }
		public TimeSpan? Cena { get; set; }
		public int? ID_Tareas { get; set; }
	 }
}
