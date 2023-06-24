/*
 * Proyecto 1 "Empresa Obras"
 * Creado por
 * Agustin Tottil
 * Sebastian Chaile
 * Nicolas Sanchez
 * GIT Ver
 */
 
using System;

namespace proyecto1
{
	class Program
	{
		/// <summary>
		/// Casos
		/// 1- Contratar Obrero
		/// 2- Eliminar Obrero
		/// 3- Listar Obreros
		/// 4- Listar Obras
		/// 5- Agregar Obra y Asignarle grupo de obreros
		/// 6- Modificar avance en la obra
		/// 7- Listar obras finalizadas
		/// </summary>
		public static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Empresa emp = new Empresa();
			GrupoObreros grupo1 = new GrupoObreros(1,2);
			GrupoObreros grupo2 = new GrupoObreros(2);
			GrupoObreros grupo3 = new GrupoObreros(3);
			emp.agregarGrupoObreros(grupo1);
			emp.agregarGrupoObreros(grupo2);
			emp.agregarGrupoObreros(grupo3);
			int menu = 0;
			do {
				try {
					while (true) {
						Console.WriteLine("\nElija la accion que desea realizar:\n" +
						"1- Contratar Obrero\n" +
						"2- Eliminar Obrero\n" +
						"3- Listar Obreros\n" +
						"4- Listar Obras Activas\n" +
						"5- Agregar Obra\n" +
						"6- Modificar avance de obra\n" +
						"7- Listar Obras Finalizadas\n" +
						"0- Finalizar Programa");
						try {
							menu = int.Parse(Console.ReadLine());
							break;
						} catch (Exception) {
							Console.Clear();
							colorPrint("Porfavor solo introducir NUMEROS","rojo");
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
								listarObreros(emp);
								break;
							}
						case 4:
							{		
								listarObrasActivas(emp);
								break;
							}
						case 5:
							{
								agregarObra(emp);
								break;
							}
						case 6:
							{
								editarAvanceObra(emp);
								break;
							}
						case 7:
							{
								listarObrasFinalizadas(emp);
								break;
							}
						default:
							{
								defaultCase();
								break;
							}
					}
					
				} catch (Exception) {
					Console.Clear();
					colorPrint("Error, problemente intento colocar un tipo de valor en donde no correspondia","rojo");
					continue;
				}
			} while(menu != 0);	
		}
		
		public static void contratarObrero(Empresa emp){
			
			Console.WriteLine("-Estas contratando un Obrero");
			Console.WriteLine("Ingrese Nombre:");
			string nombre = Console.ReadLine();
			Console.Clear();

			Console.WriteLine("-Estas contratando un Obrero");
			Console.WriteLine("Ingrese Apellido:");
			string apellido = Console.ReadLine();
			Console.Clear();

			Console.WriteLine("-Estas contratando un Obrero");
			Console.WriteLine("Ingrese DNI sin puntos:");
			int dni = int.Parse(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("-Estas contratando un Obrero");
			Console.WriteLine("Ingrese numero de legajo sin puntos:");
			int legajo = int.Parse(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("-Estas contratando un Obrero");
			Console.WriteLine("ingrese el Cargo del obrero:");
			string cargo = Console.ReadLine();
			Console.Clear();

			bool existe = false;
			int grupoAlQuePertenece = 0;
			
			Console.WriteLine("-Estas contratando un Obrero");
			while(!existe){
				Console.WriteLine("Ingrese numero de grupo al que pertenece: (Salir = 0)");
				grupoAlQuePertenece = int.Parse(Console.ReadLine());
				
				if(grupoAlQuePertenece == 0){
					break;
				}
				
				foreach (GrupoObreros grupo in emp.GruposObreros) {
					if (grupo.numGrupo == grupoAlQuePertenece) {
						Obrero obrero = new Obrero(legajo, nombre, apellido, dni, cargo);
						emp.agregarObrero(obrero);
						grupo.agregarObrero(obrero);
						existe = true;
						
						Console.Clear();
						colorPrint("Obrero contratado con exito","verde");
						
						break;
					}
				}
				if(!existe){
					Console.Clear();
					Console.WriteLine("-Estas contratando un Obrero");
					colorPrint("No existe un grupo con ese numero","rojo");
				}
			}
		}
		
		public static void eliminarObrero(Empresa emp){
			
			Console.WriteLine("-Estas eliminando a un obrero");
			Console.WriteLine("Legajo del obrero a eliminar:");
			int legajoAEliminar = int.Parse(Console.ReadLine());
			Console.Clear();
			
			bool existe = false;
			
			foreach (Obrero obrero in emp.Obreros) {
				if (obrero.legajo == legajoAEliminar) {
					emp.eliminarObrero(obrero);
					
					colorPrint("Obrero eliminado satisfactoriamente","verde");
					
					existe = true;
					break;
				}
			}
			if(!existe){
				colorPrint("El legajo no coincide con ningun obrero","rojo");
			}
		}
		
		public static void listarObreros (Empresa emp){
			Console.WriteLine("Listado de obreros:");
			emp.listarObreros();
		}
		
		public static void listarObrasActivas (Empresa emp){
			Console.WriteLine("Listado de obras activas:");
			emp.listarObrasActivas();
		}
		
		public static void listarObrasFinalizadas (Empresa emp){
			Console.WriteLine("Listado de obras finalizadas:");
			emp.listarObrasFinalizadas();
		}
		
		public static void agregarObra(Empresa emp){
			Console.WriteLine("-Estas agregando una obra");
			Console.WriteLine("Ingrese Nombre del propietario:");
			string nombrePropietario = Console.ReadLine();
			Console.Clear();
			
			Console.WriteLine("-Estas agregando una obra");
			Console.WriteLine("Ingrese DNI (sin puntos) del propietario:");
			string dniPropietario = Console.ReadLine();
			Console.Clear();
			
			Console.WriteLine("-Estas agregando una obra");
			Console.WriteLine("Ingrese tipo de obra:");
			string tipoObra = Console.ReadLine();
			Console.Clear();
			
			Console.WriteLine("-Estas agregando una obra");
			Console.WriteLine("Ingrese la duracion de la obra (meses):");
			int tiempo = int.Parse(Console.ReadLine());
			Console.Clear();
			
			Console.WriteLine("-Estas agregando una obra");
			Console.WriteLine("Ingrese el costo de la obra:");
			decimal costo = decimal.Parse(Console.ReadLine());
			Console.Clear();
			
			Console.WriteLine("-Estas agregando una obra");
			GrupoObreros grupoObrerosAsignado = null;
			bool grupoValido = false;
			bool existe = false;
			int codigoGrupo = 0;
			
			while(!grupoValido){
				existe = false;
				Console.WriteLine("Ingrese el numero del grupo obrero asignado: (Salir = 0)");
				codigoGrupo = int.Parse(Console.ReadLine());
				if(codigoGrupo == 0){
					break;
				}
				foreach (GrupoObreros grupo in emp.GruposObreros)
	        	{	
					if(grupo.numGrupo == codigoGrupo){
						if(grupo.codObraAsignada == 0){
							grupoObrerosAsignado = grupo;
							existe = true;
							grupoValido = true;
							break;
						}else{
							Console.Clear();
							Console.WriteLine("-Estas agregando una obra");
							colorPrint("Ese grupo obrero existe pero esta ocupado","rojo");
							existe = true;
						}
					}
		        }
				if(!existe){
					Console.Clear();
					Console.WriteLine("-Estas agregando una obra");
					colorPrint("Ese grupo obrero no existe","rojo");
				}
			}
			
			Console.Clear();
			
			if(codigoGrupo != 0){
				Obra obra = new Obra(nombrePropietario, dniPropietario, tipoObra, tiempo, grupoObrerosAsignado, costo);
			
				emp.agregarObra(obra);
				
				foreach (Obra obra2 in emp.Obras){
					if(obra2 == obra){
						GrupoObreros nuevoGrupo = grupoObrerosAsignado;
						nuevoGrupo.codObraAsignada = obra2.ID;
						emp.ActualizarGrupoObrero(grupoObrerosAsignado,nuevoGrupo);
					}
				}
				
				colorPrint("Obra agregada correctamente","verde");
			}
		}
		
		public static void editarAvanceObra(Empresa emp){
			
			Console.Clear();
			Console.WriteLine("-Estas modificando el avance de una obra");
			
			bool existe = false;
			Obra obraExistente = null;
			int idObra = 0;
			while(!existe){
				Console.WriteLine("Ingrese el id de la obra a la que quiere cambiarle el avance: (Salir = 0)");
				idObra = int.Parse(Console.ReadLine());
				
				if(idObra == 0){
					break;
				}
				
				foreach(Obra obra in emp.Obras){
					if(obra.ID == idObra){
						obraExistente = obra;
						existe = true;
						break;
					}
				}
				if(!existe){
					Console.Clear();
					Console.WriteLine("-Estas modificando el avance de una obra");
					colorPrint("Ese id no corresponde con ninguna obra","rojo");
				}
			}
			
			Console.Clear();
			
			if(idObra != 0){
				Console.WriteLine("-Estas modificando el avance de una obra");
				Console.WriteLine("Ingrese el porcentaje de avance: (0 a 100 sin %)");
				int porcentajeNuevo = int.Parse(Console.ReadLine());
				
				Obra obraNueva = obraExistente;
				obraNueva.PorcentajeAvance = porcentajeNuevo;
				
				emp.ActualizarObra(obraExistente,obraNueva);
				Console.Clear();
				colorPrint("Porcentaje de avance de la obra actualizado correctamente","verde");
			}
		}
		public static void defaultCase(){
			Console.Clear();
			colorPrint("Accion no valida","rojo");
		}
		
		public static void colorPrint(string text, string color){
			Console.ResetColor();
			if(color == "rojo"){
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Red;
			}
			else if(color == "verde"){
				Console.BackgroundColor = ConsoleColor.DarkGray;
				Console.ForegroundColor = ConsoleColor.Green;
			}else{
				Console.ForegroundColor = ConsoleColor.White;
			}
			Console.WriteLine(text);
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
	
	
	
	
	
	
	
