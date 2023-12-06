using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mathematisch belegte Funktionen für den
            // Wichsgeschwindigkeitsrechner3000 auf GeoGebra: https://www.geogebra.org/calculator/vxukknrf

            // Intensität (Multiplikator des wichsens)
            double wichsIntensität = 1.1;
            // Wichsbeschleunigung in Masturbationen/Sekunde^2
            double wichsBeschleunigung = 1.2;
            // Zeit für die gewichst werden soll
            double wichsZeit = 15;
            // Ob gewichst werden soll
            bool wirdGewichst = true;

            Console.WriteLine("Wichsgeschwindigkeitsrechner3000 D:");
            
            // Beendet das Programm, wenn nicht gewichst wird.
            if (wirdGewichst == true)
            {
                Console.WriteLine("ACHTUNG, ES WIRD GEWICHST!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Es wird leider nicht gewichst... :c");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int i = 1; i <= wichsZeit; i++)
            {
                Console.WriteLine("DIE MOMENTANE WICHSGESCHWINDIGKEIT v BETRÄGT:");

                // Geschwindigkeit (v) nach Geschwindigkeits-Zeit-Gesetz "v = a * t * i"
                // Geschwindigkeit = Beschleunigung * Zeit. Wird mit Intensität multipliziert.
                Console.WriteLine(wichsBeschleunigung * i * wichsIntensität + " M/s (MASTURBATIONEN/SEKUNDE)...");

                Console.WriteLine("UND DIE ABMASTURBIERTE COCKSTRECKE BETRÄGT:");

                // Bewegungsgesetz der gleichmäßig beschleunigten Bewegung "s = (v^2)/(2*a)"
                // wobei v durch "wichsBeschleunigung * i * wichsIntensität" (Beschleunigung * Zeit * Intensität) dargestellt wird.
                Console.WriteLine(((wichsBeschleunigung * i * wichsIntensität)*(wichsBeschleunigung * i * wichsIntensität)) / (2 * wichsBeschleunigung) + " COCKS...");
                

                // wenn laufende wichs-Zeit 1s beträgt, wird "SEKUNDE" ausgegeben. Sonst "SEKUNDEN".
                if (i != 1)
                {
                    Console.WriteLine("...NACH NUR " + i + " SEKUNDEN! :O");
                }
                else
                {
                    Console.WriteLine("...NACH NUR " + i + " SEKUNDE! :O");

                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
