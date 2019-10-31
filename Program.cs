using System;
using System.Collections.Generic;

namespace AkademiaTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* 
            Wszystkie nazwy klas, metod i pól są po angielsku, 
            ponieważ w tym języku pomagają na stackoverflow
            */
            var bikeA = new Bike("szybki");
            var bikeB = new Bike("składak")
            {
                distance = 2.5f
            };

            var bikes = new List<Bike>
            {
                bikeA,
                bikeB,
                new Bike("zwykły")
            };

            foreach (var rower in bikes)
            {
                rower.Move(rower.type == "szybki" ? 2.5f : 1.0f);
            }

            var bikeD = new Bike("bmx");
            bikes.Add(bikeD);
            bikeD.distance = 1.5f;

            foreach (var bike in bikes)
            {
                Console.WriteLine(bike);
            }

            // Ta metoda poczeka na wprowadzenie dowolnego znaku
            Console.ReadKey();
        }
    }
}
