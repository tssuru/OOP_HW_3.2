using System;

namespace HW_GeoObj_3;

class Program
{
    static void Main(string[] args)
    {
        GeoObj obj = new GeoObj(1.1, 2.2, "Object", "Some description");
        River amazon = new River(-2.16, -55.12, 1.5, 6400, "Amazon", "The Amazon River is the largest river in South America and the largest river in the world.");
        Mountain everest = new Mountain(27.98, 86.92, 8850, "Everest", "Mount Everest is a peak in the Himalaya mountain range.It is located between Nepal and Tibet, an autonomous region of China.");
        Console.WriteLine(obj.GetInfo());
        Console.WriteLine(amazon.GetInfo());
        Console.WriteLine(everest.GetInfo());
    }
}

