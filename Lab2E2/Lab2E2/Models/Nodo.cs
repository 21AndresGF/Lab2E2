using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2E2.Models
{
    public class Nodo<T> where  T:IComparable
    {
        public List<T> Datos = new List<T>();
        List<Nodo<T>> Hijos = new List<Nodo<T>>();

        public void insertar(T dato) 
        {
            
        }
        public T search(T dato) 
        {
            return dato;
        }
    }
}
