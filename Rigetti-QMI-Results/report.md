# Report for run on Rigetti's quantum computer

For this assignment we ran the pyquil code written earlier in the quarter on Rigetti's quantum computer, Aspen-4-16Q-A, using the Quantum Cloud Services platform instead of the server provided in class.

We ran an edited version of our pyquil code and have saved the output of the jupyter document in the form of a pdf. All 3 pdfs are included in the submission along with this report.

1. Evaluation

* Run each program multiple times and present statistics of the results.

Each pdf prints this result.

* Discuss whether different cases of U_f lead to different execution time.

We saw different cases of U_f lead to different execution time in DJ and BV as noted in the pdf. For grover we saw that different U_f didn't give a different execution time. For simons it doesn't make sense to compare execution time as number of iteration is based on "luck".

* What is your experience with scalability as n grows?  Present a diagram that maps n to execution time.

Our program kept crashing when using more than 4-5 qubits which is why we weren't able to get nice graphs. Our current plots are in the pdfs and we see almost linear growth but not sure if it is exponential or linear for higher number of qubits.

* Compare your results from running on the quantum computer with your results from running on the simulator.

For qubits 1-3 it is comparable in speed. But for higher quantum computer is faster.

2. Instructions

The code can be run just like our quantum computer. How to run each function and inputing f is written at the end of the notebook.

3. PyQuil

* Which restrictions on PyQuil programs did you experience when moving from the simulator to the quantum computer?

We had compiler timeout when running of programs with more than 5-6 qubits. Other than that we changed nothing except the migration from qvm to qmi.


