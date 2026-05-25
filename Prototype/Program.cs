using System;
using System.Collections.Generic;

public interface ICarClone
{
    Car Clone();
}

public class Car : ICarClone
{
    private string _brand;
    private string _model;
    private string _color;
    private int _year;
    public Car(string brand, string model, int year, string color)
    {
        _brand = brand;
        _model = model;
        _year = year;
        _color = color;
    }
    private Car(Car original)
    {
        _brand = original._brand;
        _model = original._model;
        _color = original._color;
        _year = original._year;
    }
    public void SetColor(string color)
    {_color = color;}
    public void SetYear(int year)
    {_year = year;}
    public Car Clone()
    {return new Car(this);}
    public void Show()
    { Console.WriteLine($"{_brand} {_model}, {_year}, {_color}"); }
}

class Program
{
    static void Main()
    {
        Car original = new Car("Toyota", "Camry", 2020, "Белый");

        Car clone1 = original.Clone();
        Car clone2 = original.Clone();
        
        clone1.SetColor("Красный");
        clone2.SetColor("Чёрный");
        clone1.SetYear(2022);
        clone2.SetYear(2025);

        Console.WriteLine("Оригинал:");
        original.Show();

        Console.WriteLine("\nКлон 1:");
        clone1.Show();

        Console.WriteLine("\nКлон 2:");
        clone2.Show();
    }
}