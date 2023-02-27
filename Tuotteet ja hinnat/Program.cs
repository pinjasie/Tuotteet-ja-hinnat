using System;
    class Hinnat
    {
    static void Main(string[] args)
    {
        string[] tuotteet = { "Vasara ", "Saha ", "Kirves " }; //tuotteet-listan alustus
        int[] hinnat = { 5, 10, 15 }; //hinnat-listan alustus
        Console.WriteLine("Tehtävä 8.2"); //tulostaa tehtävä 8.2, alempi rivi katkoviivan
        Console.WriteLine("--------------");
        Console.OutputEncoding = System.Text.Encoding.UTF8; //€-merkin tulostuksen mahdollistaminen
        for(int i = 0; i < tuotteet.Length; i++) //for-silmukka, jonka avulla molemmat listat tulostuvat täysimittaisina
        {
            Console.WriteLine(tuotteet[i] + hinnat[i] + '€'); //tulostaa kaikki rivit sekä tuotteista että hinnoista
        }
    }
    }
