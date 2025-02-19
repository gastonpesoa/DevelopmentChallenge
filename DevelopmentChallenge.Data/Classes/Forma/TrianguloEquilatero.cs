using System;
using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Forma
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado, IIdioma idioma)
            : base(idioma)
        {
            _lado = lado;
        }

        public override string Nombre { get => _idioma.Triangulo; }

        public override string NombrePlural { get => _idioma.Triangulos; }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
