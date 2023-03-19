// See https://aka.ms/new-console-template for more information
using System;

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
        string nim = "1302210059";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}