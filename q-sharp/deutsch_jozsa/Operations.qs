namespace deutsch_jozsa
{
  open Microsoft.Quantum.Canon;
  open Microsoft.Quantum.Intrinsic;
  open Microsoft.Quantum.Diagnostics;
  open Microsoft.Quantum.Convert;
  open Microsoft.Quantum.Arrays;

  operation Oracle_Zero_Reference (x : Qubit[], y : Qubit) : Unit 
  is Adj {
    // Since f(x) = 0 for all values of x, |y ⊕ f(x)⟩ = |y⟩.
    // This means that the operation doesn't need to do any transformation to the inputs.
    // Build the project and run the tests to see that T01_Oracle_Zero_Test test passes.
  }

  operation Oracle_One_Reference (x : Qubit[], y : Qubit) : Unit 
  is Adj {
      X(y);
  }

  operation Oracle_OddNumberOfOnes_Reference (x : Qubit[], y : Qubit) : Unit 
    is Adj {       
        for (q in x) {
            CNOT(q, y);
        }
    }

  operation Oracle_ProductFunction_Reference (x : Qubit[], y : Qubit, r : Int[]) : Unit
    is Adj {        
        EqualityFactI(Length(x), Length(r), "Arrays should have the same length");
            
        for (i in IndexRange(x)) {
            if (r[i] == 1) {
                CNOT(x[i], y);
            }
        }
    }

  operation DeutschJozsa (N : Int, Uf : ((Qubit[], Qubit) => Unit)) : Bool {
    mutable result = true;
    using ((x, b) = (Qubit[N], Qubit())) {
      ApplyToEachA(H, x);
      X(b);
      H(b);

      Uf(x, b);

      ApplyToEach(H, x);

      mutable r = new Int[N];

      for (i in 0..N-1) {
        if (M(x[i]) != Zero) {
          set r w/= i <- 1;
        }
      }

      for (i in 0 .. N - 1) {
        set result = result and r[i] == 0;
      }
      ResetAll(x);
      Reset(b);
    }
    return result;
  }


  operation BernsteinVazirani (N : Int, Uf : ((Qubit[], Qubit) => Unit)) : Int[] {
    using ((x, b) = (Qubit[N], Qubit())) {

      ApplyToEachA(H, x);
      X(b);
      H(b);

      Uf(x, b);

      ApplyToEach(H, x);

      mutable r = new Int[N];

      for (i in 0..N-1) {
        if (M(x[i]) != Zero) {
          set r w/= i <- 1;
        }
      }

      ResetAll(x);
      Reset(b);

      return r;

    }
  }

  operation RunDeutschJozsa(N : Int) : Unit {
    Message("Running the Deutsch Josza Problem");
    Message("--------------------------------");
    // mutable result = new Bool[4];
    let operator_list = [Oracle_OddNumberOfOnes_Reference] ;
                        //  Oracle_One_Reference, 
                        //  Oracle_OddNumberOfOnes_Reference];
    // for (i in 0..2) {
    let result = DeutschJozsa(N, operator_list[0]);
    Message($"{operator_list[0]} is a constant function?: {result}");
    // }
    Message("");
  }

  operation RunBernsteinVazirani() : Unit{
    let a = [1, 1, 1, 0];
    Message("Running the Bernstein Vazirani Problem");
    Message("--------------------------------");
    // This oracle function calculates (x*a + 2)
    let oracle = Oracle_ProductFunction_Reference(_, _, a);
    mutable result = BernsteinVazirani(Length(a), oracle);
    Message($"'a' in oracle: {a}");
    Message($"Result after running Quantum Algorithm: {result}");
  }
}
