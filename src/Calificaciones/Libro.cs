using System;
using System.Collections.Generic;

namespace Calificaciones
{

 /* evento (delegado)*/
    public delegate void EventoAdicionNota(object objeto, EventArgs evento);

    public class Libro{
        

        readonly string categoria ="ciencia";
       private  List <double> notas;
        public string nombre{
            get;
            private set;
        }       
       public double notaAlta{
            get;
            private set;
        }       
     public double notaBaja{
            get;
            private set;
        }   
       public double resultado{
            get;
            private set;
        }   
       public char letra{
            get;
            private set;
        }   
       public Libro(string nombre){
           this.notas = new List<double>();
           this.nombre = nombre;
           this.notaAlta = double.MinValue;
           this.notaBaja = double.MaxValue;
           this.resultado = 0.0;
       }
        public void añadirNota(double nota){

            if(nota>=0 &&  nota<=100){
              this.notaAlta = Math.Max(nota, this.notaAlta);
              this.notaBaja = Math.Min(nota, this.notaBaja);
              notas.Add(nota);
               /*Si hay alguien escuchando*/
               if(eventoAdicion!=null){
                   /*cuando esto sucede se ejecuta lo almacenado en este evento*/
                 eventoAdicion(this, new EventArgs());
               }

            }else{
                Console.WriteLine($"{nameof(nota)} invalida");
            }
            
        }
        public void estadisticas(){
            
            foreach(var nota in notas){
                this.resultado += nota;
            }
           this.resultado /= notas.Count;
            
            switch(this.resultado){
                case var d when d >= 90.0:
                this.letra = 'A';
                break;
                 case var d when d >= 80.0:
                this.letra = 'B';
                break;
                 case var d when d >= 70.0:
                this.letra = 'C';
                break;
                 case var d when d >= 60.0:
                this.letra = 'D';
                break;
                default:
                this.letra = 'F';
                break;
            }


            Console.WriteLine($"El promedio del estudiante {this.nombre} es {resultado}");
            Console.WriteLine($"La nota mas alta es {this.notaAlta}"); 
            Console.WriteLine($"La nota mas baja es {this.notaBaja}"); 
            Console.WriteLine($"Su letra es {this.letra}"); 
        }
        

        /*Se invoca este delegado para ejecutar el evento*/
         public event EventoAdicionNota eventoAdicion;
    
    }
}