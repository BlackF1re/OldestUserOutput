using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


namespace Oldest;

public class Program
{
    public static void Main()
    {
        //List<User> users = new();
        User[] users = new[]
        {
            new User(1, "Емельянова", "Алина", "Александровна", 45),
            new User(2, "Агеев", "Константин", "Ильич", 18),
            new User(3, "Шмелева", "Татьяна", "Даниэльевна", 58),
            new User(4, "Емельянова", "Алина", "Дмитриевна", 34),
            new User(5, "Тарасов", "Дмитрий", "Тимофеевич", 72),
            new User(6,"Волков", "Руслан", "Максимович", 14),
            new User(7, "Дементьев", "Александр", "Давидович", 21),
            new User(8, "Иванов", "Георгий", "Кириллович", 43),
            new User(9, "Гусев", "Евгений", "Михайлович", 53),
            new User(10, "Зимин", "Андрей", "Леонидович", 68)
        };

        var result = users.Max();
        Console.WriteLine($"{result.ID} | {result.Fname} | {result.Sname} | {result.Sname} | {result.Lname} | {result.Age}");


    }

}