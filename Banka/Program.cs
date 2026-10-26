Ucet u1 = new Ucet();
u1.cislo = "SK01";
u1.majitel = "Jozef";
u1.zostatok = 100m;

Ucet u2 = new Ucet();
u2.cislo = "SK02";
u2.majitel = "Alex";
u2.zostatok = 100m;

//ucet 1 sa tu zacina
Console.WriteLine("=== Ucet 1 (" + u1.majitel + ") ===");
Console.WriteLine("zaciatocny zostatok: " + u1.zostatok);

u1.VlozPeniaze(50m);
Console.WriteLine("po vklade 50: " + u1.zostatok);

u1.VlozPeniaze(-20m);
Console.WriteLine("po vklade -20 nemalo by sa menit: " + u1.zostatok);

bool ok = u1.VyberPeniaze(30m);
Console.WriteLine("vyber 30 uspel? " + ok + ", zostatok: " + u1.zostatok);

ok = u1.VyberPeniaze(1000m);
Console.WriteLine("vyber 1000 uspel? " + ok + ", zostatok: " + u1.zostatok);

ok = u1.VyberPeniaze(-10m);
Console.WriteLine("vyber -10 uspel? " + ok + ", zostatok: " + u1.zostatok);

Console.WriteLine();

//ucet 2 sa tu zacina
Console.WriteLine("=== Ucet 2 (" + u2.majitel + ") ===");
Console.WriteLine("zaciatocny zostatok: " + u2.zostatok);

u2.VlozPeniaze(200m);
Console.WriteLine("po vklade 200: " + u2.zostatok);

u2.VlozPeniaze(-5m);
Console.WriteLine("po vklade -5 nemalo by sa menit: " + u2.zostatok);

ok = u2.VyberPeniaze(700m);
Console.WriteLine("vyber 700 uspel? " + ok + ", zostatok: " + u2.zostatok);

ok = u2.VyberPeniaze(1m);
Console.WriteLine("vyber 1 uspel? " + ok + ", zostatok: " + u2.zostatok);

ok = u2.VyberPeniaze(-50m);
Console.WriteLine("vyber -50 uspel? " + ok + ", zostatok: " + u2.zostatok);

class Ucet
{
    public string cislo { get; set; }
    public decimal zostatok { get; set; }
    public string majitel { get; set; }

    public decimal VlozPeniaze(decimal suma)
    {
        if (suma > 0)
        {
            zostatok += suma;
        }

        return zostatok;
    }

    public bool VyberPeniaze(decimal suma)
    {
        if (suma > 0 && zostatok >= suma)
        {
            zostatok -= suma;
            return true;
        }

        return false;
    }
}
