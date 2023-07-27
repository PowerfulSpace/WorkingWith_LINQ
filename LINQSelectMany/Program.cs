





using System.Collections.Generic;
using System;

var companies = new List<Company>
{
    new Company("Microsoft", new List<Person> {new Person("Tom"), new Person("Bob")}),
    new Company("Google", new List<Person> {new Person("Sam"), new Person("Mike")}),
};


//Возвращаем только имена стотрудников всех компаний
//----------------------------------------------------------
//var employees = companies.SelectMany(c => c.Staff);

//var employees = from c in companies
//                from emp in c.Staff
//                select emp;

//foreach (var emp in employees)
//    Console.WriteLine($"{emp.Name}");

//----------------------------------------------------------


//Возвращаем все компании со всеми их сотрудниками
//----------------------------------------------------------
//var employees = companies.SelectMany(c => c.Staff, (c,emp) => new {Name = emp.Name, Company =c.Name });


//foreach (var emp in employees)
//    Console.WriteLine($"{emp.Name} - {emp.Company}");

//----------------------------------------------------------



var employees = from c in companies
                from emp in c.Staff
                select new { Name = emp.Name, Company = c.Name };

foreach (var emp in employees)
    Console.WriteLine($"{emp.Name} - {emp.Company}");





Console.ReadLine();

record class Company(string Name, List<Person> Staff);
record class Person(string Name);

