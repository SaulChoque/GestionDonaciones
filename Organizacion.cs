        
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GestionDonaciones
{
    [Serializable]
    class Organizacion
    {
        private string nombre;
        private int nroCentros,nroPuntos,nroDonaciones,nroCampañas,nroPersonal;
        private Ubicacion direccion;
        //Vectores
        private Personal[] personalV= new Personal[50];
        private CentroComunitario[] centrosV=new CentroComunitario[30];
        private PuntoRecoleccion[] puntosV=new PuntoRecoleccion[30];
        private Donacion[] donacionesV=new Donacion[200];
        private Campaña[] campañasV=new Campaña[50];
        //Listas
        List<Personal> personal=new List<Personal>();
        List<CentroComunitario> centros=new List<CentroComunitario>();
        List<PuntoRecoleccion> puntos=new List<PuntoRecoleccion>();
        List<Donacion> donaciones=new List<Donacion>();
        List<Campaña> campañas=new List<Campaña>();
        private Administracion administracion;

        public Organizacion(){
            this.nombre="Bolivia Digna";
            this.direccion=new Ubicacion("La Paz","Villa Fatima","15", "La Paz","31");
            this.nroCentros=0;
            this.nroPuntos=0;
            this.nroDonaciones=0;
            this.nroCampañas=0;
            this.nroPersonal=0;
            administracion=new Administracion();
        }

        public void addPersonal(string tip,string func,string cod,string nom,string ape,string nac,string id,int ed){
            personalV[nroPersonal]=new Personal(tip,func,cod,nom,ape,nac,id,ed);
            personal.Add(new Personal(tip,func,cod,nom,ape,nac,id,ed));
            nroPersonal++;
        }
        public void addCentroComunitario(string nom, Personal enc, Ubicacion dir, List<string> ennc){
            centrosV[nroCentros]=new CentroComunitario(nom,enc,dir,ennc);
            centros.Add(new CentroComunitario(nom,enc,dir,ennc));
            nroCentros++;
        }
        public void addPuntoRecoleccion(PuntoRecoleccion pr){
            puntosV[nroPuntos]=pr;
            puntos.Add(pr);
            nroPuntos++;
        }
        public void addDonacion(Donacion dx){
            donacionesV[nroDonaciones]=dx;
            donaciones.Add(dx);
            nroDonaciones++;
        }
        public void addCampaña(string tit, int met, Fecha fIni, Fecha fFin){
            campañasV[nroCampañas]=new Campaña(tit,met,fIni,fFin);
            campañas.Add(new Campaña(tit,met,fIni,fFin));  
            nroCampañas++; 
        }
        public void addCampañaDonacion(Donacion dx, int x){
            campañas[x].addDonacion(dx);
            campañasV[x].addDonacion(dx);
        }

        //PERSISTENCIA

        public void escribirORG(BinaryWriter escritor){
            //nroCentros,nroPuntos,nroDonaciones,nroCampañas,nroPersonal;
            escritor.Write(nombre);
            escritor.Write(nroCentros);
            escritor.Write(nroPersonal);
            escritor.Write(nroPuntos);
            escritor.Write(nroDonaciones);
            escritor.Write(nroCampañas);

            //CENTROS COMUNITARIOS
            for (int i=0; i<nroCentros; i++){
                //Console.WriteLine("es: "+(i+1));
                centros[i].escribirCENT(escritor);
            }

            //PERSONAL
            for (int i=0; i<nroPersonal; i++){
                //Console.WriteLine("es: "+(i+1));
                personal[i].escribirPRSN(escritor);
            }

            //PUNTOS RECOLECCION
            for (int i=0; i<nroPuntos; i++){
                //Console.WriteLine("es: "+(i+1));
                puntos[i].escribirPTRC(escritor);
            }

            //DONACIONES
            for (int i=0; i<nroDonaciones; i++){
                //Console.WriteLine("es: "+(i+1));
                donaciones[i].escribirDON(escritor);
            }

            //CAMPAÑAS
            for (int i=0; i<nroCampañas; i++){
                //Console.WriteLine("es: "+(i+1));
                campañas[i].escribirCAMP(escritor);
            }
        }
        public void leerORG(BinaryReader lector){
            nombre=lector.ReadString();
			nroCentros=lector.ReadInt32();
			nroPersonal=lector.ReadInt32();
			nroPuntos=lector.ReadInt32();
			nroDonaciones=lector.ReadInt32();
			nroCampañas=lector.ReadInt32();

            //CENTROS COMUNITARIOS
            for (int i=0; i<nroCentros; i++){
                //Console.WriteLine("es: "+(i+1));
                centrosV[i]=new CentroComunitario();
                centrosV[i].leerCENT(lector);
                centros.Add(centrosV[i]);
            }

            //PERSONAL
            for (int i=0; i<nroPersonal; i++){
                //Console.WriteLine("es: "+(i+1));
                personalV[i]=new Personal();
                personalV[i].leerPRSN(lector);
                personal.Add(personalV[i]);
            }

            //PUNTOS RECOLECCION
            for (int i=0; i<nroPuntos; i++){
                //Console.WriteLine("es: "+(i+1));
                puntosV[i]=new PuntoRecoleccion();
                puntosV[i].leerPTRC(lector);
                puntos.Add(puntosV[i]);
            }

            //DONACIONES
            for (int i=0; i<nroDonaciones; i++){
                //Console.WriteLine("es: "+(i+1));
                donacionesV[i]=new Donacion();
                donacionesV[i].leerDON(lector);
                donaciones.Add(donacionesV[i]);
                
            }

            //CAMPAÑAS
            for (int i=0; i<nroCampañas; i++){
                //Console.WriteLine("es: "+(i+1));
                campañasV[i]=new Campaña();
                campañasV[i].leerCAMP(lector);
                campañas.Add(campañasV[i]);        
            }
        }

        //GETTERS Y SETTERS

        public List<Personal> getPersonal{get{return personal;}}
        public List<CentroComunitario> getCentroComunitarios{get{return centros;}}
        public List<PuntoRecoleccion> getPuntoRecoleccions{get{return puntos;}}
        public List<string> getTitulosCampaña
        {
            get{
                List<string> titulos=new List<string>();
                for (int i=0; i<nroCampañas; i++)
                {
                    titulos.Add(campañas[i].getTitulo);
                }
                return titulos;      
            }
        }
        public List<DateTime> getCampañaFechas
        {
            get{
                int d=0,m=0,a=0;
                DateTime dt;
                List<DateTime> fechas=new List<DateTime>();
                for (int i=0; i<nroCampañas; i++)
                {
                    d=campañas[i].getFechaIni.getDia;
                    m=campañas[i].getFechaIni.getMes;
                    a=campañas[i].getFechaIni.getaño;
                    dt=new DateTime(a,m,d);
                    fechas.Add(dt);
                }
                return fechas;      
            }
        }
        


        
    }
}
