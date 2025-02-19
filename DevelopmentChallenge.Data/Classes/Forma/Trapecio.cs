using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Forma
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _alto;

        private readonly decimal _cateto1;

        private readonly decimal _cateto2;

        private readonly decimal _base1;

        private readonly decimal _base2;

        public Trapecio(decimal alto, decimal cateto1, decimal cateto2, decimal base1, decimal base2, IIdioma idioma)
            : base(idioma)
        {
            _alto = alto;
            _cateto1 = cateto1;
            _cateto2 = cateto2;
            _base1 = base1;
            _base2 = base2;
        }

        public override string Nombre { get => _idioma.Trapecio; }

        public override string NombrePlural { get => _idioma.Trapecios; }

        public override decimal CalcularArea()
        {
            return ((_base1 + _base2) / 2) * _alto;
        }

        public override decimal CalcularPerimetro()
        {
            return _cateto1 + _cateto2 + _base1 + _base2;
        }
    }
}
