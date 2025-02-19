using System;
using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Forma
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro, IIdioma idioma)
            : base(idioma)
        {
            _diametro = diametro;
        }

        public override string Nombre { get => _idioma.Circulo; }

        public override string NombrePlural { get => _idioma.Circulos; }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * (_diametro / 2);
        }
    }
}
