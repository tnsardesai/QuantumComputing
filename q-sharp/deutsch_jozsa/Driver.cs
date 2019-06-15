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
      var watch = new System.Diagnostics.Stopwatch();
      watch.Start();
      var result1 = RunDeutschJozsa.Run(qsim, numQubits).Result;
      watch.Stop();
      System.Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
      // var result2 = RunBernsteinVazirani.Run(qsim).Result;
      // System.Console.Write(result_dj);     
      // System.Console.Write(result_bv);   
    }
  }
}