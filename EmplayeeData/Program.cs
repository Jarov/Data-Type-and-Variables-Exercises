﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplayeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char Gender = char.Parse(Console.ReadLine());
            long PersonalID = long.Parse(Console.ReadLine());
            long employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName} \nLast name: {lastName} \nAge: {age} \nGender: {Gender} \nPersonal ID: {PersonalID} \nUnique Employee number: {employeeNumber}");
        }
    }
}
