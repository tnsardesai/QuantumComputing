using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Common;

namespace deutsch_jozsa
{
  class Driver
  {
    static void Main(string[] args)
    {
      var qsim = new QuantumSimulator();
      var numQubits = 3;
      var result1 = RunDeutschJozsa.Run(qsim, numQubits).Result;
      var result2 = RunBernsteinVazirani.Run(qsim).Result;
      // System.Console.Write(result_dj);     
      // System.Console.Write(result_bv);   
    }
  }
}