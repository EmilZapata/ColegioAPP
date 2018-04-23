using Colegio.Context.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestConsol
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOSSSSSSSSSSSSSSSSSS A LOS TESTING... ESTO SE PONDRA BUENO NO TE PREOCUPES");
            Console.WriteLine("**********************************************");

            using (var context = new ConcebirContext())
            {
                var colegios = context.Colegios.ToList();
                foreach (var col in colegios)
                {
                    Console.WriteLine(col.Col_Id + " " + col.Col_Nombre + " " + col.Col_Direccion + " " + col.Col_Codigo);
                }
                Console.Read();
            }
        }
    }
}
