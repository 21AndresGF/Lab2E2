using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2E2.Models
{
    public class Nodo<T> where  T:IComparable
    {
        int posicion { get; set;}
        int anterior { get; set;}
        int siguiente { get; set; }
        T dato { get; set; }

    }
}
