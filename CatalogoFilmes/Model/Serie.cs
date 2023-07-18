using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilmes.Model
{
    internal class Serie
    {
        private static int id;
        private static string nomeSerie;
        private static string categoriaSerie;
        private static string temporadaSerie;
        private static string duracaoSerie;

        public static int Id { get => id; set => id = value; }
        public static string NomeSerie { get => nomeSerie; set => nomeSerie = value; }
        public static string CategoriaSerie { get => categoriaSerie; set => categoriaSerie = value; }
        public static string TemporadaSerie { get => temporadaSerie; set => temporadaSerie = value; }
        public static string DuracaoSerie { get => duracaoSerie; set => duracaoSerie = value; }
    }
}
