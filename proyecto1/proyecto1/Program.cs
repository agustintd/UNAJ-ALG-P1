/*
 * Proyecto 1 "Empresa Obras"
 * Creado por
 * Agustin Tottil
 * Sebastian Chaile
 * Nicolas Sanchez
 * GIT Ver
 */
 
using System;
using System.Collections;

namespace proyecto1
{
	class Program
	{
		/// <summary>
		/// Description of Program.
		/// 1- Contratar Obrero (New Obrero y agregarlo a el array de obreros de la empresa y a un grupo)
		/// 2- Eliminar Obrero (Borrar obrero y eliminarlo del array de obreros de la empresa y de su grupo)
		/// 3- Listar Obreros (Recorrer array de obreros de la empresa)
		/// 4- Listar Obras (Recorrer el array de obras de la empresa)
		/// 5- Agregar Obra y Asignarle grupo de obreros (New obra y agregarlo al array de obras de la empresa verificar si el grupo asignado esta libre)
		/// 6- Modificar avance en la obra (usar el Setter de obra, si es 100 la obra se elimina del array de obras activa y se agrega al de obras finalizadas)
		/// 7- Listar obras finalizadas (Recorrer array de obras finalizadas)
		/// </summary>
		public static void Main(string[] args)
		{
			Empresa emp = new Empresa();
			GrupoObreros grupo1 = new GrupoObreros(1, 1);
			emp.agregarGrupoObreros(grupo1);
			int menu = 0;
			do {
				try {
					while (true) {
						Console.WriteLine("\nElija la accion que desea realizar:\n" +
						"1- Contratar Obrero\n" +
						"2- Eliminar Obrero\n" +
						"3- Listar Obreros\n" +
						"4- Listar Obras\n" +
						"5- Agregar Obra\n" +
						"6- Modificar avance de obra\n" +
						"7- Listar Obras Finalizadas\n" +
						"0- Finalizar Programa");
						try {
							menu = int.Parse(Console.ReadLine());
							break;
						} catch (Exception) {
							Console.Clear();
							Console.WriteLine("Porfavor solo introducir NUMEROS");
							continue;
						}
					}
					
					Console.Clear();
					switch (menu) {
						case 0:
							break;
						case 1:
							{
								contratarObrero(emp);
								break;
							}
						case 2:
							{
								eliminarObrero(emp);
								break;
							}
						case 3:
							{
								Console.WriteLine("c3");
								break;
							}
						case 4:
							{
								Console.WriteLine("c4");
								break;
							}
						case 5:
							{
								Console.WriteLine("c5");
								break;
							}
						case 6:
							{
								Console.WriteLine("c6");
								break;
							}
						case 7:
							{
								Console.WriteLine("c7");
								break;
							}
						default:
							{
								Console.WriteLine("No valido");
								break;
							}
					}
				} catch (Exception) {
					Console.Clear();
					Console.WriteLine("Error");
					continue;
				}
			} while(menu != 0);	
		}
		
		public static void contratarObrero(Empresa emp){

			Console.WriteLine("Ingrese Nombre");
			string nombre = Console.ReadLine();

			Console.WriteLine("Ingrese Apellido");
			string apellido = Console.ReadLine();

			Console.WriteLine("Ingrese DNI sin puntos");
			int dni = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese numero de legajo sin puntos");
			int legajo = int.Parse(Console.ReadLine());

			Console.WriteLine("ingrese el Cargo del obrero");
			string cargo = Console.ReadLine();

			Console.WriteLine("Ingrese numero de grupo al que pertenece");
			int grupoAlQuePertenece = int.Parse(Console.ReadLine());
    
			Console.WriteLine("");
			Console.WriteLine("");

			//Obrero unObrero = new Obrero(nombre, apellido, cargo, legajo, dni, grupoAlQuePertenece);
			Obrero unObrero = new Obrero(legajo);
			emp.agregarObrero(unObrero);
			foreach (GrupoObreros grupo in emp.GrupoObreros) {
				if (grupo.numGrupo == grupoAlQuePertenece) {
					Console.Clear();
					Console.WriteLine("Agregado con exito");
					grupo.agregarObrero(unObrero);
            		
					break;
				}
			}
		}
		public static void eliminarObrero(Empresa emp){
			
			Console.WriteLine("Legajo del obrero a eliminar:");
			int legajoAEliminar = int.Parse(Console.ReadLine());
			ArrayList Obreros = emp.Obreros;
			foreach (Obrero elem in Obreros) {
				Console.WriteLine("Legajo = {0}", elem.legajo);
				if (elem.legajo == legajoAEliminar) {
					emp.eliminarObrero(elem);
					Console.WriteLine("obrero eliminado satisfactoriamente");
					break;
				} else {
					Console.WriteLine("El legajo no coincide con ningun abogado de nuestra lista");
				}
			}
		}     
	}
}
	
	
	
	
	
	
	
