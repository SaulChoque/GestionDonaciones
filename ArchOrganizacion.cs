namespace GestionDonaciones
{

	using System;
	using System.IO;
	using System.Collections.Generic;
	public class ArchOrganizacion
	{
		private string nombre;
		//private List<Personal> P=new List<Personal>();
		public ArchOrganizacion(string na)
		{
			nombre=na;
		}
		public void crearNuevo()
		{
			if (System.IO.File.Exists(nombre))
				{
					//Console.Write("\n////// Realmente quiere crear el archivo. Ojo se borraran los registros? s/n => ");
					//if (Console.ReadKey().KeyChar=='s')
						System.IO.File.Delete(nombre);

				
				}
				else
					Console.WriteLine("\n || El archivo no existe");
		}
		public void adicionar()
		{
				Stream arch=File.Open(nombre,FileMode.Append);
				BinaryWriter escribe=new BinaryWriter(arch);
				try
				{
					Organizacion J=new Organizacion();
					//J.addPersonal("A1","B1","C1","D1","E1","F1","G1",48);

					Console.WriteLine();
					J.escribirORG(escribe);
					//Console.Write("\n || Desea seguir añadiendo? s/n => ");
					
				}
				catch(Exception )
				{
					Console.WriteLine("////// Fallo en adicionar el objeto!!");
				}
				finally
				{
					arch.Close();
				}
			}
		public bool adicionarPersonal(string tip,string func,string cod,string nom,string ape,string nac,string id,int ed) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(nombre, FileMode.Open);
				Stream archTemporal = File.Open(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Organizacion prod = new Organizacion();	
				try {
						while(true){
							prod.leerORG(lector);
							prod.addPersonal(tip,func,cod,nom,ape,nac,id,ed);
							prod.escribirORG(escribeTemp);
						}
				}
				catch( Exception ) {
					// No hace nada.
				}
				finally {
					Console.WriteLine("\n || Bebidas eliminadas");
					archp.Close();
					archTemporal.Close();
					File.Replace(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", nombre, nombre + ".bak");

				}
			}	
			catch( Exception ) {
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}
		public bool adicionarCentroComunitario(string nom, Personal enc, Ubicacion dir, List<string> ennc) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(nombre, FileMode.Open);
				Stream archTemporal = File.Open(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Organizacion prod = new Organizacion();	
				try {
						while(true){
							prod.leerORG(lector);
							prod.addCentroComunitario(nom,enc,dir,ennc);
							prod.escribirORG(escribeTemp);
						}
				}
				catch( Exception ) {
					// No hace nada.
				}
				finally {
					Console.WriteLine("\n || Bebidas eliminadas");
					archp.Close();
					archTemporal.Close();
					File.Replace(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", nombre, nombre + ".bak");

				}
			}	
			catch( Exception ) {
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}
		public bool adicionarPuntoRecoleccion(PuntoRecoleccion px) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(nombre, FileMode.Open);
				Stream archTemporal = File.Open(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Organizacion prod = new Organizacion();	
				try {
						while(true){
							prod.leerORG(lector);
							prod.addPuntoRecoleccion(px);
							prod.escribirORG(escribeTemp);
						}
				}
				catch( Exception ) {
					// No hace nada.
				}
				finally {
					Console.WriteLine("\n || Bebidas eliminadas");
					archp.Close();
					archTemporal.Close();
					File.Replace(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", nombre, nombre + ".bak");

				}
			}	
			catch( Exception ) {
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}
		public bool adicionarCampaña(string tit, int met, Fecha fIni, Fecha fFin) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(nombre, FileMode.Open);
				Stream archTemporal = File.Open(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Organizacion prod = new Organizacion();	
				try {
						while(true){
							prod.leerORG(lector);
							prod.addCampaña(tit,met,fIni,fFin);
							prod.escribirORG(escribeTemp);
						}
				}
				catch( Exception ) {
					// No hace nada.
				}
				finally {
					Console.WriteLine("\n || Bebidas eliminadas");
					archp.Close();
					archTemporal.Close();
					File.Replace(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", nombre, nombre + ".bak");

				}
			}	
			catch( Exception ) {
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}
		public bool adicionarDonaciones(Donacion dx, int x) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(nombre, FileMode.Open);
				Stream archTemporal = File.Open(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Organizacion prod = new Organizacion();	
				try {
						while(true){
							prod.leerORG(lector);
							prod.addDonacion(dx);
							
							prod.escribirORG(escribeTemp);
						}
				}
				catch( Exception ) {
					// No hace nada.
				}
				finally {
					Console.WriteLine("\n || Bebidas eliminadas");
					archp.Close();
					archTemporal.Close();
					File.Replace(@"C:\Users\saulc\source\repos\GestionDonaciones\orgTEMP.dat", nombre, nombre + ".bak");

				}
			}	
			catch( Exception ) {
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}



		//GETTERS
		public List<Personal> getPersonal()
		{
				Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
				BinaryReader lector=new BinaryReader(arch);
				Organizacion org=new Organizacion();
				List<Personal> P=new List<Personal>();
				try
				{ 			
					while(true)
					{
						org.leerORG(lector);
						P=org.getPersonal;
					}
				}
				catch(Exception)
				{
					Console.WriteLine("Fin de archivo...");
					return P;
				}
				finally{
					arch.Close();
				}
		}
		public List<string> getTitulosCampañas()
		{
				Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
				BinaryReader lector=new BinaryReader(arch);
				Organizacion org=new Organizacion();
				List<string> P=new List<string>();
				try
				{ 			
					while(true)
					{
						org.leerORG(lector);
						P=org.getTitulosCampaña;
					}
				}
				catch(Exception)
				{
					Console.WriteLine("Fin de archivo...");
					return P;
				}
				finally{
					arch.Close();
				}
		}
		public List<CentroComunitario> getCentroComunitarios()
		{
				Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
				BinaryReader lector=new BinaryReader(arch);
				Organizacion org=new Organizacion();
				List<CentroComunitario> P=new List<CentroComunitario>();
				try
				{ 			
					while(true)
					{
						org.leerORG(lector);
						P=org.getCentroComunitarios;
					}
				}
				catch(Exception)
				{
					Console.WriteLine("Fin de archivo...");
					return P;
				}
				finally{
					arch.Close();
				}
		}
		public List<PuntoRecoleccion> getPuntoRecoleccions()
		{
				Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
				BinaryReader lector=new BinaryReader(arch);
				Organizacion org=new Organizacion();
				List<PuntoRecoleccion> P=new List<PuntoRecoleccion>();
				try
				{ 			
					while(true)
					{
						org.leerORG(lector);
						P=org.getPuntoRecoleccions;
					}
				}
				catch(Exception)
				{
					Console.WriteLine("Fin de archivo...");
					return P;
				}
				finally{
					arch.Close();
				}
		}
		public List<DateTime> getCampañasFechas()
		{
				Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
				BinaryReader lector=new BinaryReader(arch);
				Organizacion org=new Organizacion();
				List<DateTime> P=new List<DateTime>();
				try
				{ 			
					while(true)
					{
						org.leerORG(lector);
						P=org.getCampañaFechas;
					}
				}
				catch(Exception)
				{
					Console.WriteLine("Fin de archivo...");
					return P;
				}
				finally{
					arch.Close();
				}
		}
			/*
		public void palindromo()
		{
			Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
			BinaryReader lector=new BinaryReader(arch);
			Organizacion J=new Organizacion();
			//int i=1;
			try
			{	
				while(true)
				{
					J.leerTB(lector);
					if(J.Palindromo){
						//Console.Write("\n"+i+")");
						Console.Write("\n-)");
						J.mostrar();
						//i++;
					}
				}
			}
			
			catch(Exception)
			{
				Console.WriteLine("\n || Fin de archivo...");
			}
			
			finally{
				arch.Close();
			}
		}
		public void listarPrecioMenor(int x)
		{
			Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
			BinaryReader lector=new BinaryReader(arch);
			Organizacion J=new Organizacion();
			int c=1;
			try
			{
				//Console.WriteLine("\nDatos de las Tiendas Bebidas");
				//Console.WriteLine("====================");
				//Console.WriteLine("\n\tNombre\tEdad\tEstatura\tPeso\tDeporte\n");   			
				while(true)
				{
					int cc=0;
					J.leerTB(lector);
					for (int i=0; i<J.Nit; i++){
						if(J.Nit%(i+1)==0){
							cc++;
						}
					}
					if(cc==2){
						Console.WriteLine("\tMarca\tNombre\tPrecio\tLitros");
						for (int i=0; i<J.NroBebidas; i++)
						{
							if(J.Bebidas[i].Precio<=x){
								Console.WriteLine((c)+")\t"+J.Bebidas[i].toString);
								c++;
							}
						}
					}else{
						Console.WriteLine("\n || El NIT "+J.Nit+" no es un numero primo!!");
					}
				}
			}
			catch(Exception)
			{
				Console.WriteLine("Fin de archivo...");
			}
			finally{
				arch.Close();
			}
		}
		*/


		}

			/*
			public bool eliminar() {
				bool sw = false;
				try {
					// Abrimos el archivo o se crea un nuevo archivo si no existe
					Stream archp = File.Open(nombre, FileMode.Open);
					Stream archTemporal = File.Open(@"C:\Users\saulc\OneDrive - fcpn.edu.bo\LAB 121\2022-II\persistencia\DefensaPractica\claseTienda\temp.dat", FileMode.OpenOrCreate);
					BinaryReader lector = new BinaryReader(archp);
					BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
					Organizacion prod = new Organizacion();
					
					try {
						while( true ) {
							prod.leerTB(lector);
							Console.WriteLine("\n/// TD REG "+prod.RegSanitario);
							Console.Write("Nit=> ");
							prod.Nit=Leer.Integer;
							Console.Write("Nombre=> ");
							prod.Nombre=Leer.Cadena;
							Console.Write("Dirr=> ");
							prod.Direccion=Leer.Cadena;
							prod.mostrar();
							prod.escribirTB(escribeTemp);
						}
					}
					catch( Exception ) {
						// No hace nada.
					}
					finally {
						archp.Close();
						archTemporal.Close();
						File.Replace(@"C:\Users\saulc\OneDrive - fcpn.edu.bo\LAB 121\2022-II\persistencia\DefensaPractica\claseTienda\temp.dat", nombre, nombre + ".bak");
					}
				}	
				catch( Exception ) {
					Console.WriteLine("El archivo no se puede acceder !!!");
				}
				return sw;
	}*/
}