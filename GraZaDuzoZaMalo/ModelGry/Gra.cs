﻿using System;
using System.Collections.Generic;

namespace ModelGry
{
    public partial class Gra
    {
        // inner types
        public enum Odpowiedz { ZaMalo = -1, Trafiono = 0, ZaDuzo = 1 }
        public enum StanGry { Trwa, Odgadnieta, Poddana }

        // fields
        public StanGry Stan { get; private set; }
        public readonly int ZakresOd, ZakresDo;

        // -----------------
        private readonly int wylosowana;
        public int Wylosowana
        {
            get
            {
                // if gra poddana lub zakończona
                return wylosowana;
            }
            //set { }
        }
        // -------------------


        // historia gry ToDo
        public int LicznikRuchow { get; private set; } = 0;


        // constructors
        public Gra(int a, int b)
        {
            ZakresOd = Math.Min(a, b);
            ZakresDo = Math.Max(a, b);
            //losowanie
            wylosowana = Losuj(ZakresOd, ZakresDo);
            Stan = StanGry.Trwa;
            historia = new List<Ruch>();
        }

        public Odpowiedz Ocena(int propozycja)
        {
            LicznikRuchow++;
            Odpowiedz odp;
            if (propozycja < wylosowana)
                odp = Odpowiedz.ZaMalo;
            else if (propozycja > wylosowana)
                odp = Odpowiedz.ZaDuzo;
            else
            {
                Stan = StanGry.Odgadnieta;
                odp = Odpowiedz.Trafiono;
            }
            historia.Add(new Ruch(propozycja, odp));
            return odp;
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }

        public static int Losuj(int a = 1, int b = 100)
        {
            if (a > b)
            {//swap a<-->b
                int tmp = a;
                a = b;
                b = tmp;
            }
            Random generator = new Random();
            return generator.Next(a, b + 1);
        }

    }
}
