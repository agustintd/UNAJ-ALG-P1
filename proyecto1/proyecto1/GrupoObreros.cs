/*
 * Proyecto 1 "Empresa Obras"
 * Creado por
 * Agustin Tottil
 * Sebastian Chaile
 * Nicolas Sanchez
 */
 
using System;
using System.Collections.Generic;

namespace proyecto1
{
	/// <summary>
	/// GrupoObreros.
	/// Codigo de obra asignada (puede ser ninguna) -  Integrantes
	/// </summary>
	public class GrupoObreros
	{
		public int numGrupo {get; set;}
		public int codObraAsignada {get; set;}
		public List<Obrero> Obreros {get; set;}
		
		public GrupoObreros(int numGrupo)
		{
			this.numGrupo = numGrupo;
			this.codObraAsignada = 0;
			Obreros = new List<Obrero>();
		}
		
		public GrupoObreros(int numGrupo, int codObraAsignada)
		{
			this.numGrupo = numGrupo;
			this.codObraAsignada = codObraAsignada;
			Obreros = new List<Obrero>();
		}
		
		public void agregarObrero(Obrero obrero)
		{
			Obreros.Add(obrero);
		}
		
		public void eliminarObrero(Obrero obrero)
	    {
	        Obreros.Remove(obrero);
	    }
		
		public void actualizarObrero(Obrero obreroExistente, Obrero nuevoObrero)
	    {
	        int index = Obreros.IndexOf(obreroExistente);
	        if (index != -1)
	        {
	            Obreros[index] = nuevoObrero;
	        }
	    }
		
		public void listarObreros()
	    {
			int contador = 0;
	        foreach (var obrero in Obreros)
	        {
	        	contador += 1;
	            Console.WriteLine("{0}- {1}, legajo {2}, dni {3}", contador, obrero.nombre + " " + obrero.apellido, obrero.legajo, obrero.dni);
	     		
	        }
	    }
	}
}
