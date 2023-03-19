// See https://aka.ms/new-console-template for more information
using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }

    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Fadel Alif Sadena");
    }
}