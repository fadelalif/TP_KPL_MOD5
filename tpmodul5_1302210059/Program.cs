// See https://aka.ms/new-console-template for more information
using System;
public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
public class Program
{
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Fadel Alif Sadena\n");

        string nim = "1302210059";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}