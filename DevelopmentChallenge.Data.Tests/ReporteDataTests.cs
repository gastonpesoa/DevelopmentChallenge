using System;
using System.Collections.Generic;
using System.Linq;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Forma;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes.Reporte;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    class ReporteDataTests
    {
        [TestCase]
        public void TestResumenListaVaciaCastellano()
        {
            Reporte reporte = new Reporte(new List<FormaGeometrica>(), new Castellano(), new List<Type>());

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", reporte.Imprimir());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Reporte reporte = new Reporte(new List<FormaGeometrica>(), new Ingles(), new List<Type>());
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", reporte.Imprimir());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Reporte reporte = new Reporte(new List<FormaGeometrica>(), new Italiano(), new List<Type>());
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>", reporte.Imprimir());
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var idioma = new Castellano();
            var formas = new List<FormaGeometrica> { new Circulo(5, idioma) };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "1 Círculo | Area 19.63 | Perimetro 15.71 <br/>" +
                "TOTAL:<br/>1 formas Perimetro 15.71 Area 19.63", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var idioma = new Ingles();
            var formas = new List<FormaGeometrica>
            {
                new Circulo(5, idioma),
                new Circulo(1, idioma),
                new Circulo(3, idioma)
            };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "3 Circles | Area 27.49 | Perimeter 28.27 <br/>" +
                "TOTAL:<br/>3 shapes Perimeter 28.27 Area 27.49", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var idioma = new Castellano();
            var formas = new List<FormaGeometrica> { new Cuadrado(5, idioma) };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);
 
            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "1 Cuadrado | Area 25 | Perimetro 20 <br/>" +
                "TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var idioma = new Ingles();
            var formas = new List<FormaGeometrica> 
            { 
                new Cuadrado(5, idioma), 
                new Cuadrado(1, idioma), 
                new Cuadrado(3, idioma) 
            };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "3 Squares | Area 35 | Perimeter 36 <br/>" +
                "TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var idioma = new Castellano();
            var formas = new List<FormaGeometrica> { new Rectangulo(5, 3, idioma) };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);
 
            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "1 Rectángulo | Area 15 | Perimetro 16 <br/>" +
                "TOTAL:<br/>1 formas Perimetro 16 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var idioma = new Ingles();
            var formas = new List<FormaGeometrica> 
            { 
                new Rectangulo(5, 3, idioma),
                new Rectangulo(1, 6, idioma),
                new Rectangulo(3, 9, idioma)
            };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "3 Rectangles | Area 48 | Perimeter 54 <br/>" +
                "TOTAL:<br/>3 shapes Perimeter 54 Area 48", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var idioma = new Castellano();
            var formas = new List<FormaGeometrica> { new Trapecio(4, 5, 5, 6, 8, idioma) };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);
 
            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "1 Trapecio | Area 28 | Perimetro 24 <br/>" +
                "TOTAL:<br/>1 formas Perimetro 24 Area 28", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var idioma = new Ingles();
            var formas = new List<FormaGeometrica> 
            {
                new Trapecio(4, 5, 5, 6, 8, idioma),
                new Trapecio(3, 4, 4, 7, 9, idioma),
                new Trapecio(6, 4, 6, 7, 7, idioma)
            };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "3 Trapezes | Area 94 | Perimeter 72 <br/>" +
                "TOTAL:<br/>3 shapes Perimeter 72 Area 94", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var idioma = new Castellano();
            var formas = new List<FormaGeometrica> { new TrianguloEquilatero(5, idioma) };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);
 
            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "1 Triángulo | Area 10.83 | Perimetro 15 <br/>" +
                "TOTAL:<br/>1 formas Perimetro 15 Area 10.83", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTriangulos()
        {
            var idioma = new Ingles();
            var formas = new List<FormaGeometrica> 
            { 
                new TrianguloEquilatero(5, idioma),
                new TrianguloEquilatero(6, idioma),
                new TrianguloEquilatero(3, idioma)
            };
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "3 Triangles | Area 30.31 | Perimeter 42 <br/>" +
                "TOTAL:<br/>3 shapes Perimeter 42 Area 30.31", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var idioma = new Ingles();
            var formas = new List<FormaGeometrica> 
            { 
                new Cuadrado(5, idioma),
                new Cuadrado(4, idioma),
                new Cuadrado(3, idioma),
                new Circulo(5, idioma),
                new Circulo(7, idioma),
                new TrianguloEquilatero(5, idioma), 
                new TrianguloEquilatero(2, idioma),
                new Trapecio(4, 5, 5, 6, 8, idioma),
                new Rectangulo(5, 3, idioma)
            };
            
            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual(
                "<h1>Shapes report</h1>" +
                "3 Squares | Area 50 | Perimeter 48 <br/>" +
                "2 Circles | Area 58.12 | Perimeter 37.7 <br/>" +
                "2 Triangles | Area 12.56 | Perimeter 21 <br/>" +
                "1 Trapeze | Area 28 | Perimeter 24 <br/>" +
                "1 Rectangle | Area 15 | Perimeter 16 <br/>" +
                "TOTAL:<br/>9 shapes Perimeter 146.7 Area 163.68",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var idioma = new Castellano();
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5, idioma),
                new Cuadrado(4, idioma),
                new Cuadrado(3, idioma),
                new Circulo(5, idioma),
                new Circulo(7, idioma),
                new TrianguloEquilatero(5, idioma),
                new TrianguloEquilatero(2, idioma),
                new Trapecio(4, 5, 5, 6, 8, idioma),
                new Rectangulo(5, 3, idioma)
            };

            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>" +
                "3 Cuadrados | Area 50 | Perimetro 48 <br/>" +
                "2 Círculos | Area 58.12 | Perimetro 37.7 <br/>" +
                "2 Triángulos | Area 12.56 | Perimetro 21 <br/>" +
                "1 Trapecio | Area 28 | Perimetro 24 <br/>" +
                "1 Rectángulo | Area 15 | Perimetro 16 <br/>" +
                "TOTAL:<br/>9 formas Perimetro 146.7 Area 163.68",
                resumen);
        }
        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var idioma = new Italiano();
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5, idioma),
                new Cuadrado(4, idioma),
                new Cuadrado(3, idioma),
                new Circulo(5, idioma),
                new Circulo(7, idioma),
                new TrianguloEquilatero(5, idioma),
                new TrianguloEquilatero(2, idioma),
                new Trapecio(4, 5, 5, 6, 8, idioma),
                new Rectangulo(5, 3, idioma)
            };

            var tiposFormas = formas.Select(x => x.GetType()).Distinct().ToList();
            var reporte = new Reporte(formas, idioma, tiposFormas);

            var resumen = reporte.Imprimir();

            Assert.AreEqual(
                "<h1>Rapporto Forme</h1>" +
                "3 Quadrati | Area 50 | Perimetro 48 <br/>" +
                "2 Cerchi | Area 58.12 | Perimetro 37.7 <br/>" +
                "2 Triangoli | Area 12.56 | Perimetro 21 <br/>" +
                "1 Trapezio | Area 28 | Perimetro 24 <br/>" +
                "1 Rettangolo | Area 15 | Perimetro 16 <br/>" +
                "TOTAL:<br/>9 forme Perimetro 146.7 Area 163.68",
                resumen);
        }
    }
}
