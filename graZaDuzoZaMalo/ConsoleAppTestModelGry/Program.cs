﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGry;

namespace ConsoleAppTestModelGry
{
    class Program
    {
        static void Main(string[] args)
        {
            Gra g = new Gra(1, 10);
            Console.WriteLine(g.Ocena(propozycja: 5));
            Console.WriteLine(g.LicznikRuchow);
            Console.WriteLine(g.Ocena(propozycja: 7));
            //g.LicznikRuchow = -1;
            Console.WriteLine(g.LicznikRuchow);
            //historia gry
            foreach( var ruch in g.Historia )
            {
                Console.WriteLine(ruch);
            }
        }
    }
}
