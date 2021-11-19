using POO_Integrador.DATOS;
using POO_Integrador.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Integrador.CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {

            //   var libro = new Libro()
            // {
            //     NombreLibro = "Cien años de soledad",
            //  Editorial = Editorial.Atlantida,
            //  Tema = Tema.Drama,
            //   Paginas = 250,
            //   Isbn = 123456,
            //  Autor = "Gabriel Garcia Marquez"
            // };

            // RepositorioLibros.GetInstancia().Agregar(libro);
            // Console.WriteLine(RepositorioLibros.GetInstancia().GetCantidad());

            //var libro2 = new Libro()
            // {
            // NombreLibro = "Cementerio de animales",
            // Editorial = Editorial.DelBosque,
            // Tema = Tema.Terror,
            //Paginas = 200,
            //Isbn = 234567,
            //Autor = "Stephen King"
            //};

            //RepositorioLibros.GetInstancia().Agregar(libro2);
            //Console.WriteLine(RepositorioLibros.GetInstancia().GetCantidad());

            foreach (var libro in RepositorioLibros.GetInstancia().GetLista())
            {
                Console.WriteLine(libro.GetInfo());
            }
            Console.ReadLine();

        }
    }
}
