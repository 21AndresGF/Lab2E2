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
        public List<int> NoHijos;
        public int[] hijos;
        public List<int> id;
        public List<int> padre;

        bool isLeaf;
        public Nodo(int dato)
        {
            rango = dato;
            Datos = new List<T>();
            hijos = NoHijos.ToArray();
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
        public void NewBrother(int posicion, int hermano)
        {
            id.Add(posicion + 1);
            if (HasFather(hermano))
            {
                padre.Add(padre[hermano]);
            }
            else
            {
                padre.Add(padre[posicion + 2]);
            }
            Array.Resize(ref hijos, hijos.Length + 1);
            hijos[posicion + 1] = 0;
            valores.InsertRange(posicion + 1, null);


        }
        public void NewFather()
        {
            id.Add(posicion + 2);
            posicion = posicion + 2;


        }
        
        public void insertar(T dato, int nodo)
        {
            List<T> temp = new List<T>();
            //manejo por casos
            valores[nodo].Add(dato);
            valores[nodo].Sort();
            if (IsFull(nodo))
            {
                if (HasFather(nodo))
                {
                    temp.AddRange(valores[nodo]);
                    NewBrother(posicion, nodo);
                    valores[nodo].RemoveRange(valores.IndexOf(valores[nodo]), valores[nodo].Count);
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (i < temp.Count / 2)
                        {
                            valores[nodo].Add(temp[i]);
                        }
                        else if (i > temp.Count / 2)
                        {
                            valores[posicion + 1].Add(temp[i]);
                        }
                    }
                    insertar(temp[temp.Count / 2],padre[nodo]);
                }
                else
                {
                    temp.AddRange(valores[nodo]);
                    NewBrother(posicion, nodo);
                    valores[nodo].RemoveRange(valores.IndexOf(valores[nodo]), valores[nodo].Count);
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (i < temp.Count / 2)
                        {
                            valores[nodo].Add(temp[i]);
                        }
                        else if (i > temp.Count / 2)
                        {
                            valores[posicion + 1].Add(temp[i]);
                        }
                    }
                    NewFather();
                } 
            }
            
        }

        public T search(T dato, Nodo<T> arreglo) 
        {
            return dato;
        }
        public bool IsFull(int posicion) 
        {
            if (valores[posicion].Count >= rango-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasFather(int papa)
        {
            if (padre[papa] != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
