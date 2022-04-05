using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata_Equipo9
{
    public class FizzBuzz
    {
        List<Object> cienNumeros = new List<Object>();

        public List<Object> getList()
        {

            for (int i = 1; i <= 100; i++)
            {

                cienNumeros.Add(IsFizzBuzzFor(i) ? "FizzBuzz" : IsFizzFor(i) ? "Fizz" : IsBuzzFor(i) ? "Buzz" : (i as object));
            }

            return cienNumeros;

        }

        private bool IsFizzFor(int number)
        {
           
            return (number % 3 == 0);
        }
        private bool IsBuzzFor(int number)
        {
            return (number % 5 == 0);
        }
        private bool IsFizzBuzzFor(int number)
        {
            return (IsFizzFor(number) && IsBuzzFor(number));
        }

    }
}
