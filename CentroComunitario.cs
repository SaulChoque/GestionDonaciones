using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class CentroComunitario
    {
        private string nombre;
        private int nroProgramas;
		private Personal encargado;
		private List<string> programas=new List<string>();
		private string[] programasV=new string[30];
		private Ubicacion direccion=new Ubicacion();
		public CentroComunitario(){
			
		}
		public CentroComunitario(string nom, Personal enc, Ubicacion dir, List<string> ennc)
		{
			this.nombre=nom;
			this.direccion=dir;
			this.programas=ennc;		
			this.nroProgramas=ennc.Count;
		}
		public void escribirCENT(BinaryWriter escritor){
			escritor.Write(nombre);
			escritor.Write(nroProgramas);
			direccion.escribirUBI(escritor);
			for (int i=0; i<nroProgramas; i++){
				//Console.WriteLine("es: "+(i+1));
				escritor.Write(programas[i]);
			}
		}
		public void leerCENT(BinaryReader lector){
			nombre=lector.ReadString();
			nroProgramas=lector.ReadInt32();
			direccion.leerUBI(lector);
			for (int i=0; i<nroProgramas; i++){
				//Console.WriteLine("le: "+(i+1));
				programasV[i]=lector.ReadString();
				programas.Add(programasV[i]);
			}
		}

		//GETTERS Y SETTERS
		public string getNombre{get{return nombre;}}
		public string getDireccion{get{return direccion.toString;}}

    }
}
