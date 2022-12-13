using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especiais_no_csharp.Models
{
    public static class IntExtensions
    {
       public static bool EhPar(this int numero)
       {
            return numero % 2 == 0;
       } 
    }
}