using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Integrador.ENTIDADES
{
    public class Libro
    {
        public string NombreLibro { get; set; }
        public Editorial Editorial { get; set; }
        public Tema Tema { get; set; }
        public int Paginas { get; set; }
        public int Isbn { get; set; }
        public string Autor { get; set; }

        public override bool Equals(object obj)
        {
            if (obj ==null || !(obj is Libro))
                    {
                return false;
            }
            return this.NombreLibro == ((Libro)obj).NombreLibro &&
                   this.Editorial == ((Libro)obj).Editorial &&
                   this.Tema == ((Libro)obj).Tema &&
                   this.Paginas == ((Libro)obj).Paginas &&
                   this.Isbn == ((Libro)obj).Isbn &&
                   this.Autor == ((Libro)obj).Autor;

        }

        public override int GetHashCode()
        {
            return NombreLibro.GetHashCode() + Editorial.GetHashCode() + Tema.GetHashCode() + Paginas.GetHashCode() + Isbn.GetHashCode() + Autor.GetHashCode();
        }
        public override string ToString()
        {
            return $"Nombre Libro: {NombreLibro} Editorial: {Editorial} Tema: {Tema} Paginas: {Paginas} ISBN: {Isbn} Autor: {Autor}";
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Libro: {NombreLibro}");
            sb.AppendLine($"Editorial: {Editorial}");
            sb.AppendLine($"Tema: {Tema}");
            sb.AppendLine($"Paginas: {Paginas}");
            sb.AppendLine($"ISBN: {Isbn}");
            sb.AppendLine($"Autor: {Autor}");
            return sb.ToString();
        }

        public bool Validar()
        {
            return (NombreLibro != "") &&
                   (Editorial <= Editorial.Minotauro) &&
                   (Tema <= Tema.Educativo) &&
                   (Paginas > 0) &&
                   (Isbn > 0) &&
                   (Autor != "");
                   
        }
    }
}
