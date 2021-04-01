using System;
using Xunit;
namespace calificaciones.Test
{
    public class CalificacionesTest
    {
        [Fact]
        public void pruebaCalificaciones()
        {
            /* Pruebas de si hay error con nombre vacio*/
             var libro = new Calificaciones.Libro("");
             libro.añadirNota(5.4);
             libro.añadirNota(8.9);
             libro.añadirNota(540.4);
            
             libro.estadisticas();
             Assert.Equal(5.4,libro.notaBaja);
             Assert.Equal(540.4,libro.notaAlta);
             Assert.Equal(184.89999999999998,libro.resultado);
       
        }
    }
}
