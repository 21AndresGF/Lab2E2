using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2E2;
namespace Lab2E2.Models
{
    public class Arbol<BebidaClase> where BebidaClase : Icomparable
    {
        public int grado;

        public Arbol()
        {
            grado = 5;
        }
        
        public int root { get; set; }

        public search(BebidaClase objeto)
        {
            BebidaClase dato;
            dato = Nodo.search(objeto);
            return dato;
        }
    }
}
