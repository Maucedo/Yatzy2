// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

int slag = 0;
var random = new Random();
var tärningar = new List<Tärning>(5);
for (int i = 0; i < tärningar.Capacity; i++)
{
    tärningar.Add(new Tärning(random.Next(1, 7)));
}


var tärnspara = TärningsRunda(random, tärningar, slag);
slag += 1;
Console.WriteLine("Slå igen?");
Console.ReadLine();

tärnspara = TärningsRunda(random, tärningar, slag);
slag += 1;

Console.WriteLine("Slå igen?");
Console.ReadLine();

tärnspara = TärningsRunda(random, tärningar, slag);


static List<int> TärningsRunda(Random random, List<Tärning> tärningar, int slag)
{
    foreach (Tärning y in tärningar)
    {
        Console.WriteLine(y.tärningsnum + " " + y.spara);
    }
    List<int> tärnspara = new List<int>();
    Console.WriteLine();
    if (slag < 2)
    {
        Console.Write("Vad ska sparas? ");
        tärnspara = Console.ReadLine().Split(",").Select(int.Parse).ToList();
        foreach (var t in tärnspara)
        {
            tärningar[t - 1].spara = true;
        }

        foreach (var t in tärningar)
        {
            if (t.spara == false)
            {
                t.tärningsnum = random.Next(1, 7);
            }

            t.spara = false;
        }
    }
    else
    {
        var lista1 = new LIST<int> (5);
        foreach (var värde in tärningar)
        {
            for (int i = 0; i < tärningar.length; i++ )
                {
                if (lista1.contains(tärningar[i]))
                    {
                    continue;
                    }
                else
                {
                    lista1[i] = värde;
                }
                }
            }
        }
        foreach (var restärn in tärningar)
        {
            int y = 0;
            for (int i = 0; i < tärningar.Capacity; i++)
            {
                if (y == i)
                {
                    continue;
                }
                else if(tärningar[i].tärningsnum == restärn.tärningsnum)
                {   
                    Console.WriteLine("we");
                    break;
                }
                else
                {
                    y++;
                }

            }
        }
    }
    return tärnspara;
}

class Tärning
{
    public int tärningsnum;
    public bool spara;

    public Tärning(int tärningsnum, bool spara = false)
    {
        this.tärningsnum = tärningsnum;
        this.spara = spara;
    }
}
