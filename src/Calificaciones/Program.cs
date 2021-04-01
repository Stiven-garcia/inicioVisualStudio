using System;
using System.Collections.Generic;

namespace Calificaciones{
    class Program{
        static void Main(string[] args){
            var libro = new Libro("carlos");
            /*Se adiciona acciones al evento*/
            libro.eventoAdicion += onAdicionNota;
            while(true){
                Console.WriteLine("Digite una nota o 'q' para terminar: ");
               var input = Console.ReadLine();
               if(input == "q"){
                    break;
               }
               try{
                  libro.añadirNota(Double.Parse(input));
               }catch(Exception ex){
                     Console.WriteLine(ex.Message);
               }
               
            } 
            libro.estadisticas();
            
        }

        static void onAdicionNota(object objet, EventArgs evento){
            /*Accion que queramos que haga*/
            Console.WriteLine("Se adiciono la nota");
        }
    }
}
