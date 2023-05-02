﻿using System;

namespace MethodOverridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                Email = "contact@timecorey.com"
            };
            Console.WriteLine(person);

        }
    }
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }
    }
}
