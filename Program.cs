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



public class Course
{
    private static int compteur = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public int Credits { get; set; }
    public bool IsMandatory { get; set; }

    public List<Student> Students;

    // Constructeur sans paramètres
    public Course()
    {
        Id = compteur;
        compteur++;
        Students = new List<Student>();
    }

    // Constructeur complet
    public Course(string name, int credits, bool isMandatory)
    {
        Id = compteur;
        compteur++;

        Name = name;
        Credits = credits;
        IsMandatory = isMandatory;

        Students = new List<Student>();
    }

    // Constructeur simplifié
    public Course(string name)
    {
        Id = compteur;
        compteur++;

        Name = name;

        Students = new List<Student>();
    }
}


class Program
{
    static void Main()
    {
        // Création des étudiants
        Student alice = new Student("Alice", 16, true);
        Student bernard = new Student("Bernard", 14, false);
        Student emma = new Student("Emma", 17);
        emma.IsScholarshipHolder = true;

        Student lucas = new Student("Lucas", 12, false);
        Student sarah = new Student("Sarah", 18, true);

        List<Student> students = new List<Student>();
        students.Add(alice);
        students.Add(bernard);
        students.Add(emma);
        students.Add(lucas);
        students.Add(sarah);

        // Création des cours
        Course maths = new Course("Mathématiques", 5, true);
        Course info = new Course("Informatique", 6, true);
        Course anglais = new Course("Anglais", 3, false);
        Course histoire = new Course("Histoire", 2, false);

        List<Course> courses = new List<Course>();
        courses.Add(maths);
        courses.Add(info);
        courses.Add(anglais);
        courses.Add(histoire);

        // Inscription des étudiants
        maths.Students.Add(alice);
        maths.Students.Add(bernard);
        maths.Students.Add(emma);

        info.Students.Add(bernard);
        info.Students.Add(lucas);

        anglais.Students.Add(alice);
        anglais.Students.Add(sarah);

        histoire.Students.Add(lucas);

        // Exercice 7 : afficher les cours
        Console.WriteLine("Liste des cours :");
        foreach (Course c in courses)
        {
            Console.WriteLine(c.Name + " - crédits : " + c.Credits +
            " - obligatoire : " + c.IsMandatory +
            " - étudiants : " + c.Students.Count);
        }

        Console.WriteLine();

        // Exercice 8 : afficher étudiants d'un cours
        foreach (Course c in courses)
        {
            Console.WriteLine("Cours : " + c.Name);

            foreach (Student s in c.Students)
            {
                Console.WriteLine(" - " + s.Name);
            }

            Console.WriteLine();
        }

        // Exercice 9 : cours obligatoires
        Console.WriteLine("Cours obligatoires :");
        foreach (Course c in courses)
        {
            if (c.IsMandatory)
                Console.WriteLine(c.Name);
        }

        Console.WriteLine();

        // Exercice 10 : étudiants boursiers
        Console.WriteLine("Etudiants boursiers :");
        foreach (Student s in students)
        {
            if (s.IsScholarshipHolder)
                Console.WriteLine(s.Name);
        }

        Console.WriteLine();

        // Exercice 11 : moyenne > 15
        Console.WriteLine("Etudiants avec moyenne > 15 :");
        foreach (Student s in students)
        {
            if (s.Average > 15)
                Console.WriteLine(s.Name);
        }

        Console.WriteLine();

        // Exercice 12 : supprimer Lucas de Histoire
        histoire.Students.Remove(lucas);

        Console.WriteLine("Etudiants dans Histoire après suppression :");
        foreach (Student s in histoire.Students)
        {
            Console.WriteLine(s.Name);
        }

        Console.WriteLine();

        // Vérifier les ID
        Console.WriteLine("ID étudiants :");
        foreach (Student s in students)
        {
            Console.WriteLine(s.Name + " ID : " + s.Id);
        }

        Console.WriteLine();

        Console.WriteLine("ID cours :");
        foreach (Course c in courses)
        {
            Console.WriteLine(c.Name + " ID : " + c.Id);
        }
    }
}