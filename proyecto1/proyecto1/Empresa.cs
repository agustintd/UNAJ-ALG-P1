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
	/// Empresa.
	/// -Obras - Grupos de obreros - Obreros
	/// </summary>
	public class Empresa
	{
		public List<Obrero> Obreros { get; set; }
	    public List<Obra> Obras { get; set; }
	    public List<GrupoObreros> GruposObreros { get; set; }

	    public Empresa()
	    {
	        Obreros = new List<Obrero>();
	        Obras = new List<Obra>();
	        GruposObreros = new List<GrupoObreros>();
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
		
		public void listarObrasActivas()
		{
	        foreach (var obra in Obras)
	        {
	        	if((100 - obra.PorcentajeAvance) > 0){
	            	Console.WriteLine("ID: {0}, Tipo de obra: {1}, Costo: {2}, Duracion: {3}, Porcentaje de completitud: {4}%, Propetario {5}, DNI Propetario: {6}", obra.ID, obra.TipoObra, obra.Costo, obra.Tiempo, obra.PorcentajeAvance, obra.NombrePropietario, obra.DNIPropietario);
	        	}
	        }
		}
		
		public void listarObrasFinalizadas()
		{
	        foreach (var obra in Obras)
	        {
	        	if((100 - obra.PorcentajeAvance) <= 0){
	            	Console.WriteLine("ID: {0}, Tipo de obra: {1}, Costo: {2}, Duracion: {3}, Porcentaje de completitud: {4}%, Propetario {5}, DNI Propetario: {6}", obra.ID, obra.TipoObra, obra.Costo, obra.Tiempo, obra.PorcentajeAvance, obra.NombrePropietario, obra.DNIPropietario);
	        	}
	        }
		}
		
		public void listarGruposObreros()
	    {
			int contador = 0;
	        foreach (var grupo in GruposObreros)
	        {
	        	contador += 1;
	            Console.WriteLine("{0}- Numero de grupo {1}, Codigo de obra asignada {2}", contador, grupo.numGrupo, grupo.codObraAsignada);	
	        }
	    }

		public void agregarObrero(Obrero obrero)
		{
			Obreros.Add(obrero);
		}
		
		public void agregarObra(Obra obra)
		{
			Obras.Add(obra);
		}
		
		public void agregarGrupoObreros(GrupoObreros grupo)
		{
			GruposObreros.Add(grupo);
		}
		
		public void eliminarObrero(Obrero obrero)
		{
			Obreros.Remove(obrero);
		}
		
		public void EliminarObra(Obra obra)
		{
		    Obras.Remove(obra);
		}
		
		public void EliminarGrupoObrero(GrupoObreros grupo)
		{
		    GruposObreros.Remove(grupo);
		}
		
		public void ActualizarObrero(Obrero obreroExistente, Obrero nuevoObrero)
		{
			int index = Obreros.IndexOf(obreroExistente);
	        if (index != -1)
	        {
	            Obreros[index] = nuevoObrero;
	        }
		}
		
		public void ActualizarObra(Obra obraExistente, Obra nuevaObra)
		{
		    int index = Obras.IndexOf(obraExistente);
	        if (index != -1)
	        {
	            Obras[index] = nuevaObra;
	        }
		}
		
		public void ActualizarGrupoObrero(GrupoObreros grupoExistente, GrupoObreros nuevoGrupo)
		{
		    int index = GruposObreros.IndexOf(grupoExistente);
	        if (index != -1)
	        {
	            GruposObreros[index] = nuevoGrupo;
	        }
		}
	}
}
