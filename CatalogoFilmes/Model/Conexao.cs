using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilmes.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gabriela.negreiros\source\repos\CatalogoFilmes\CatalogoFilmes\Model\filmesbd.mdf;Integrated Security=True";       
        }
    }
}
