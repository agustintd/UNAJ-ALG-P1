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
			int menu = 0;
			do{
				try{
					while(true){
						Console.WriteLine("\nElija la accion que desea realizar:\n" +			                  
						                  "1- Contratar Obrero\n" +
						                  "2- Eliminar Obrero\n" +
						                  "3- Listar Obreros\n" +
						                  "4- Listar Obras\n" +
						                  "5- Agregar Obra\n" +
						                  "6- Modificar avance de obra\n" +
						                  "7- Listar Obras Finalizadas\n" +
						                  "0- Finalizar Programa");
						try{
							menu = int.Parse(Console.ReadLine());
							break;
						}
						catch(Exception){
							Console.Clear();
							Console.WriteLine("Porfavor solo introducir NUMEROS");
							continue;
						}
					}
					
					Console.Clear();
					switch (menu) {
							case 0: break;
							case 1: {
								break;
							}
							case 2: {
								Console.WriteLine("c2");
								break;
							}
							case 3: {
								Console.WriteLine("c3");
								break;
							}
							case 4: {
								Console.WriteLine("c4");
								break;
							}
							case 5: {
								Console.WriteLine("c5");
								break;
							}
							case 6: {
								Console.WriteLine("c6");
								break;
							}
							case 7: {
								Console.WriteLine("c7");
								break;
							}
							default: {
								Console.WriteLine("No valido");
								break;
							}
					}
				}
				catch(Exception){
					Console.Clear();
					Console.WriteLine("Error");
					continue;
				}
			}while(menu != 0);	
		}
	}
}