using System;
using Sovacy.Models;
namespace Sovacy
{
    class Program
    {
        static void Main (string[] args)
        {
         Mother Karine = new Mother();
            Child Karen = new Child();

            Karen.Cry(Karen);
            Karine.MustEat (Karen);
            Karine.Eat (Karen);
            Karen.Happy();
        }
    }
}
