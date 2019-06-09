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
      // Since f(x) = 1 for all values of x, |y ⊕ f(x)⟩ = |y ⊕ 1⟩ = |NOT y⟩.
      // This means that the operation needs to flip qubit y (i.e. transform |0⟩ to |1⟩ and vice versa).
      X(y);
  }

  operation Oracle_OddNumberOfOnes_Reference (x : Qubit[], y : Qubit) : Unit 
    is Adj {       
        // Hint: f(x) can be represented as x_0 ⊕ x_1 ⊕ ... ⊕ x_(N-1)
        for (q in x) {
            CNOT(q, y);
        }
        // alternative solution: ApplyToEachA(CNOT(_, y), x);
    }

  operation Oracle_Kth_Qubit_Reference (x : Qubit[], y : Qubit, k : Int) : Unit
    is Adj {        
        EqualityFactB(0 <= k and k < Length(x), true, "k should be between 0 and N-1, inclusive");
        CNOT(x[k], y);
    }

  operation Oracle_ProductFunction_Reference (x : Qubit[], y : Qubit, r : Int[]) : Unit
    is Adj {        
        // The following line enforces the constraint on the input arrays.
        // You don't need to modify it. Feel free to remove it, this won't cause your code to fail.
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

      // for (i in 0..N-1) {
      //   Message($"{r}");
      // }

      for (i in 0..N-1) {
        if (M(x[i]) != Zero) {
          set r w/= i <- 1;
        }
      }

      // for (i in 0..N-1) {
      //   Message($"{r}");
      // }

      for (i in 0 .. N - 1) {
        set result = result and r[i] == 0;
      }
      ResetAll(x);
      Reset(b);
    }
    return result;
  }


  operation BernsteinVazirani (N : Int, Uf : ((Qubit[], Qubit) => Unit)) : Int[] {
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

      ResetAll(x);
      Reset(b);

      return r;

    }
  }

  operation AssertDJAlgorithmWorks (N : Int, oracle : ((Qubit[], Qubit) => Unit), expected : Bool, msg : String) : Unit {
        EqualityFactB(DeutschJozsa(N, oracle), expected, msg);
    }

  operation RunDeutschJozsa(N : Int) : Bool[]{
    mutable result = new Bool[4];
    AssertDJAlgorithmWorks(4, Oracle_Zero_Reference, false,  "f(x) = 0 not identified as constant");
    set result w/= 0 <- DeutschJozsa(N, Oracle_Zero_Reference);
    set result w/= 1 <- DeutschJozsa(N, Oracle_One_Reference);
    set result w/= 2 <- DeutschJozsa(N, Oracle_OddNumberOfOnes_Reference);
    set result w/= 3 <- DeutschJozsa(N, Oracle_Kth_Qubit_Reference(_,_,1));
    return result;
  }

  operation RunBernsteinVazirani() : Int[]{
    let oracle = Oracle_ProductFunction_Reference(_, _, [1, 1, 1, 0]);
    mutable result = BernsteinVazirani(Length([1, 1, 1, 0]), oracle);
    return result;
  }
}