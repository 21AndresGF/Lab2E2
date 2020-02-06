using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2E2.Models
{
    public class Nodo<T> where T : IComparable
    {
        int posicion;
        int rango;
        public List<List<T>> valores;
        public List<T> Datos;
        public List<int> hijos;        
        public List<int> id;
        public List<int> padre;

        bool isLeaf;
        public Nodo(int dato) 
        {
            rango = dato;
            Datos = new List<T>();
            hijos = new List<int>();
            id = new List<int>();
            posicion = 1;

        }
        public int Getroot() 
        {
            int iconteo = 0;
            for (int i = 0; i < padre.Count; i++)
            {
                if (padre[i] == 0)
                {
                    iconteo = i;
                }
            }
            return iconteo;
        }
        public void insertar(T dato, int root) 
        {
            
        }
        public T search(T dato, Nodo<T> arreglo) 
        {
            return dato;
        }
    }
}
