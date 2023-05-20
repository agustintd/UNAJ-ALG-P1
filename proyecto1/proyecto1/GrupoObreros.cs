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
	/// Description of GrupoObreros.
	/// Codigo de obra asignada (puede ser ninguna) -  Integrantes
	/// </summary>
	public class GrupoObreros
	{
		
		public int numGrupo,codObraAsignada;
		private ArrayList Obreros = new ArrayList();
		public GrupoObreros(int numGrupo, int codObraAsignada)
		{
			this.numGrupo = numGrupo;
			this.codObraAsignada = codObraAsignada;
		}
		public void agregarObrero(Obrero unObrero){
			Obreros.Add(unObrero);
		}
		public void listarObreros(){
			
		}
	}
}
