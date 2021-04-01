using System;
using Xunit;
namespace calificaciones.Test
{
    public class TipoTest
    {
        [Fact]
        public void pruebaTipo()
        {
            /* Pruebas de si hay error con nombre vacio*/
             var libro = GetLibro("nombre 1");
              var libro2 = GetLibro("nombre 2");
             Assert.Equal("nombre 1",libro.nombre);
             Assert.Equal("nombre 2",libro2.nombre);
             Assert.NotSame(libro,libro2);
       
        }

         [Fact]
        public void pruebaIgualdadObjeto()
        {
            /* Pruebas de si hay error con nombre vacio*/
             var libro = GetLibro("nombre 1");
              var libro2 = libro;
            Assert.Same(libro,libro2);
       
        }

         [Fact]
        public void pruebaIgualdadObjeto2()
        {
            /* Pruebas de si hay error con nombre vacio*/
             var libro = GetLibro("nombre 1");
              nuevoNombre(ref libro, "nuevo nombre");
            Assert.Same(libro.nombre,"nuevo nombre");
       
        }

        public void nuevoNombre(ref  Calificaciones.Libro libro, string v)
        {
           libro = GetLibro(v);
        }

        Calificaciones.Libro GetLibro(string nombre){
            return new Calificaciones.Libro(nombre); 
        }
    }
}
