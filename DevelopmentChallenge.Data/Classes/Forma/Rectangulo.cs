using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Forma
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _alto;

        private readonly decimal _ancho;

        public Rectangulo(decimal alto, decimal ancho, IIdioma idioma)
            : base(idioma)
        {
            _alto = alto;
            _ancho = ancho;
        }

        public override string Nombre { get => _idioma.Rectangulo; }

        public override string NombrePlural { get => _idioma.Rectangulos; }

        public override decimal CalcularArea()
        {
            return _alto * _ancho;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (_alto + _ancho);
        }
    }
}
