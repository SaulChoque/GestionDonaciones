using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    class Campaña
    {
        private string titulo;
		private int meta,nroDonaciones;
		private Fecha fechaInicio=new Fecha();
		private Fecha fechaFin=new Fecha();
		List<Donacion> donaciones=new List<Donacion>();
		public Campaña(){
			
		}
		public Campaña(string tit, int met, Fecha fIni, Fecha fFin)
		{
			titulo=tit;
			meta=met;
			nroDonaciones=0;
			fechaInicio=fIni;
			fechaFin=fFin;
		}
		public void addDonacion(Donacion dx){
			donaciones.Add(dx);
			nroDonaciones++;
		}
		//PERSISTENCIA
		public void escribirCAMP(BinaryWriter escritor){
			escritor.Write(titulo);
			escritor.Write(meta);
			escritor.Write(nroDonaciones);
			escritor.Write(fechaInicio.ToString());
			escritor.Write(fechaFin.ToString());
			//fechaInicio.escribirFCHA(escritor);
			//fechaFin.escribirFCHA(escritor);
			for (int i= 0; i<donaciones.Count; i++)
			{
				donaciones[i].escribirDON(escritor);
			}
		}
		public void leerCAMP(BinaryReader lector){
			titulo=lector.ReadString();
			meta=lector.ReadInt32();
			nroDonaciones=lector.ReadInt32();
			//fechaInicio=Fecha.Parse(lector.ReadString());
			//fechaFin=Fecha.Parse(lector.ReadString());
			fechaInicio.leerFCHA(lector);
			fechaFin.leerFCHA(lector);
			for (int i=0; i<nroDonaciones; i++)
			{
				donaciones[i].leerDON(lector);
			}
		}

		//GETTERS AND SETTERS
		public string getTitulo{get{return titulo;}}
		public Fecha getFechaIni{get{return fechaInicio;}}
		public Fecha getFechaFin{get{return fechaFin;}}
		
    }
}
