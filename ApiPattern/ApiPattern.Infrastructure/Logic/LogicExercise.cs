using ApiPattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPattern.Infrastructure.Logic
{
    public class LogicExercise : ILogExercise
    {

        // // PATRÓN: Servicio - Esta es la implementación del Servicio, que proporciona la lógica para el cálculo.
        public bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public List<int> FindPrimes(int i, int n)
        {
            List<int> primes = new List<int>();
            while (primes.Count < n)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
                i++;
            }
            return primes;
        }
    }
}
