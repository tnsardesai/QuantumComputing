# Simon and Grover Algorithms on Cirq. 

## Team: Pied Piper
## Course: CS 239 - Quantum Programming

### Cirq

**List three aspects of quantum programming in Cirq that turned out to be easy to learn and list three aspects that were difficult to learn.**

Aspects easy to learn were:
1. Integrates very well with existing popular Python libraries like Numpy. 
2. Because it's a Python library, it's easy to combine the classical and quantum computations in one code.
3. Measurement and visualization was very easy.

Aspects difficult to learn were:
1. Building custom gates.
2. Debugging circuit
3. - none -

**List three aspects of quantum programming in Cirq that the language supports well and list three aspects that Cirq supports poorly.**

Three aspects that it supports well:
1. One of the advantages I found of using cirq over pyquil is priting the circuit. In pyquil the circuit is printed sequentially where as in Cirq we get a circuit diagram as output which is very helpful for debugging.
2. Another positive is how the result is returned. Cirq returns a custom object with ceratin functions that make it easy to look at the measurement. The histogram function gives us the probablities over all outputs where as in pyquil we had to write the code for that ourselves.
3. Easily integrates with numpy.

Three aspects that it supports poorly.
1. We think that the way we created custom gates was simpler in pyquil than Cirq. As the same time it feels that this might be dependent on the application as according to Cirq documentation we can use _decompse_ method to build a gate out of known gates.
2. Building the ciruit is a little bit more tedious than in pyquil. In pyquil we could just do += and keep adding to the program. Although one nice this is the `on_each` function
3. For building custom gates we have to create a class where as in pyquil it was simpler. This is only negative for smaller programs like the one in this assignment but I can see how that is helpful with a larger code base.

**Which feature would you like Cirq to support to make the quantum programming easier?**

I think one nice feature would be to add a seed variable to the simulator so that we can generate consitent results for easier debugging.

**List three positives and three negatives of the documentation of Cirq.**

Positives:
1. API reference page was really helpful. https://cirq.readthedocs.io/en/stable/api.html
2. Example page was also helpful because of lack of documentation in some places. https://cirq.readthedocs.io/en/stable/examples.html#grover
3. Installation & documentation for it was straightforward compared to pyquil

Negatives:
1. Documentation in some places is incomplete. For example bottom of https://cirq.readthedocs.io/en/stable/gates.html
2. It was very hard to find documentation for building custom gates
3. -none-

**In some cases, Cirq has its own names for key concepts in quantum programming.  Give a dictionary that maps key concepts in quantum programming to the names used in Cirq.**

In class we abstracted the difference between different qubits, however in Cirq we have to explicitly 
specify which quibit we are working with by indexing them with a number. Most of the other PyQuil names 
were very similar to what we learned in class. For example. 


| PyQuil Names | Key concepts on Quantum Programming |
| ------------ | ----------------------------------- |
| I(*qubits) | Applies I to all qubits passed |
| H(*qubits) | Applies H to all qubits passed |


**How much type checking does the Cirq implementation do at run time when a program passes data from the classical side to the quantum side and back?**

Python is a dynamically typed language and so type checking has to be explicitly done by the programmer using isinstance() and type() functions. Now as the Criq is a library in Python, the authors of this code will have to explicitly do that on their own. From our work we saw that Cirq does enough type checking to give us errors. It also has certain constructs like defining _unitary_ for custom gates which we have to follow.
