using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class Donacion
    {
		private string RazonSocial,concepto;
		private int valor;
        private Fecha fecha=new Fecha();
		public Donacion(){
			
		}
		public Donacion(string rz,string con,int val,Fecha fec)
		{
			this.RazonSocial=rz;
			this.concepto=con;
			this.valor=val;
			this.fecha=fec;
		}
		//PERSISTENCIA
		public void escribirDON(BinaryWriter escritor){
			escritor.Write(RazonSocial);
			escritor.Write(concepto);
			escritor.Write(valor);
			escritor.Write(fecha.ToString());
			//fecha.escribirFCHA(escritor);
		}
		public void leerDON(BinaryReader lector){
			RazonSocial=lector.ReadString();
			concepto=lector.ReadString();
			valor=lector.ReadInt32();
			//fecha=Fecha.Parse(lector.ReadString());
			fecha.leerFCHA(lector);
		}
		//mostrar?
		//getters&setters
    }
}
