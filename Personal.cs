using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class Personal: Persona
    {
        private string tipo,funcion,codigoEmpleado;
				
		public Personal(): base(){

		}
		public Personal(string tip,string func,string cod,string nom,string ape,string nac,string id,int ed): base(nom,ape,nac,id,ed)
		{
			this.tipo=tip;
			this.funcion=func;
			this.codigoEmpleado=cod;
		}
		//PERSISTENCIA
		public void escribirPRSN(BinaryWriter escritor){
			base.escribirPRS(escritor);
			escritor.Write(tipo);
			escritor.Write(funcion);
			escritor.Write(codigoEmpleado);

		}
		public void leerPRSN(BinaryReader lector){
			base.leerPRS(lector);
			tipo=lector.ReadString();
			funcion=lector.ReadString();
			codigoEmpleado=lector.ReadString();
		}
		//mostrar()?
		//getters&setters
    }
}
