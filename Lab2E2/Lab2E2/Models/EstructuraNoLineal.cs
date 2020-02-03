using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2E2.Models
{
    public class EstructuraNoLineal<Nodo> where Nodo : IComparable
    {
        public int Grado { get; protected set; }
       

    }
    
}
