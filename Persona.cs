using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class Persona
    {
        protected string nombres,apellidos,nacionalidad,id;
		protected int edad;
		public Persona(){

		}
		public Persona(string nom,string ape,string nac,string id,int ed)
		{
			this.nombres=nom;
			this.apellidos=ape;
			this.nacionalidad=nac;
			this.id=id;
			this.edad=ed;
		}
		//PERSISTENCIA
		public void escribirPRS(BinaryWriter escritor){
			escritor.Write(nombres);
			escritor.Write(apellidos);
			escritor.Write(nacionalidad);
			escritor.Write(id);
			escritor.Write(edad);
		}
		public void leerPRS(BinaryReader lector){
			nombres=lector.ReadString();
			apellidos=lector.ReadString();
			nacionalidad=lector.ReadString();
			id=lector.ReadString();
			edad=lector.ReadInt32();
		}		
		public string getNombres{get{return nombres;}}
		public string getApellidos{get{return apellidos;}}
		
		//mostrar?, getters &setters
    }
}
