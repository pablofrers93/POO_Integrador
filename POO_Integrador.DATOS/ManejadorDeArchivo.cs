using POO_Integrador.ENTIDADES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Integrador.DATOS
{
    public class ManejadorDeArchivo
    {
        private readonly string _archivo=Environment.CurrentDirectory+@"\Libros.txt";
        private readonly string _archivoBAK = Environment.CurrentDirectory + @"\Libros.bak";


        public ManejadorDeArchivo()
        {

        }

        public List<Libro> LeerDatosDelArchivo()
        {
            List<Libro> lista = new List<Libro>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    var libro = ConstruirLibro(linea);
                    lista.Add(libro);
                }
                lector.Close();
            }
            return lista; 
            
        }

       
        private Libro ConstruirLibro(string linea)
        {
            var campos = linea.Split(',');
            return new Libro()
            {
                NombreLibro = campos[0],
                Editorial = (Editorial)int.Parse(campos[1]),
                Tema = (Tema)int.Parse(campos[2]),
                Paginas = int.Parse(campos[3]),
                Isbn = int.Parse(campos[4]),
                Autor = campos[5]
            };
        }

        internal void BorrarDeArchivo(Libro libroBorrar)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBAK);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var libroEnArchivo = ConstruirLibro(linea);
                if (!libroEnArchivo.Equals(libroBorrar))
                {
                    escritor.WriteLine(linea);
                }
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBAK, _archivo);
        }

        public void Agregar(Libro libro)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            var linea = ConstruirLinea(libro); 
            escritor.WriteLine(linea);
            escritor.Close();
        }


        private string ConstruirLinea(Libro libro)
        {
            return $"{libro.NombreLibro}, {libro.Editorial.GetHashCode()}, {libro.Tema.GetHashCode()}, {libro.Paginas}, {libro.Isbn}, {libro.Autor}";
        }
    }
}
