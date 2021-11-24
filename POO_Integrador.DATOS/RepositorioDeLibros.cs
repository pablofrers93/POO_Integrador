using POO_Integrador.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Integrador.DATOS
{
    public class RepositorioLibros
    {
        private List<Libro> listaLibros;
        public static RepositorioLibros _instancia;
        private ManejadorDeArchivo manejador;


        public static RepositorioLibros GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new RepositorioLibros();
            }

            return _instancia;
        }

        private RepositorioLibros()
        {
            listaLibros = new List<Libro>();
            manejador = new ManejadorDeArchivo();
            listaLibros = manejador.LeerDatosDelArchivo();
        }

        public List<Libro> GetLista()
        {
            return listaLibros;
        }

        public void Agregar(Libro libro)
        {
            manejador.Agregar(libro);
            listaLibros.Add(libro);
        }

        public void Remover(Libro libro)
        {
            manejador.BorrarDeArchivo(libro);
            listaLibros.Remove(libro);
        }

        public void Editar(Libro libro_Original, Libro libroModificado)
        {
            manejador.Editar(libro_Original, libroModificado);
            int index = listaLibros.IndexOf(libro_Original);
            listaLibros.RemoveAt(index);
            listaLibros.Insert(index, libroModificado);
        }

        public bool Existe(Libro libro)
        {
            return listaLibros.Contains(libro);
        }

        public int GetCantidad()
        {
            return listaLibros.Count();
        }


    }
}
