namespace Grover
{

    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;

    
    operation Oracle_Reference (queryRegister : Qubit[], target : Qubit, pattern : Bool[]) : Unit
    is Adj {        
        (ControlledOnBitString(pattern, X))(queryRegister, target);
    }
    
    
    operation OracleConverterImpl_Reference (markingOracle : ((Qubit[], Qubit) => Unit is Adj), register : Qubit[]) : Unit
    is Adj {
        
        using (target = Qubit()) {
            // Put the target into the |-⟩ state
            X(target);
            H(target);
                
            // Apply the marking oracle; since the target is in the |-⟩ state,
            // flipping the target if the register satisfies the oracle condition will apply a -1 factor to the state
            markingOracle(register, target);
                
            // Put the target back into |0⟩ so we can return it
            H(target);
            X(target);
        }
    }
    
    
    function OracleConverter_Reference (markingOracle : ((Qubit[], Qubit) => Unit is Adj)) : (Qubit[] => Unit is Adj) {
        return OracleConverterImpl_Reference(markingOracle, _);
    }

    operation HadamardTransform_Reference (register : Qubit[]) : Unit
    is Adj {        
        ApplyToEachA(H, register);
    }
    
    operation ConditionalPhaseFlip_Reference (register : Qubit[]) : Unit {
        
        body (...) {
            // Define a marking oracle which detects an all zero state
            let allZerosOracle = Oracle_Reference(_, _, new Bool[Length(register)]);
            
            // Convert it into a phase-flip oracle and apply it
            let flipOracle = OracleConverter_Reference(allZerosOracle);
            flipOracle(register);
        }
        
        adjoint self;
    }
    
    
    operation PhaseFlip_ControlledZ (register : Qubit[]) : Unit {

        body (...) {
            // Alternative solution, described at https://quantumcomputing.stackexchange.com/questions/4268/how-to-construct-the-inversion-about-the-mean-operator/4269#4269
            ApplyToEachA(X, register);
            Controlled Z(Most(register), Tail(register));
            ApplyToEachA(X, register);
        }
        
        adjoint self;
    }
    
    
    operation GroverIteration_Reference (register : Qubit[], oracle : (Qubit[] => Unit is Adj)) : Unit
    is Adj {
        
        oracle(register);
        HadamardTransform_Reference(register);
        ConditionalPhaseFlip_Reference(register);
        HadamardTransform_Reference(register);
    }
    
    
    operation GroversSearch_Reference (register : Qubit[], oracle : ((Qubit[], Qubit) => Unit is Adj), iterations : Int) : Unit
    is Adj {
        
        let phaseOracle = OracleConverter_Reference(oracle);
        HadamardTransform_Reference(register);
            
        for (i in 1 .. iterations) {
            GroverIteration_Reference(register, phaseOracle);
        }
    }

    operation RunGroverSearch() : Int[] {
        // Number of qubits
        let n = 5;
        // Define the x such that f(x) = 1.
        let pattern = [false, false, true, true, false];

        // Get the oracle
        let markingOracle = Oracle_Reference(_, _, pattern);
        let oracle = OracleConverter_Reference(markingOracle);
        
        // Run the Grover search algorithm
        using (x = Qubit[n]) {
            
            // Hadamard Transform
            HadamardTransform_Reference(x);
        
            let iterations = Floor((3.14/4.0) * Sqrt(PowD(2.0, IntAsDouble(n))));
            Message($"Number of iterations: {iterations}");
            
            for (i in 1 .. iterations) {
                GroverIteration_Reference(x, oracle);
            }

            mutable r = new Int[n];
            for (i in 0..(n-1)) {
                if (M(x[i]) != Zero) {
                    set r w/= i <- 1;
                }
            } 

            ResetAll(x);

            return r;
        }
    }
}
