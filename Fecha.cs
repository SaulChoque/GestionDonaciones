using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class Fecha
    {
        private int dia,mes,anio;
		public Fecha(){
			
		}
		public Fecha(int dia,int mes, int anio)
		{
			this.dia=dia;
			this.mes=mes;
			this.anio=anio;
		}
		//PERSISTENCIA
		public void escribirFCHA(BinaryWriter escritor){
			escritor.Write(dia);
			escritor.Write(mes);
			escritor.Write(anio);
		}
		public void leerFCHA(BinaryReader lector){
			dia=lector.ReadInt32();
			mes=lector.ReadInt32();
			anio=lector.ReadInt32();
		}		
		//añadir metodos de conversion de dias
		public string toString{get{return dia+"/"+mes+"/"+anio;}}
		
		//getters&setters
		public int getDia{get{return dia;}}
		public int getMes{get{return mes;}}
		public int getaño{get{return anio;}}
	}
}
