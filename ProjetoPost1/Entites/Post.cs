using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPost1.Entites
{
    internal class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Descrição { get; set; }
        public int Likes { get; set; }
        public List<Comentarios> Coments { get; set; } = new List<Comentarios>();

        public Post()
        {

        }

        public Post(DateTime momento, string titulo, string descrição, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Descrição = descrição;
            Likes = likes;
        }
        public void AdicionarComentarios(Comentarios comentarios)
        {
            Coments.Add(comentarios);
        }
        public void RemoverComentarios(Comentarios comentarios)
        {
            Coments.Remove(comentarios);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes");
            sb.Append(" - ");
            sb.AppendLine(Momento.ToString("dd/mm/yyyy HH/mm/ss"));
            sb.AppendLine(Descrição);
            sb.AppendLine("Comentarios: ");
            foreach (Comentarios c in Coments)
            {
                sb.AppendLine(c.Texto);

            }
            return sb.ToString();
        }
    }
}
