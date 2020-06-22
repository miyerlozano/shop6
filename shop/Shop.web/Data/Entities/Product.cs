using System;
using System.ComponentModel.DataAnnotations;

public class Product
{
	public int Id { get; set; }

	public string Name { get; set; }

	[Display(Name = "Descripcion")]
	public string Descripcion { get; set; }

	[Display(Name = "Image")]
	public string ImageUrl { get; set; }


	[Display(Name = "Direccion")]
	public string Direccion { get; set; }

	[Display(Name = "Contacto")]
	public bool Contacto { get; set; }

	[Display(Name = "Disponible")]
	public bool Disponible { get; set; }
}
