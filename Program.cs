using System;

public class Student
{
    private static int compteur = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public double Average { get; set; }
    public bool IsScholarshipHolder { get; set; }

    // Constructeur sans paramètres
    public Student()
    {
        Id = compteur;
        compteur++;
    }

    // Constructeur complet
    public Student(string name, double average, bool isScholarshipHolder)
    {
        Id = compteur;
        compteur++;

        Name = name;
        Average = average;
        IsScholarshipHolder = isScholarshipHolder;
    }

    // Constructeur partiel
    public Student(string name, double average)
    {
        Id = compteur;
        compteur++;

        Name = name;
        Average = average;
    }
}

