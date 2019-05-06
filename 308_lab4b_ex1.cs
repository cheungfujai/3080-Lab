using System;
using System.Collections.Generic;

public class Person{
    private string name;
    public string Name{
        get { return name; }
    }
    private int age;
    public int Age{
        get { return age; }
    }
    private string gender;
    public string Gender{
        get { return gender; }
    }
    public Person (string pName, int pAge, string pGender){
        name = pName;
        age = pAge;
        gender = pGender;
    }
}

public class Program{
    public static void Main(){
        Person student1 = new Person("Kevin", 23, "M");
        Person student2 = new Person("Chloe", 20, "F");
        Person student3 = new Person("Mary", 18, "F");

        Console.Writeline(Person);

    }
}