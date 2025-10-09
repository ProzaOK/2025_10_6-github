using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_10_6_github
{
    internal class MyCalculator
    {
        public string Input;
        public MyCalculator()
        {
            
        }
        public double Vypocet(string input)
        {
            double vysledek;

            try
            {
                // Vyhodnocení výrazu (používáme DataTable.Compute pro jednoduché příklady)
                var data = new DataTable();
                vysledek = Convert.ToDouble(data.Compute(input, ""));
            }
            catch
            {
                vysledek = double.NaN; // Pokud dojde k chybě, vrátíme NaN
            }
            return vysledek;


            //lev int
            //prav int
            //vys int
            //vys int position x
        }
    }
}
