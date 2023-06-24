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
	/// Obra.
	/// ID - Nombre (Del propietario) - DNI (Del propietario) - Tipo de obra - Tiempo (Meses) - % de avance - N° de grupo de obreros asignado (tipo Grupo Obrero) - Costo
	/// </summary>
	public class Obra
	{
		private static int ultimoID = 1;
		private int id;
		public int ID
	    {
	        get { return id; }
	    }
	    public string NombrePropietario { get; set; }
	    public string DNIPropietario { get; set; }
	    public string TipoObra { get; set; }
	    public int Tiempo { get; set; }
	    public double PorcentajeAvance { get; set; }
	    public GrupoObreros GrupoObrerosAsignado { get; set; }
	    public decimal Costo { get; set; }
	    
		public Obra(string nombrePropietario, string dniPropietario, string tipoObra, int tiempo, GrupoObreros grupoObrerosAsignado, decimal costo)
	    {
	        this.id = ultimoID++;
	        this.NombrePropietario = nombrePropietario;
	        this.DNIPropietario = dniPropietario;
	        this.TipoObra = tipoObra;
	        this.Tiempo = tiempo;
	        this.PorcentajeAvance = 0;
	        this.GrupoObrerosAsignado = grupoObrerosAsignado;
	        this.Costo = costo;
	    }
	}
}
