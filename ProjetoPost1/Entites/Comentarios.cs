using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPost1.Entites
{
    internal class Comentarios
    {
        public string Texto {  get; set; }

        public Comentarios()
        {

        }

        public Comentarios(string texto)
        {
            Texto = texto;
        }
    }
}
