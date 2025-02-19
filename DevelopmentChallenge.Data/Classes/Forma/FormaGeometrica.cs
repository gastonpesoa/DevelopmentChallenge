using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Forma
{
    public abstract class FormaGeometrica
    {
        protected IIdioma _idioma;

        protected FormaGeometrica(IIdioma idioma)
        {
            _idioma = idioma;
        }

        public abstract string Nombre { get; }

        public abstract string NombrePlural { get; }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
	}
}
