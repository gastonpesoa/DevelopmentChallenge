using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Classes.Forma;
using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.Reporte
{
    public class Reporte
    {
        protected readonly List<FormaGeometrica> _formas;
        private readonly IIdioma _idioma;
        protected readonly List<Type> _tiposFormas;

        public Reporte(List<FormaGeometrica> formas, IIdioma idioma, List<Type> tiposFormas)
        {
            _formas = formas;
            _idioma = idioma;
            _tiposFormas = tiposFormas;
        }

        public string Imprimir()
        {
            var sb = new StringBuilder();

            if (_formas?.Any() != true)
            {
                sb.Append(_idioma.HeaderVacio);
            }
            else
            {
                // HEADER
                sb.Append(_idioma.Header);

                // BODY
                foreach (Type tipo in _tiposFormas)
                {
                    List<FormaGeometrica> formasDeMismoTipo = _formas.Where(x => x.GetType() == tipo).ToList();
                    decimal areaTotal = formasDeMismoTipo.Sum(x => x.CalcularArea());
                    decimal perimetroTotal = formasDeMismoTipo.Sum(x => x.CalcularPerimetro());

                    string lineaParaAgregar = string.Empty;

                    if (formasDeMismoTipo.Count > 0)
                    {
                        string nombreTipo = formasDeMismoTipo.Count == 1 ? formasDeMismoTipo.First().Nombre : formasDeMismoTipo.First().NombrePlural;
                        lineaParaAgregar = $"{formasDeMismoTipo.Count} {nombreTipo} | {_idioma.Area} {areaTotal:#.##} | {_idioma.Perimetro} {perimetroTotal:#.##} <br/>";
                    }

                    sb.Append(lineaParaAgregar);
                }

                // FOOTER
                sb.Append(_idioma.Total);
                sb.Append($"{_formas.Count} {_idioma.Formas} ");
                sb.Append($"{_idioma.Perimetro} {_formas.Sum(x => x.CalcularPerimetro()):#.##} ");
                sb.Append($"{_idioma.Area} {_formas.Sum(x => x.CalcularArea()):#.##}");
            }

            return sb.ToString();
        }
    }
}
