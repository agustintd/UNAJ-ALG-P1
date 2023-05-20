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
	/// Description of Empresa.
	/// -ObrasActivas (Array de obras activas) - ObrasFinalizadas (Array de obras Finalizadas) - Grupos de obreros (Array de obreros) - Obreros (Array Obreros)
	/// </summary>
	public class Empresa
	{
		public ArrayList Obreros = new ArrayList();
		private ArrayList ObrasActivas = new ArrayList();
		private ArrayList ObrasFinalizadas = new ArrayList();
		public ArrayList GrupoObreros = new ArrayList();
		public Empresa()
		{
		}
		public void listarObreros(){
			
		}
		public void listarObrasActivas(){
			
		}
		public void listarObrasFinalizadas(){
			
		}
		public void agregarObrero(Obrero unObrero){
			Obreros.Add(unObrero);
		}
		public void agregarObraActiva(){
			
		}
		public void agregarObraTerminada(){
			
		}
		public void agregarGrupoObreros(GrupoObreros grupo){
			GrupoObreros.Add(grupo);
		}
		public void eliminarObrero(Obrero obrero){
			Obreros.Remove(obrero);
		}
		public void eliminarObraActiva(){
			
		}
		public void eliminarObraTerminada(){
			
		}
	}
}
