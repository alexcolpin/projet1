using System;

class Car
{
    // Propriétés
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructeur vide
    public Car()
    {
        Brand = "Inconnue";
        Model = "Inconnu";
        Year = 0;
    }

    // Constructeur avec brand
    public Car(string brand)
    {
        Brand = brand;
    }

    // Constructeur avec brand et model
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    // Constructeur avec brand, model et year
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Constructeur du défi : brand + year
    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    // Méthode pour afficher la voiture
    public void Afficher()
    {
        Console.WriteLine(Brand + " " + Model + " " + Year);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Car car2 = new Car("Toyota");
        Car car3 = new Car("Toyota", "Corolla");
        Car car4 = new Car("Toyota", "Corolla", 2020);
        Car car5 = new Car("Ford");

        car1.Afficher();
        car2.Afficher();
        car3.Afficher();
        car4.Afficher();
        car5.Afficher();
    }
}