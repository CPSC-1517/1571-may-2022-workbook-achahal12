﻿// See https://aka.ms/new-console-template for more information
using OOPsReview.Data;


//console is a static class
//you CANNOT create your own instance of a static class

Console.WriteLine("Hello, World!");

//an instance class needs to be created using the new command and the class constructor
// one needs to decleare a variable of datatype employment
Employment myEmp = new Employment("Level 5 Programer", SupervisoryLevel.Supervisor,-15.9); //default constructor
Console.WriteLine(myEmp.ToString()); // use the instance name to reference items within your class

myEmp.SetEmploymentResponsibilityLevel(SupervisoryLevel.DepartmentHead);

Console.WriteLine(myEmp.ToString());

