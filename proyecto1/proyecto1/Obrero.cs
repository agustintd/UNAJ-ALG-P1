/*
 * Proyecto 1 "Empresa Obras"
 * Creado por
 * Agustin Tottil
 * Sebastian Chaile
 * Nicolas Sanchez
 */
 
using System;
using System.Collections;

namespace proyecto1
{
	/// <summary>
	/// Description of Obrero.
	/// Legajo - Nombre - Apellido - DNI - Cargo - Grupo al que pertenece
	/// </summary>
	public class Obrero
	{
		//variables de instancia/atributos
		private int legajo, dni, grupoAlQuePertenece;
		private string nombre, apellido, cargo;
		
		//contruct
		public Obrero (int legajo, string nombre, string apellido, int dni, string cargo, int grupoAlQuePertenece){
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.cargo = cargo;
			this.grupoAlQuePertenece = grupoAlQuePertenece;
		}
		
		//propiedades
		public int Legajo{
			set{legajo=value;}
			get {return legajo;}
		}
		public string Nombre{
			set {nombre=value;}
			get {return nombre;}
		}
		public string Apellido{
			set {apellido=value;}
			get{return apellido;}
		}
		public int Dni{
			set{dni=value;}
			get{return dni;}
		}
		public string Cargo{
			set{cargo = value;}
			get{return cargo;}
		}
		public int GrupoAlQuePertence{
			set { grupoAlQuePertenece = value;}
			get { return grupoAlQuePertenece;}
		}
		
		
		
		
		
		
		public void imprimir(Obrero unObrero)
        {
            Console.WriteLine("Legajo:"+unObrero.Legajo + " Nombre:" + unObrero.Nombre + " Apellido:" + unObrero.Apellido + " DNI:" + unObrero.Dni + " Cargo:"+ unObrero.Cargo+"  Grupo al que p:"+ unObrero.GrupoAlQuePertence);
        }
		
		
		
		
	}
}
