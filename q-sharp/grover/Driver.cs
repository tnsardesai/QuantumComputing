using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Grover
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var result = RunGroverSearch.Run(qsim).Result;
                System.Console.WriteLine($"f(x) is 1 for x= {result}");
            }
        }
    }
}