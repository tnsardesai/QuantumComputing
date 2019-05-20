# Simon and Grover Algorithms on PyQuil. 

## Team: Pied Piper
## Course: CS 239 - Quantum Programming

### PyQuil

**List three aspects of quantum programming in PyQuil that turned out to be easy to learn and list three aspects that were difficult to learn.**

Aspects easy to learn were:
1. It's extremely easy to build and test quantum circuits. 
2. Integrates very well with existing popular Python libraries like Numpy. 
3. Because it's a Python library, it's easy to combine the classical and quantum computations in one code. 

Aspects difficult to learn were:
There is nothing that we found that hard about PyQuil. Given that the algorithm was covered well in class and the documentation was easy to understand, we didn't face much hardship about this assignment.

**List three aspects of quantum programming in PyQuil that the language supports well and list three aspects that PyQuil supports poorly.**

Three aspects that it supports well:
1. The addition of quantum gates just by += is a very good and intuitive way for creating quantum circuits.
2. The format of returned qubits is also very easy to understand and deal with.
3. Easily integrates with third party libraries like NumPy etc.

Based on the HW programs that we have written, we felt that for our purposes, PyQuil 
supported everything very well. For the most part, we wanted to write clean Pythonic code
with easy to use numpy library functions and PyQuil all of them with in the best way possible. 


**Which feature would you like PyQuil to support to make the quantum programming easier?**

It would be nice to see PyQuil support data visualization features after n number of trials. For these homeworks, we wrote our own code to help plot the success rate and execution time for various inputs but it would be helpful for future developers to have an inbuilt PyQuil function to do that. This would help reduce the debugging time when writing quantum programs. 

**List three positives and three negatives of the documentation of PyQuil.**

Positives:
1. It was clear and concise.
2. Gave step by step instructions on how to setup the virtual environment. 
3. Gave an indepth API reference to help understand the different parameters the API functions require and what the default values were set to. 

I can't think of any negatives on the documentation. I think it is very well written. 

**In some cases, PyQuil has its own names for key concepts in quantum programming.  Give a dictionary that maps key concepts in quantum programming to the names used in PyQuil.**

In class we abstracted the difference between different qubits, however in PyQuil we have to explicitly 
specify which quibit we are working with by indexing them with a number. Most of the other PyQuil names 
were very similar to what we learned in class. For example. 


|PyQuil Names                        | Key concepts on Quantum Programming|
---------------------------------------------------------------------------------
|I(qubit)                            | Produces the I identity gate.|
|X(qubit)                            | Produces the X (“NOT”) gate.|
|Y(qubit)                            | Produces the Y gate.|
|Z(qubit)                            | Produces the Z gate.|
|CZ(control, target)	             | Produces a controlled-Z gate.|
|CNOT(control, target)	             | Produces a controlled-NOT (controlled-X) gate.|
|CCNOT(control1, control2, target)	 | Produces a doubly-controlled NOT gate.|


**How much type checking does the PyQuil implementation do at run time when a program passes data from the classical side to the quantum side and back?**

Python is a dynamically typed language and so type checking has to be explicitly done by the programmer using isinstance() and type() functions. Now as the PyQuil is a library in Python, the authors of this code will have to explicitly do that on their own. Looking at their code in https://github.com/rigetti/pyquil , it's difficult to quantify how of the code is type-checked. It seems like at some places they are doing type-checking before using the passed arg values however in other places they are assuming that the value passed is of correct type. If I had to quantify, I would say that they have enough type-checking in their code for me to not pull my hair during coding for this homework. 

