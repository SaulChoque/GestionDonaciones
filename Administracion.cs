using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    class Administracion
    {
        private Personal director,coordComunicacion,coordVoluntarios,coordProyectos;
		public Administracion()
		{
            //string tip,string func,string cod,string nom,string ape,string nac,string id,int ed
			director=new Personal("Remunerado","Director","Al48Gon","Alvaro Dante","Gonzales Gomez","Boliviana","5523352LP",48);
			coordComunicacion=new Personal("Remunerado","Cordinadora de Comunicacion","Or25del","Oriane","del Taglia","Italiana","15651512",25);
			coordVoluntarios=new Personal("Remunerado","Coordinadora de proyecto","Ju28Bra","Julia","Braugardt","Alemana","6262656",28);
			coordProyectos=new Personal("Voluntario","Educadora","Ca30Gab","Camille","Gaboriau","Francesa","526261145",30);
		}
    }
}
