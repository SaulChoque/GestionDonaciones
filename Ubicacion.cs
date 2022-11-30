using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class Ubicacion
    {
        private string nro,ciudad,zona,calle,departamento;

		public Ubicacion(){
			
		}	
		public Ubicacion(string ciu,string zon,string call,string dep, string nro)
		{
			this.ciudad=ciu;
			this.zona=zon;
			this.calle=call;
			this.departamento=dep;
			this.nro=nro;
		}
	//PERSISTENCIA
    public void escribirUBI(BinaryWriter escritor){
		escritor.Write(ciudad);
		escritor.Write(zona);
		escritor.Write(calle);
		escritor.Write(departamento);
		escritor.Write(nro);

	}
    public void leerUBI(BinaryReader lector){
		ciudad=lector.ReadString();
		zona=lector.ReadString();
		calle=lector.ReadString();
		departamento=lector.ReadString();
		nro=lector.ReadString();
	}
		//El Alto-La Paz/ Zona Villa Exaltacion/ Calle La razon Nro 31
		public string toString{get{return departamento+"-"+ciudad+"/ Zona "+zona+"/ Calle "+calle;}}
		//getters&setters
    }
}
