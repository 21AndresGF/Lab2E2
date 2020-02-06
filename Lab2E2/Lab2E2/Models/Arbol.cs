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
        public int posicion1;
        public BebidaClase objeto1;

        public Arbol()
        {
            grado = 5;
        }
        
        public int root { get; set; }

        public void search (BebidaClase objeto, int posicion)
        {
            objeto = objeto1;
            posicion = posicion1;
            return objeto;
        }

        public void insertar()
        {

        }

        //public search(BebidaClase objeto)
        //{
        //    BebidaClase dato;
        //    dato = Nodo.search(objeto);
        //    return dato;
        //}
    }
}
