using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace deutsch_jozsa
{
  class Driver
  {
    static void Main(string[] args)
    {
      var qsim = new QuantumSimulator();
      var numQubits = 3;
      Result[] bitseq = new Result[] {Result.One, Result.One, Result.Zero, Result.One};
      var result_dj = RunDeutschJozsa.Run(qsim, numQubits).Result;
      // var result_bv = RunBernsteinVazirani.Run(qsim).Result;
      System.Console.Write(result_dj);     
      // System.Console.Write(result_bv);   
    }
  }
}