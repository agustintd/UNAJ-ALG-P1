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
	/// Description of Obrero.
	/// Legajo - Nombre - Apellido - DNI - Cargo - Grupo al que pertenece
	/// </summary>
	public class Obrero
	{
		public int legajo;
		public Obrero(int legajo)
		{
			this.legajo = legajo;
		}
	}
}
