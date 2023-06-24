/*
 * Proyecto 1 "Empresa Obras"
 * Creado por
 * Agustin Tottil
 * Sebastian Chaile
 * Nicolas Sanchez
 */
 
using System;

namespace proyecto1
{
	/// <summary>
	/// Obrero.
	/// Legajo - Nombre - Apellido - DNI - Cargo
	/// </summary>
	public class Obrero
	{
		public int legajo {get; set;}
		public int dni {get; set;}
		public string nombre {get; set;}
		public string apellido {get; set;}
		public string cargo {get; set;}
		
		public Obrero (int legajo, string nombre, string apellido, int dni, string cargo){
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.cargo = cargo;
		}	
		
	}
}
