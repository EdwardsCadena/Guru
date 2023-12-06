using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPattern.Core.Interfaces
{

    // PATRÓN: Servicio - Esta es la interfaz del Servicio, que declara las operaciones relacionadas para el cálculo.
    public interface ILogExercise
    {
        bool IsPrime(int num);
        List<int> FindPrimes(int i, int n);
    }
}
