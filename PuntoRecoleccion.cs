using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    public class PuntoRecoleccion
    {
        private string institucion;
		private Ubicacion direccion=new Ubicacion();
		private Fecha fechaInicio=new Fecha();
		private Fecha fechaFin=new Fecha();
		public PuntoRecoleccion(){
			
		}
		public PuntoRecoleccion(string inst,Ubicacion dir,Fecha fechaInicio, Fecha fechaFin)
		{
			this.institucion=inst;
			this.direccion=dir;
			this.fechaInicio=fechaInicio;
			this.fechaFin=fechaFin;
		}

		//PERSISTENCIA
		public void escribirPTRC(BinaryWriter escritor){
			escritor.Write(institucion);
			//escritor.Write(fechaInicio.ToString().Substring(0,10));
			//escritor.Write(fechaFin.ToString().Substring(0,10));
			direccion.escribirUBI(escritor);
			fechaInicio.escribirFCHA(escritor);
			fechaFin.escribirFCHA(escritor);
		}
		public void leerPTRC(BinaryReader lector){
			institucion=lector.ReadString();
			direccion.leerUBI(lector);
			fechaInicio.leerFCHA(lector);
			fechaFin.leerFCHA(lector);
		}
		//GETTERS Y SETTERS
		public string getInstitucion{get{return institucion;}}
		public string getDireccion{get{return direccion.toString;}}
    }
}






			//Convert.ChangeType("2020-01-01 16:00:30", typeof(DateTime));
			//fechaInicio=DateTime.ParseExact(lector.ReadString(),"d/MM/yyyy HH:mm:ss", provider);
			//fechaInicio=DateTime.ParseExact(lector.ReadString(),"d/MM/yyyy HH:mm:ss", provider);
			/*f1=lector.ReadString();
			a=int.Parse(f1.Substring(6,4));
			string f1="",f2="";
			int a=0,m=0,d=0;
			m=int.Parse(f1.Substring(3,2));
			d=int.Parse(f1.Substring(0,2));
			fechaInicio=new DateTime(a,m,d);
			f2=lector.ReadString();
			a=int.Parse(f2.Substring(6,4));
			m=int.Parse(f2.Substring(3,2));
			d=int.Parse(f2.Substring(0,2));
			fechaFin=new DateTime(a,m,d);
			*/