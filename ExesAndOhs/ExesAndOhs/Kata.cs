using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs
{
    public static class Kata
    {
        public static bool XO( string input )
        {
            return input.ToLower().Count( s => s == 'o' ) == input.ToLower().Count( s => s == 'x' );
        }
    }
}