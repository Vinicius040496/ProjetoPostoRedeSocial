using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPost1.Entites;

namespace ProjetoPost1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comentarios c1 = new Comentarios("Boa viagem,meu amigo!");
            Comentarios c2 = new Comentarios("Vai com Deus");

            Post p1 = new Post(DateTime.Parse("2018/06/10 13:50:30"),
              "Viajando para Portugal!!",
              "Em busca de um futuro melhor para mim ",
              12);
            p1.AdicionarComentarios(c1);
            p1.AdicionarComentarios(c2);

            Comentarios c3 = new Comentarios("Boa festas");
            Comentarios c4 = new Comentarios("Feliz aniversario,aproveita bem!");

            Post p2 = new Post(DateTime.Parse("2020/10/10 23:35:50"),
                "Meu aniversario hoje!!",
                "Festa aqui em casa hoje para comemorar!",
                30);
            p2.AdicionarComentarios(c3);
            p2.AdicionarComentarios(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadLine();
        }
    }
}
