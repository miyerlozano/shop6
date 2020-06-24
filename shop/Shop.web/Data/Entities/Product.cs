using System;
using System.ComponentModel.DataAnnotations;

public class Product
{
	public int Id { get; set; }

	[Display(Name = "Servicio")]
	[MaxLength(100)]
	[Required]
	public string Name { get; set; }

	[Display(Name = "Descripcion")]
	[MaxLength(200)]
	[Required]
	public string Descripcion { get; set; }

	[Display(Name = "Image")]
	public string ImageUrl { get; set; }


	[Display(Name = "Direccion")]
	[MaxLength(100)]
	[Required]
	public string Direccion { get; set; }

	[Display(Name = "Contacto")]
	[MaxLength(50)]
	[Required]
	public string Contacto { get; set; }

	[Display(Name = "Disponible")]
	[Required]
	public string Disponible { get; set; }
}
