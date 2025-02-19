using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Forma
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado, IIdioma idioma)
            : base(idioma)
        {
            _lado = lado;
        }

        public override string Nombre { get => _idioma.Cuadrado; }

        public override string NombrePlural { get => _idioma.Cuadrados; }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
