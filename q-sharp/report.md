# Report on programming in Q\#

1. Evaluation

Discuss your effort to test the programs and present results from the testing.  Discuss whether different cases of U_f lead to different execution times.
What is your experience with scalability as n grows?  Present a diagram that maps n to execution time.

Presenting and understanding results in this assignment is hard as the base language is C# and Q# is very similar to it. We came across C# libraries like Oxyplot but decided not to use that as we had intuitive results as describe below.

Returning constant and got 233 ms and 204 ms for the always return 0 and always return 1 case. We ran for 1 balanced case based on parity of bits. and saw that it runs in 240 ms. We had seen a difference in execution time when running these same oracles in pyquil assignment. We think one possible explanation is that here we are using the code provided in QuantumKatas repo where the oracle is defined using basic gates like X and CNOT whereas in pyquil we had a custom gate. For known gates the compiler knows how to break it down into simpler gates where as for custom gates pyquil had a hard time doing that. For the simple case of Constant pyquil compiler must have optimized the decomposition.

As we increased the size of n execution time grew exponentially.


2. Instructions

Present a README file that describes how to input the function f, how to run the program, and how to understand the output.

Our code is built on top of the one provided in QuantumKatas. To input a function f one has to build the oracle themselves as we didn't write code to build UF based on f. Examples of building oracle can be found in each directory

To run the code,

For grover and deutsch_jozsa_bernstein_vazirani cd in the directory and then use "dotnet run". For simons cd in the directory and use "dotnet test"

3. Q#

As a reflection on programming in Q#, address the following points.

List three aspects of quantum programming in Q# that turned out to be easy to learn and list three aspects that were difficult to learn.

Easy
1) Understanding "using" block was the easiest thing.
2) Things like ApplyToEach(H, x) made it a lot easier to apply operations
3) Dealing with arrays of qubit is a lot easier in Q# than in pyquil.

Hard
1) Everything outside the "using" block because of our unfamiliarity with C#
2) Integration is messy for smaller programs. In both pyquil and cirq we can write everything in one file but here it seems like Q# and C# need different files.
3) Building oracles based on some classical function is hard.

List three aspects of quantum programming in Q# that the language supports well and list three aspects that Q# supports poorly.

Easy
1) Applying operations to qubits
2) Measurements of qubits
3) Even though Q# has this seemingly obscure requirement for "using" and "borrowing" it has ResetAll and Reset commands.

Hard
As stated already the building oracles. Everything else Q# related was easy to understand (at least for these 3 programs).

Which feature would you like Q# to support to make the quantum programming easier?  

1) Type inference would be helpful although not that important.
2) Results should be more informative and user friendly/

List three positives and three negatives of the documentation of Q#.
Q# document is really nice. Everything you want can be found by just looking at the sidebar menu.

In some cases, Q# has its own names for key concepts in quantum programming.  Give a dictionary that maps key concepts in quantum programming to the names used in Q#.

The only thing we could think of was that functions are called operations. For measurement they use M() but the documentation says that is measurement. The gates are exactly the same name.


The "using" and "borrowing" statements give access to some additional qubits.  At the end of such a statement, each of those qubits must appear unchanged.  Thus, if a qubit was in state ψ at the beginning of such a statement, it can change during the statement, but must be in state ψ at the end.  Show results from experiments that shed light on whether the simulator enforces this.

We are using the "using" statements and saw that if we didn't return the qubits back to the 0 state we get an error which says that we have to reset qubits back to 0 as they are not in rewritable state. Borrowing also has the same enforcement.

Submit five files, one for each program and one with the report.
