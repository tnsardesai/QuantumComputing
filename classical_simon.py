import numpy as np


def create_Uf(f, num_qubits):
    dim = 2**num_qubits
    # creating a 2^n x 2^n zeros matrix. 
    Uf = np.zeros((dim, dim), dtype=int)
    # This creates a list of the different permutations of n bits. 
    lst_bitseq = list(map(list, itertools.product([0, 1], repeat=n)))
    for col, bitseq in enumerate(lst_bitseq):
        # applying the operation on the last helper bit. 
        last_bit = bitseq[-1] ^ f(bitseq[:-1])
        final_bitseq = [bit for bit in bitseq]
        final_bitseq[-1] = last_bit
        # using the To-Form method discussed in class to help create the Uf matrix. 
        Uf[lst_bitseq.index(final_bitseq), col] = 1
    return Uf


def solve_eqns(eqns):
    assert eqns, 'No equations were passed.'
    s = np.ones(len(eqns[0]))
    for eqn in eqns:
        s[[bit==1 for bit in bits]] = 0
    return s

def main():
    solve_eqns([])

main()