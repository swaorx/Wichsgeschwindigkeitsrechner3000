using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mathematisch belegte Funktionen für den
            // Wichsgeschwindigkeitsrechner3000 auf GeoGebra: https://www.geogebra.org/calculator/vxukknrf

            // Stargeschwindigkeit beim wichsen v0
            double wichsGeschAusg;
            // Intensität (Multiplikator des wichsens)
            double wichsIntensität;
            // Wichsbeschleunigung in Masturbationen/Sekunde^2
            double wichsBeschleunigung;
            // Zeit für die gewichst werden soll
            double wichsZeit;


            Console.WriteLine("Wichsgeschwindigkeitsrechner3000");

            Console.WriteLine("v(t) = a * t * i + v0");
            Console.WriteLine();

            Console.Write("Anfangsgeschwindigkeit in Masturbationen/Sekunde: ");
            wichsGeschAusg = Convert.ToDouble(Console.ReadLine());

            Console.Write("i) Wichs-Intensität: ");
            wichsIntensität = Convert.ToDouble(Console.ReadLine());

            Console.Write("a) Wichs-Beschleunigung: ");
            wichsBeschleunigung = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dauer in Sekunden, für die gewichst wird: ");
            wichsZeit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= wichsZeit; i++)
            {
                Console.WriteLine("DIE MOMENTANE WICHSGESCHWINDIGKEIT v BETRÄGT:");

                // Geschwindigkeit (v) nach Geschwindigkeits-Zeit-Gesetz "v = a * t * i + v0"
                // Geschwindigkeit = Beschleunigung * Zeit + Ausgangsgeschwindigkeit v0. Wird mit Intensität multipliziert.
                Console.WriteLine(wichsBeschleunigung * i * wichsIntensität + wichsGeschAusg + " M/s (MASTURBATIONEN/SEKUNDE)...");

                Console.WriteLine("UND DIE ABMASTURBIERTE COCKSTRECKE BETRÄGT:");

                // Bewegungsgesetz der gleichmäßig beschleunigten Bewegung "s = (v(t)^2)/(2*a)"
                // wobei v durch "wichsBeschleunigung * i * wichsIntensität" (Beschleunigung * Zeit * Intensität) dargestellt wird.
                Console.WriteLine(Math.Pow((wichsBeschleunigung * i * wichsIntensität + wichsGeschAusg), 2) / (2 * wichsBeschleunigung) + " COCKS...");
                

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
